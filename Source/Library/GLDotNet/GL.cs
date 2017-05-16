using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GLDotNet
{
    public sealed partial class GL
    {
        private static readonly int[] IntBuffer = new int[1];
        private static readonly uint[] UintBuffer = new uint[1];

        public delegate void DebugProc(
            uint source,
            uint type,
            uint id,
            uint severity,
            int length,
            string message,
            IntPtr userParam);

        private void Initialize()
        {
        }

        private void CheckErrors(string functionName)
        {
            uint error = this._GetError();

            if (error != NO_ERROR)
                throw new GLException($"{functionName} resulted in error: {GetErrorString(error)}");
        }

        private string GetErrorString(uint error)
        {
            switch (error)
            {
                case NO_ERROR: return "NO_ERROR";
                case INVALID_ENUM: return "INVALID_ENUM";
                case INVALID_VALUE: return "INVALID_VALUE";
                case INVALID_FRAMEBUFFER_OPERATION: return "INVALID_FRAMEBUFFER_OPERATION";
                case INVALID_OPERATION: return "INVALID_OPERATION";
                case OUT_OF_MEMORY: return "OUT_OF_MEMORY";
                case STACK_OVERFLOW: return "STACK_OVERFLOW";
                case STACK_UNDERFLOW: return "STACK_UNDERFLOW";
            }

            return "UNKNOWN";
        }

        public string GetString(uint name)
        {
            return Marshal.PtrToStringAnsi(this._GetString(name));
        }

        public void ShaderSource(uint shader, string source)
        {
            int length = source.Length;
            this._ShaderSource(shader, 1, ref source, ref length);
            CheckErrors("ShaderSource");
        }

        public int GetProgramiv(uint program, uint pname)
        {
            this._GetProgramiv(program, pname, out int @params);
            CheckErrors("GetProgramiv");
            return @params;
        }

        public string GetProgramInfoLog(uint program)
        {
            int infoLogLegth = this.GetProgramiv(program, GL.INFO_LOG_LENGTH);

            StringBuilder infoLog = new StringBuilder(infoLogLegth);
            this._GetProgramInfoLog(program, infoLog.Capacity, out int length, infoLog);
            CheckErrors("GetProgramInfoLog");
            return infoLog.ToString();
        }

        public int GetShaderiv(uint shader, uint pname)
        {
            this._GetShaderiv(shader, pname, out int @params);
            CheckErrors("GetShaderiv");
            return @params;
        }

        public string GetShaderInfoLog(uint shader)
        {
            int infoLogLegth = this.GetShaderiv(shader, GL.INFO_LOG_LENGTH);

            StringBuilder infoLog = new StringBuilder(infoLogLegth);
            this._GetShaderInfoLog(shader, infoLog.Capacity, out int length, infoLog);
            CheckErrors("GetShaderInfoLog");
            return infoLog.ToString();
        }

        public uint CompileShader(string source, uint type)
        {
            var shaderHandle = this.CreateShader(type);
            this.ShaderSource(shaderHandle, source);
            this.CompileShader(shaderHandle);

            if (this.GetShaderiv(shaderHandle, GL.COMPILE_STATUS) == GL.FALSE)
            {
                string infoLog = this.GetShaderInfoLog(shaderHandle);
                throw new GLException($"Failed to compile shader: {infoLog}");
            }

            return shaderHandle;
        }

        public void LinkProgram(uint program)
        {
            this._LinkProgram(program);
            if (this.GetProgramiv(program, GL.LINK_STATUS) == GL.FALSE)
            {
                string infoLog = this.GetProgramInfoLog(program);
                throw new GLException($"Failed to link program: {infoLog}");
            }
        }
    }
}
