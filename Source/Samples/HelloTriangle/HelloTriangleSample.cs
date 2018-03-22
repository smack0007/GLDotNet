///////////////////////
// This example is modified version of the example found at
// https://github.com/capnramses/antons_opengl_tutorials_book/blob/master/03_vertex_buffer_objects/main.cpp
///////////////////////

using System;
using GLDotNet.Samples;
using static GLDotNet.GL;
using static GLDotNet.WGL;

namespace HelloTriangle
{
    public class HelloTriangleSample : Sample
    {
        private const string VertexShader = @"#version 450
layout(location = 0) in vec3 vertPosition;
layout(location = 1) in vec3 vertColor;

out vec3 fragColor;

void main()
{
	fragColor = vertColor;
	gl_Position = vec4(vertPosition, 1.0);
}";

        private const string FragmentShader = @"#version 450
in vec3 fragColor;
out vec4 outColor;

void main()
{
	outColor = vec4(fragColor, 1.0);
}";

        private uint[] vertexArray;
        private uint shaderProgram;

        public HelloTriangleSample()
        {
            this.Title = "Hello Triangle";

            float[] points = new float[] { 0.0f, 0.5f, 0.0f, 0.5f, -0.5f, 0.0f, -0.5f, -0.5f, 0.0f };
            float[] colors = new float[] { 1.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 1.0f };

            var pointsBuffer = new uint[1];
            glGenBuffers(1, pointsBuffer);
            glBindBuffer(GL_ARRAY_BUFFER, pointsBuffer[0]);
            using (var memory = MemoryBlock.Create(points))
            {
                glBufferData(GL_ARRAY_BUFFER, sizeof(float) * points.Length, memory.DataPointer, GL_STATIC_DRAW);
            }

            var colorsBuffer = new uint[1];
            glGenBuffers(1, colorsBuffer);
            glBindBuffer(GL_ARRAY_BUFFER, colorsBuffer[0]);
            using (var memory = MemoryBlock.Create(colors))
            {
                glBufferData(GL_ARRAY_BUFFER, memory.Length, memory.DataPointer, GL_STATIC_DRAW);
            }

            this.vertexArray = new uint[1];
            glGenVertexArrays(1, vertexArray);
            glBindVertexArray(this.vertexArray[0]);
            glBindBuffer(GL_ARRAY_BUFFER, pointsBuffer[0]);
            glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, IntPtr.Zero);
            glBindBuffer(GL_ARRAY_BUFFER, colorsBuffer[0]);
            glVertexAttribPointer(1, 3, GL_FLOAT, false, 0, IntPtr.Zero);
            glEnableVertexAttribArray(0);
            glEnableVertexAttribArray(1);

            uint vs = GLUtility.CreateAndCompileShader(GL_VERTEX_SHADER, VertexShader);
            uint fs = GLUtility.CreateAndCompileShader(GL_FRAGMENT_SHADER, FragmentShader);
            this.shaderProgram = GLUtility.CreateAndLinkProgram(vs, fs);

            glEnable(GL_DEPTH_TEST);
            glDepthFunc(GL_LESS);

            glEnable(GL_CULL_FACE);
            glCullFace(GL_BACK);
            glFrontFace(GL_CW);
        }

        protected override void Draw()
        {
            glClearColor(1, 0, 1, 0);
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

            glViewport(0, 0, this.Width, this.Height);

            glUseProgram(this.shaderProgram);
            glBindVertexArray(this.vertexArray[0]);
            glDrawArrays(GL_TRIANGLES, 0, 3);

            wglSwapBuffers();
        }

        public static void Main(string[] args)
        {
            using (var sample = new HelloTriangleSample())
                sample.Run();
        }
    }
}
