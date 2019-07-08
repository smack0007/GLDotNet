using System;
using System.Numerics;
using System.Runtime.InteropServices;
using GLDotNet.Samples;
using static GLDotNet.GL;

namespace Sprites
{
    public unsafe sealed class SpriteRenderer : IDisposable
    {
        [StructLayout(LayoutKind.Sequential)]
        struct Vertex
        {
            public static readonly int SizeInBytes = Marshal.SizeOf<Vertex>();

            public Vector3 Position;
            public Vector4 Color;
            public Vector2 UV;
        }

        private Vertex[] _vertices;
        private int _vertexCount;

        private uint _texture;
        private int _textureWidth;
        private int _textureHeight;

        private uint _vertexBuffer;
        private uint _indexBuffer;
        private uint _vertexArray;

        private uint _program;
        private int _vertTranformLocation;
        private int _fragSamplerLocation;

        bool _drawInProgress;

        Matrix4x4 _transform = new Matrix4x4()
        {
            M33 = 1.0f,
            M44 = 1.0f,
            M41 = -1.0f,
            M42 = 1.0f
        };

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="maxSprites">The maximum number of sprites which can be batched.</param>
        public SpriteRenderer(int maxSprites = 1024)
        {
            if (maxSprites <= 0)
                throw new ArgumentOutOfRangeException(nameof(maxSprites), $"{nameof(maxSprites)} must be >= 1.");

            _vertices = new Vertex[maxSprites * 4];

            fixed (uint* vertexBufferPtr = &_vertexBuffer)
            {
                glGenBuffers(1, vertexBufferPtr);
            }
            glBindBuffer(GL_ARRAY_BUFFER, _vertexBuffer);
            glBufferData(GL_ARRAY_BUFFER, Vertex.SizeInBytes * _vertices.Length, null, GL_DYNAMIC_DRAW);
            GLUtility.CheckErrors(nameof(glBufferData));

            fixed (uint* vertexArrayPtr = &_vertexArray)
            {
                glGenVertexArrays(1, vertexArrayPtr);
            }
            glBindVertexArray(_vertexArray);
            glVertexAttribPointer(0, 3, GL_FLOAT, false, Vertex.SizeInBytes, (void*)0);
            GLUtility.CheckErrors(nameof(glVertexAttribPointer));
            glVertexAttribPointer(1, 4, GL_FLOAT, false, Vertex.SizeInBytes, (void*)Marshal.SizeOf<Vector3>());
            GLUtility.CheckErrors(nameof(glVertexAttribPointer));
            glVertexAttribPointer(2, 2, GL_FLOAT, false, Vertex.SizeInBytes, (void*)(Marshal.SizeOf<Vector3>() + Marshal.SizeOf<Vector4>()));
            GLUtility.CheckErrors(nameof(glVertexAttribPointer));
            glEnableVertexAttribArray(0);
            glEnableVertexAttribArray(1);
            glEnableVertexAttribArray(2);

            ushort[] indices = new ushort[1024 * 6];
            for (ushort i = 0, vertex = 0; i < indices.Length; i += 6, vertex += 4)
            {
                indices[i] = vertex;
                indices[i + 1] = (ushort)(vertex + 1);
                indices[i + 2] = (ushort)(vertex + 3);
                indices[i + 3] = (ushort)(vertex + 1);
                indices[i + 4] = (ushort)(vertex + 2);
                indices[i + 5] = (ushort)(vertex + 3);
            }

            fixed (uint* indexBufferPtr = &_indexBuffer)
            {
                glGenBuffers(1, indexBufferPtr);
            }
            glBindBuffer(GL_ARRAY_BUFFER, _indexBuffer);
            fixed (ushort* indicesPtr = indices)
            {
                glBufferData(GL_ARRAY_BUFFER, sizeof(ushort) * indices.Length, indicesPtr, GL_STATIC_DRAW);
            }
            GLUtility.CheckErrors(nameof(glBufferData));

            uint vertexShader = GLUtility.CreateAndCompileShader(GL_VERTEX_SHADER, VertexShaderCode);
            uint fragmentShader = GLUtility.CreateAndCompileShader(GL_FRAGMENT_SHADER, FragmentShaderCode);
            _program = GLUtility.CreateAndLinkProgram(vertexShader, fragmentShader);

            _vertTranformLocation = glGetUniformLocation(_program, "vertTransform");
            _fragSamplerLocation = glGetUniformLocation(_program, "fragSampler");
        }

