using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static GLDotNet.GL;

namespace GLDotNet.Samples
{
    public static class GLUtility
    {
        public static void CheckErrors(string functionName)
        {
            uint error = glGetError();

            if (error != GL_NO_ERROR)
                throw new InvalidOperationException($"{functionName} resulted in error: {GetErrorString(error)}");
        }

        public static uint CreateAndCompileShader(uint type, string source)
        {
            var shader = glCreateShader(type);
            ShaderSource(shader, source);
            glCompileShader(shader);

            CheckErrors(nameof(glCompileShader));

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
            CheckErrors(nameof(glLinkProgram));

            glGetProgramiv(program, GL_LINK_STATUS, out var result);
            if (result == GL_FALSE)
            {
                string infoLog = GetProgramInfoLog(program);
                throw new InvalidOperationException($"Failed to link program: {infoLog}");
            }

            return program;
        }

        public static string GetErrorString(uint error)
        {
            switch (error)
            {
                case GL_NO_ERROR: return nameof(GL_NO_ERROR);
                case GL_INVALID_ENUM: return nameof(GL_INVALID_ENUM);
                case GL_INVALID_VALUE: return nameof(GL_INVALID_VALUE);
                case GL_INVALID_FRAMEBUFFER_OPERATION: return nameof(GL_INVALID_FRAMEBUFFER_OPERATION);
                case GL_INVALID_OPERATION: return nameof(GL_INVALID_OPERATION);
                case GL_OUT_OF_MEMORY: return nameof(GL_OUT_OF_MEMORY);
                case GL_STACK_OVERFLOW: return nameof(GL_STACK_OVERFLOW);
                case GL_STACK_UNDERFLOW: return nameof(GL_STACK_UNDERFLOW);
            }

            return "UNKNOWN";
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
