using System;
using System.Numerics;
using GLDotNet.Samples;
using ImageDotNet;
using static GLDotNet.GL;

namespace Sprites
{
    public unsafe class SpritesSample : Sample
    {
        public override int VersionMajor => 4;

        public override int VersionMinor => 0;

        private SpriteRenderer _renderer;

        private uint _texture;
        private int _textureWidth;
        private int _textureHeight;

        public SpritesSample()
        {
            Title = "Sprites";

            _renderer = new SpriteRenderer();

            fixed (uint* texturePtr = &_texture)
            {
                glGenTextures(1, texturePtr);
            }
            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _texture);

            // Image is an RGBImage.
            var image = Image.LoadTga("Box.tga").To<Rgb24>();

            _textureWidth = image.Width;
            _textureHeight = image.Height;

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
            rotation += 0.1f * (1000.0f / elapsed);

            if (rotation >= 360.0f)
                rotation -= 360.0f;
        }

        protected override void Draw()
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

            glViewport(0, 0, Width, Height);

            _renderer.Begin();

            _renderer.Draw(
                _texture,
                _textureWidth,
                _textureHeight,
                new Vector2(300, 300),
                tint: new Vector4(1, 0, 0, 0),
                origin: new Vector2(_textureWidth / 2, _textureHeight / 2),
                rotation: (float)(Math.PI * rotation / 180.0));

            _renderer.End();
        }

        static void Main(string[] args)
        {
            using (var sample = new SpritesSample())
                sample.Run();
        }
    }
}
