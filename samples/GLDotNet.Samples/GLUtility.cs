using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static GLDotNet.GL;

namespace GLDotNet.Samples
{
    public static class GLUtility
    {
        public static uint CreateAndCompileShader(uint type, string source)
        {
            var shader = glCreateShader(type);
            ShaderSource(shader, source);
            glCompileShader(shader);

            glGetShaderiv(shader, GL_COMPILE_STATUS, out var result);
            if (result == GL_FALSE)
            {
                string infoLog = GetShaderInfoLog(shader);
                throw new InvalidOperationException($"Failed to compile shader: {infoLog}");
            }

            return shader;
        }

        public static uint CreateAndLinkProgram(params uint[] shaders)
        {
            uint program = glCreateProgram();

            foreach (var shader in shaders)
                glAttachShader(program, shader);

            glLinkProgram(program);

            glGetProgramiv(program, GL_LINK_STATUS, out var result);
            if (result == GL_FALSE)
            {
                string infoLog = GetProgramInfoLog(program);
                throw new InvalidOperationException($"Failed to link program: {infoLog}");
            }

            return program;
        }

        public static string GetString(uint name)
        {
            return Marshal.PtrToStringAnsi(glGetString(name));
        }

        public static string GetProgramInfoLog(uint program)
        {
            glGetProgramiv(program, GL_INFO_LOG_LENGTH, out var infoLogLegth);

            StringBuilder infoLog = new StringBuilder(infoLogLegth);
            glGetProgramInfoLog(program, infoLog.Capacity, out int length, infoLog);
            return infoLog.ToString();
        }

        public static string GetShaderInfoLog(uint shader)
        {
            glGetShaderiv(shader, GL_INFO_LOG_LENGTH, out var infoLogLength);

            StringBuilder infoLog = new StringBuilder(infoLogLength);
            glGetShaderInfoLog(shader, infoLog.Capacity, out int length, infoLog);
            return infoLog.ToString();
        }

        public static void ShaderSource(uint shader, string source)
        {
            int length = source.Length;
            glShaderSource(shader, 1, ref source, ref length);
        }
    }
}
