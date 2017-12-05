using System;
using System.Collections.Generic;
using System.Text;

namespace GLDotNet
{
    public sealed partial class GL
    {
        public GLUtility Utility { get; private set; }

        public sealed class GLUtility
        {
            private readonly GL gl;

            internal GLUtility(GL gl)
            {
                this.gl = gl;
            }

            public uint CreateAndCompileShader(ShaderType type, string source)
            {
                var shader = this.gl.CreateShader(type);
                this.gl.ShaderSource(shader, source);
                this.gl.CompileShader(shader);

                if (this.gl.GetShaderiv(shader, COMPILE_STATUS) == FALSE)
                {
                    string infoLog = this.gl.GetShaderInfoLog(shader);
                    throw new GLException($"Failed to compile shader: {infoLog}");
                }

                return shader;
            }

            public uint CreateAndLinkProgram(params uint[] shaders)
            {
                uint program = this.gl.CreateProgram();
                
                foreach (var shader in shaders)
                    this.gl.AttachShader(program, shader);

                this.gl.LinkProgram(program);

                if (this.gl.GetProgramiv(program, GL.LINK_STATUS) == GL.FALSE)
                {
                    string infoLog = this.gl.GetProgramInfoLog(program);
                    throw new GLException($"Failed to link program: {infoLog}");
                }

                return program;
            }
        }
    }
}