        ~SpriteRenderer()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            fixed (uint* vertexBufferPtr = &_vertexBuffer)
            {
                glDeleteBuffers(1, vertexBufferPtr);
            }

            fixed (uint* indexBufferPtr = &_indexBuffer)
            {
                glDeleteBuffers(1, indexBufferPtr);
            }

            fixed (uint* vertexArrayPtr = &_vertexArray)
            {
                glDeleteVertexArrays(1, vertexArrayPtr);
            }
        }

        private void EnsureDrawInProgress()
        {
            if (!_drawInProgress)
                throw new InvalidOperationException("Draw not currently in progress.");
        }

        public void Begin()
        {
            if (_drawInProgress)
                throw new InvalidOperationException("Draw already in progress.");

            //this.graphics.BlendEnabled = true;
            //this.graphics.SourceBlendFactor = SourceBlendFactor.SourceAlpha;
            //this.graphics.DestinationBlendFactor = DestinationBlendFactor.OneMinusSourceAlpha;

            //this.graphics.DepthBufferEnabled = true;
            //this.graphics.DepthFunction = DepthFunction.LessThanOrEqual;

            _drawInProgress = true;
        }

        public void End()
        {
            EnsureDrawInProgress();

            Flush();

            _drawInProgress = false;
        }

        private void CalculateUV(float x, float y, ref Vector2 uv)
        {
            if (_textureWidth != 1 || _textureHeight != 1)
            {
                uv.X = x / _textureWidth;
                uv.Y = y / _textureHeight;
            }
            else
            {
                uv.X = 0;
                uv.Y = 0;
            }
        }

        private void AddQuad(
            ref Vector2 topLeft,
            ref Vector2 topRight,
            ref Vector2 bottomRight,
            ref Vector2 bottomLeft,
            Rectangle source,
            Vector4 color,
            float layerDepth)
        {
            if (_vertexCount == _vertices.Length)
                Flush();

            _vertices[_vertexCount].Position = new Vector3(topLeft, layerDepth);
            CalculateUV(source.Left, source.Top, ref _vertices[_vertexCount].UV);
            _vertices[_vertexCount].Color = color;

            _vertices[_vertexCount + 1].Position = new Vector3(topRight, layerDepth);
            CalculateUV(source.Right, source.Top, ref _vertices[_vertexCount + 1].UV);
            _vertices[_vertexCount + 1].Color = color;

            _vertices[_vertexCount + 2].Position = new Vector3(bottomRight, layerDepth);
            CalculateUV(source.Right, source.Bottom, ref _vertices[_vertexCount + 2].UV);
            _vertices[_vertexCount + 2].Color = color;

            _vertices[_vertexCount + 3].Position = new Vector3(bottomLeft, layerDepth);
            CalculateUV(source.Left, source.Bottom, ref _vertices[_vertexCount + 3].UV);            
            _vertices[_vertexCount + 3].Color = color;

            _vertexCount += 4;
        }

        public void Draw(
            uint texture,
            int textureWidth,
            int textureHeight,
            Vector2 destination,
            Rectangle? source = null,
            Vector4? tint = null,
            Vector2? origin = null,
            Vector2? scale = null,
            float rotation = 0.0f,
            float layerDepth = 0.0f)
        {
            DrawInternal(
                texture,
                textureWidth,
                textureHeight,
                destination,
                source != null ? source.Value.Width : textureWidth,
                source != null ? source.Value.Height : textureHeight,
                source,
                tint,
                origin,
                scale,
                rotation,
                layerDepth);
        }

        //public void Draw(
        //    Texture2D texture,
        //    Rectangle destination,
        //    Rectangle? source = null,
        //    Color4? tint = null,
        //    Vector2? origin = null,
        //    Vector2? scale = null,
        //    float rotation = 0.0f,
        //    float layerDepth = 0.0f)
        //{
        //    this.DrawInternal(
        //        texture,
        //        new Vector2(destination.X, destination.Y),
        //        destination.Width,
        //        destination.Height,
        //        source,
        //        tint,
        //        origin,
        //        scale,
        //        rotation,
        //        layerDepth);
        //}

