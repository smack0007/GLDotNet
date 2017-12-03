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

layout(location = 0) in vec3 vertex_position;
layout(location = 1) in vec3 vertex_colour;

out vec3 colour;

void main() {
	colour = vertex_colour;
	gl_Position = vec4(vertex_position, 1.0);
}";

        private const string FragmentShader = @"#version 450

in vec3 colour;
out vec4 frag_colour;

void main() {
	frag_colour = vec4 (colour, 1.0);
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
            this.GL.VertexAttribPointer(0, 3, GL.FLOAT, false, 0, IntPtr.Zero);
            this.GL.BindBuffer(BufferTarget.ArrayBuffer, colorsBuffer);
            this.GL.VertexAttribPointer(1, 3, GL.FLOAT, false, 0, IntPtr.Zero);
            this.GL.EnableVertexAttribArray(0);
            this.GL.EnableVertexAttribArray(1);

            uint vs = this.GL.CompileShader(VertexShader, GL.VERTEX_SHADER);
            uint fs = this.GL.CompileShader(FragmentShader, GL.FRAGMENT_SHADER);            

            this.shaderProgram = this.GL.CreateProgram();
            this.GL.AttachShader(this.shaderProgram, fs);
            this.GL.AttachShader(this.shaderProgram, vs);
            this.GL.LinkProgram(this.shaderProgram);

            var status = this.GL.GetProgramiv(this.shaderProgram, GL.LINK_STATUS);
            if (status != GL.TRUE)
            {
                // TODO: Get error  
            }

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
