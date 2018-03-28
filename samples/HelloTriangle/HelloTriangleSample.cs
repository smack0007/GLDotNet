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

        private uint[] vertexArray;
        private uint shaderProgram;

        public HelloTriangleSample()
        {
            this.Title = "Hello Triangle";

            float[] points = new float[] { 0.0f, 0.5f, 0.0f, 0.5f, -0.5f, 0.0f, -0.5f, -0.5f, 0.0f };
            float[] colors = new float[] { 1.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 1.0f };

            var pointsBuffer = glGenBuffer();
            glBindBuffer(GL_ARRAY_BUFFER, pointsBuffer);
            glBufferData(GL_ARRAY_BUFFER, sizeof(float) * points.Length, points, GL_STATIC_DRAW);

            var colorsBuffer = glGenBuffer();            
            glBindBuffer(GL_ARRAY_BUFFER, colorsBuffer);
            glBufferData(GL_ARRAY_BUFFER, sizeof(float) * colors.Length, colors, GL_STATIC_DRAW);

            this.vertexArray = new uint[1];
            glGenVertexArrays(1, vertexArray);
            glBindVertexArray(this.vertexArray[0]);
            glBindBuffer(GL_ARRAY_BUFFER, pointsBuffer);
            glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, IntPtr.Zero);
            glBindBuffer(GL_ARRAY_BUFFER, colorsBuffer);
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
            glClearColor(0, 0, 0, 0);
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
