using System;
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
            CheckErrors(nameof(glCreateShader));

            ShaderSource(shader, source);

            glCompileShader(shader);
            CheckErrors(nameof(glCompileShader));

            var result = glGetShaderi(shader, GL_COMPILE_STATUS);
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

            var result = glGetProgrami(program, GL_LINK_STATUS);
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

        public static unsafe string GetProgramInfoLog(uint program)
        {
            var infoLogLength = glGetProgrami(program, GL_INFO_LOG_LENGTH);

            StringBuilder infoLog = new StringBuilder(infoLogLength);
            glGetProgramInfoLog(program, infoLog.Capacity, &infoLogLength, infoLog);
            return infoLog.ToString();
        }

        public static unsafe string GetShaderInfoLog(uint shader)
        {
            var infoLogLength = glGetShaderi(shader, GL_INFO_LOG_LENGTH);

            StringBuilder infoLog = new StringBuilder(infoLogLength);
            glGetShaderInfoLog(shader, infoLog.Capacity, &infoLogLength, infoLog);
            return infoLog.ToString();
        }

        public static unsafe void ShaderSource(uint shader, string source)
        {
            int length = source.Length;
            glShaderSource(shader, 1, new string[] { source }, &length);
            CheckErrors(nameof(glShaderSource));
        }
    }
}