        //public void Draw(
        //    SpriteSheet spriteSheet,
        //    int frame,
        //    Vector2 position,
        //    Color4? tint = null,
        //    Vector2? origin = null,
        //    Vector2? scale = null,
        //    float rotation = 0.0f,
        //    float layerDepth = 0.0f)
        //{
        //    if (spriteSheet == null)
        //        throw new ArgumentNullException("spriteSheet");

        //    Rectangle frameRect = spriteSheet[frame];

        //    this.DrawInternal(
        //        spriteSheet.Texture,
        //        position,
        //        frameRect.Width,
        //        frameRect.Height,
        //        frameRect,
        //        tint,
        //        origin,
        //        scale,
        //        rotation,
        //        layerDepth);
        //}

        private void DrawInternal(
            uint texture,
            int textureWidth,
            int textureHeight,
            Vector2 destination,
            int width,
            int height,
            Rectangle? source,
            Vector4? tint,
            Vector2? origin,
            Vector2? scale,
            float rotation,
            float layerDepth)
        {
            EnsureDrawInProgress();

            if (texture != _texture)
                Flush();

            _texture = texture;
            _textureWidth = textureWidth;
            _textureHeight = textureHeight;

            if (source == null)
                source = new Rectangle(0, 0, textureWidth, textureHeight);

            if (tint == null)
                tint = Vector4.One;

            if (origin == null)
                origin = Vector2.Zero;

            if (scale == null)
                scale = Vector2.One;

            Vector2 topLeft = new Vector2(-origin.Value.X, -origin.Value.Y);
            Vector2 topRight = new Vector2(width - origin.Value.X, -origin.Value.Y);
            Vector2 bottomRight = new Vector2(width - origin.Value.X, height - origin.Value.Y);
            Vector2 bottomLeft = new Vector2(-origin.Value.X, height - origin.Value.Y);

            Matrix4x4 rotationMatrix = Matrix4x4.CreateRotationZ(rotation);
            Matrix4x4 scaleMatrix = Matrix4x4.CreateScale(scale.Value.X, scale.Value.Y, 1.0f);
            Matrix4x4 translationMatrix = Matrix4x4.CreateTranslation(destination.X, destination.Y, 0.0f);

            Matrix4x4 transform = scaleMatrix * rotationMatrix * translationMatrix;

            topLeft = Vector2.Transform(topLeft, transform);
            topRight = Vector2.Transform(topRight, transform);
            bottomRight = Vector2.Transform(bottomRight, transform);
            bottomLeft = Vector2.Transform(bottomLeft, transform);
            
            AddQuad(
                ref topLeft,
                ref topRight,
                ref bottomRight,
                ref bottomLeft,
                source.Value,
                tint.Value,
                layerDepth);
        }

        //public Vector2 DrawString(
        //    TextureFont font,
        //    string text,
        //    Vector2 position,
        //    Color4? tint = null,
        //    Vector2? origin = null,
        //    Vector2? scale = null,
        //    float rotation = 0.0f,
        //    float layerDepth = 0.0f)
        //{
        //    if (font == null)
        //        throw new ArgumentNullException("font");

        //    if (text == null)
        //        throw new ArgumentNullException("text");

        //    if (text.Length == 0)
        //        return position;

        //    Size textSize = font.MeasureString(text);

        //    return this.DrawString(font, text, new Rectangle((int)position.X, (int)position.Y, textSize.Width, textSize.Height), tint, origin, scale, rotation, layerDepth);
        //}

        //public Vector2 DrawString(
        //    TextureFont font,
        //    string text,
        //    Rectangle destination,
        //    Color4? tint = null,
        //    Vector2? origin = null,
        //    Vector2? scale = null,
        //    float rotation = 0.0f,
        //    float layerDepth = 0.0f)
        //{
        //    if (font == null)
        //        throw new ArgumentNullException("font");

        //    if (text == null)
        //        throw new ArgumentNullException("text");

        //    if (text.Length == 0)
        //        return new Vector2(destination.X, destination.Y);

        //    if (tint == null)
        //        tint = Color4.White;

