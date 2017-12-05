///////////////////////
// This example is modified version of the example found at
// https://github.com/capnramses/antons_opengl_tutorials_book/blob/master/03_vertex_buffer_objects/main.cpp
///////////////////////

using System;
using GLDotNet;
using GLDotNet.Samples;

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

        private uint vertexArray;
        private uint shaderProgram;

        public HelloTriangleSample()
        {
            this.Title = "Hello Triangle";

            float[] points = new float[] { 0.0f, 0.5f, 0.0f, 0.5f, -0.5f, 0.0f, -0.5f, -0.5f, 0.0f };
            float[] colors = new float[] { 1.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 1.0f };

            var pointsBuffer = this.GL.GenBuffer();
            this.GL.BindBuffer(BufferTarget.ArrayBuffer, pointsBuffer);
            this.GL.BufferData(BufferTarget.ArrayBuffer, points, BufferUsage.StaticDraw);

            var colorsBuffer = this.GL.GenBuffer();
            this.GL.BindBuffer(BufferTarget.ArrayBuffer, colorsBuffer);
            this.GL.BufferData(BufferTarget.ArrayBuffer, colors, BufferUsage.StaticDraw);

            this.vertexArray = this.GL.GenVertexArray();
            this.GL.BindVertexArray(this.vertexArray);
            this.GL.BindBuffer(BufferTarget.ArrayBuffer, pointsBuffer);
            this.GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 0, IntPtr.Zero);
            this.GL.BindBuffer(BufferTarget.ArrayBuffer, colorsBuffer);
            this.GL.VertexAttribPointer(1, 3, VertexAttribPointerType.Float, false, 0, IntPtr.Zero);
            this.GL.EnableVertexAttribArray(0);
            this.GL.EnableVertexAttribArray(1);

            uint vs = this.GL.Utility.CreateAndCompileShader(ShaderType.VertexShader, VertexShader);
            uint fs = this.GL.Utility.CreateAndCompileShader(ShaderType.FragmentShader, FragmentShader);
            this.shaderProgram = this.GL.Utility.CreateAndLinkProgram(vs, fs);            

            this.GL.Enable(EnableCap.DepthTest);
            this.GL.DepthFunc(DepthFunction.Less);

            this.GL.Enable(EnableCap.CullFace);
            this.GL.CullFace(CullFaceMode.Back);
            this.GL.FrontFace(FrontFaceDirection.Cw);
        }

        protected override void Draw()
        {
            this.GL.ClearColor(0, 0, 0, 0);
            this.GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            this.GL.Viewport(0, 0, this.Width, this.Height);

            this.GL.UseProgram(this.shaderProgram);
            this.GL.BindVertexArray(this.vertexArray);
            this.GL.DrawArrays(PrimitiveType.Triangles, 0, 3);

            this.GL.SwapBuffers();
        }

        public static void Main(string[] args)
        {
            using (var sample = new HelloTriangleSample())
                sample.Run();
        }
    }
}
