using System;
using System.IO;
using System.Numerics;
using GLDotNet.Samples;
using ImageDotNet;
using static GLDotNet.GL;

namespace Sprites
{
    public class SpritesSample : Sample
    {
        public override int VersionMajor => 4;

        public override int VersionMinor => 0;

        private SpriteRenderer renderer;

        private uint texture;
        private int textureWidth;
        private int textureHeight;

        public SpritesSample()
        {
            this.Title = "Sprites";

            this.renderer = new SpriteRenderer();

            this.texture = glGenTexture();
            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, this.texture);

            // Image is an RGBImage.
            var image = Image.LoadTga("Box.tga").To<Rgb24>();

            this.textureWidth = image.Width;
            this.textureHeight = image.Height;

            using (var data = image.GetDataPointer())
            {
                glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGB, image.Width, image.Height, 0, GL_RGB, GL_UNSIGNED_BYTE, data.Pointer);
            }

            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);

            glEnable(GL_DEPTH_TEST);
            glDepthFunc(GL_LESS);

            glDisable(GL_CULL_FACE);
            glCullFace(GL_BACK);
            glFrontFace(GL_CW);
        }

        private float rotation = 0.0f;

        protected override void Update(float elapsed)
        {
            this.rotation += 0.1f * (1000.0f / elapsed);

            if (this.rotation >= 360.0f)
                this.rotation -= 360.0f;
        }

        protected override void Draw()
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

            glViewport(0, 0, this.Width, this.Height);

            this.renderer.Begin();

            this.renderer.Draw(
                this.texture,
                this.textureWidth,
                this.textureHeight,
                new Vector2(300, 300),
                tint: new Vector4(1, 0, 0, 0),
                origin: new Vector2(this.textureWidth / 2, this.textureHeight / 2),
                rotation: (float)(Math.PI * this.rotation / 180.0));

            this.renderer.End();
        }

        static void Main(string[] args)
        {
            using (var sample = new SpritesSample())
                sample.Run();
        }
    }
}
