///////////////////////
// This example is modified version of the example found at
// https://github.com/capnramses/antons_opengl_tutorials_book/blob/master/03_vertex_buffer_objects/main.cpp
///////////////////////

using System;
using System.Runtime.InteropServices;
using GLDotNet.Samples;
using static GLDotNet.GL;

namespace HelloTriangle
{
    public unsafe class HelloTriangleSample : Sample
    {
        public override int VersionMajor => 4;
        public override int VersionMinor => 0;

        private const string VertexShader = @"#version 400
layout(location = 0) in vec3 vertPosition;
layout(location = 1) in vec3 vertColor;

out vec3 fragColor;

void main()
{
	fragColor = vertColor;
	gl_Position = vec4(vertPosition, 1.0);
}";

        private const string FragmentShader = @"#version 400
in vec3 fragColor;
out vec4 outColor;

void main()
{
	outColor = vec4(fragColor, 1.0);
}";

        private readonly uint _vertexArray;
        private readonly uint _shaderProgram;

        private int _drawOffset = 0;

        public HelloTriangleSample()
        {
            Title = "Hello Triangle";

            float[] points = new float[]
            {
                0.0f, 0.5f, 0.0f, 0.5f, -0.5f, 0.0f, -0.5f, -0.5f, 0.0f,
                0.0f, -0.5f, 0.0f, -0.5f, 0.5f, 0.0f, 0.5f, 0.5f, 0.0f
            };

            float[] colors = new float[]
            {
                1.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 1.0f,
                1.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 1.0f
            };

            uint pointsBuffer = 0;
            glGenBuffers(1, &pointsBuffer);
            glBindBuffer(GL_ARRAY_BUFFER, pointsBuffer);
            fixed (float* pointsPtr = points)
            {
                glBufferData(GL_ARRAY_BUFFER, Marshal.SizeOf<float>() * points.Length, pointsPtr, GL_STATIC_DRAW);
            }

            uint colorsBuffer = 0;
            glGenBuffers(1, &colorsBuffer);
            glBindBuffer(GL_ARRAY_BUFFER, colorsBuffer);
            fixed (float* colorsPtr = colors)
            {
                glBufferData(GL_ARRAY_BUFFER, Marshal.SizeOf<float>() * colors.Length, colorsPtr, GL_STATIC_DRAW);
            }

            fixed (uint* vertexArrayPtr = &_vertexArray)
            {
                glGenVertexArrays(1, vertexArrayPtr);
            }
            glBindVertexArray(_vertexArray);
            glBindBuffer(GL_ARRAY_BUFFER, pointsBuffer);
            glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, null);
            glBindBuffer(GL_ARRAY_BUFFER, colorsBuffer);
            glVertexAttribPointer(1, 3, GL_FLOAT, false, 0, null);
            glEnableVertexAttribArray(0);
            glEnableVertexAttribArray(1);

            uint vs = GLUtility.CreateAndCompileShader(GL_VERTEX_SHADER, VertexShader);
            uint fs = GLUtility.CreateAndCompileShader(GL_FRAGMENT_SHADER, FragmentShader);
            _shaderProgram = GLUtility.CreateAndLinkProgram(vs, fs);

            glEnable(GL_DEPTH_TEST);
            glDepthFunc(GL_LESS);

            glEnable(GL_CULL_FACE);
            glCullFace(GL_BACK);
            glFrontFace(GL_CW);
        }

        protected override void OnKeyPress(Keys key, KeyMods mods)
        {
            _drawOffset += 3;
            if (_drawOffset >= 6)
            {
                _drawOffset = 0;
            }
        }

        protected override void Draw()
        {
            glClearColor(0, 0, 0, 0);
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

            glViewport(0, 0, Width, Height);

            glUseProgram(_shaderProgram);
            glBindVertexArray(_vertexArray);
            glDrawArrays(GL_TRIANGLES, _drawOffset, 3);
        }

        public static void Main(string[] args)
        {
            using (var sample = new HelloTriangleSample())
                sample.Run();
        }
    }
}
