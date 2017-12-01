using System;
using GLDotNet;
using GLDotNet.Samples;

namespace HelloTriangle
{
    public class HelloTriangleSample : Sample
    {
        public HelloTriangleSample()
        {
            this.Title = "Hello Triangle";

        }

        protected override void Draw()
        {
            this.GL.ClearColor(0, 0, 0, 0);
            this.GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            this.GL.SwapBuffers();
        }

        public static void Main(string[] args)
        {
            using (var sample = new HelloTriangleSample())
                sample.Run();
        }
    }
}