        //    if (origin == null)
        //        origin = Vector2.Zero;

        //    if (scale == null)
        //        scale = Vector2.One;

        //    float heightOfSingleLine = font.LineHeight * scale.Value.Y;

        //    if (heightOfSingleLine > destination.Height) // We can't draw anything
        //        return new Vector2(destination.X, destination.Y);

        //    Vector2 cursor = new Vector2(destination.X, destination.Y);

        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        // Skip characters we can't render.
        //        if (text[i] == '\r')
        //            continue;

        //        float widthOfChar = 0;

        //        if (text[i] == '\n' || cursor.X + (widthOfChar = font[text[i]].Width * scale.Value.X) > destination.Right)
        //        {
        //            cursor.X = destination.X;
        //            cursor.Y += heightOfSingleLine + font.LineSpacing;

        //            // If the next line extends past the destination, quit.
        //            if (cursor.Y + heightOfSingleLine > destination.Bottom)
        //                return cursor;

        //            // We can't render a new line.
        //            if (text[i] == '\n')
        //                continue;
        //        }

        //        Vector2 characterOrigin = origin.Value;
        //        characterOrigin.X -= cursor.X - destination.X;
        //        characterOrigin.Y -= cursor.Y - destination.Y;

        //        Rectangle letterSource = font[text[i]];
        //        Rectangle letterDestination = new Rectangle((int)cursor.X + (int)characterOrigin.X, (int)cursor.Y + (int)characterOrigin.Y, (int)widthOfChar, (int)heightOfSingleLine);

        //        this.Draw(
        //            font.Texture,
        //            letterDestination,
        //            letterSource,
        //            tint,
        //            characterOrigin,
        //            scale,
        //            rotation,
        //            layerDepth);

        //        cursor.X += widthOfChar + font.CharacterSpacing;
        //    }

        //    return cursor;
        //}

        private void Flush()
        {
            if (_vertexCount > 0)
            {
                Rectangle viewport = new Rectangle();
                glGetIntegerv(GL_VIEWPORT, &viewport.X);
                _transform.M11 = 2f / viewport.Width;
                _transform.M22 = -2f / viewport.Height;

                glBindBuffer(GL_ARRAY_BUFFER, _vertexBuffer);
                fixed (void* verticesPtr = _vertices)
                {
                    glBufferData(GL_ARRAY_BUFFER, Vertex.SizeInBytes * _vertexCount, verticesPtr, GL_DYNAMIC_DRAW);
                }
                GLUtility.CheckErrors(nameof(glBufferData));

                glBindVertexArray(_vertexArray);

                glUseProgram(_program);

                fixed (float* transformPtr = &_transform.M11)
                {
                    glUniformMatrix4fv(_vertTranformLocation, 1, false, transformPtr);
                }
                GLUtility.CheckErrors(nameof(glUniformMatrix4fv));
                
                glActiveTexture(GL_TEXTURE0);
                glBindTexture(GL_TEXTURE_2D, _texture);
                glUniform1i(_fragSamplerLocation, 0);
                GLUtility.CheckErrors(nameof(glUniform1ui));

                glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, _indexBuffer);
                glDrawElements(GL_TRIANGLES, (_vertexCount / 4) * 6, GL_UNSIGNED_SHORT, null);
                GLUtility.CheckErrors(nameof(glDrawElements));

                _vertexCount = 0;
            }
        }

        private const string VertexShaderCode =
@"#version 400

uniform mat4 vertTransform; 

layout(location = 0) in vec3 vertPosition; 
layout(location = 1) in vec4 vertColor; 
layout(location = 2) in vec2 vertUV; 

smooth out vec4 fragColor;
smooth out vec2 fragUV;

void main() 
{ 
    gl_Position = vertTransform * vec4(vertPosition, 1.0);
    fragColor = vertColor;
    fragUV = vertUV; 
}";

        private const string FragmentShaderCode =
@"#version 400

uniform sampler2D fragSampler;

smooth in vec4 fragColor;
smooth in vec2 fragUV; 

out vec4 outColor; 

void main() 
{ 
	outColor = texture(fragSampler, vec2(fragUV.x, fragUV.y)) * fragColor;
}";
    }
}
