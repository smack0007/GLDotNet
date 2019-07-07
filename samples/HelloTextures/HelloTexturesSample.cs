using System;
using System.Runtime.InteropServices;
using GLDotNet.Samples;
using ImageDotNet;
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
layout(location = 2) in vec2 vertUV;

out vec3 fragColor;
out vec2 fragUV;

void main()
{
	gl_Position = vec4(vertPosition, 1.0);
	fragColor = vertColor;
    fragUV = vertUV;
}";

        private const string FragmentShader = @"#version 400
in vec3 fragColor;
in vec2 fragUV;

out vec4 outColor;

uniform sampler2D fragTexture;

void main()
{
	outColor = texture(fragTexture, fragUV);
}";

        private uint _vertexArray;
        private uint _texture;
        private uint _program;

        private int _fragTextureLocation;

        public HelloTriangleSample()
        {
            Title = "Hello Textures";

            float[] points = new float[] { 0.0f, 0.5f, 0.0f, 0.5f, -0.5f, 0.0f, -0.5f, -0.5f, 0.0f };
            float[] colors = new float[] { 1.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 1.0f };
            float[] uv = new float[] { 0.5f, 0.0f, 1.0f, 1.0f, 0.0f, 1.0f };

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

            uint uvBuffer = 0;
            glGenBuffers(1, &uvBuffer);
            glBindBuffer(GL_ARRAY_BUFFER, uvBuffer);
            fixed (float* uvPtr = uv)
            {
                glBufferData(GL_ARRAY_BUFFER, Marshal.SizeOf<float>() * uv.Length, uvPtr, GL_STATIC_DRAW);
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
            glBindBuffer(GL_ARRAY_BUFFER, uvBuffer);
            glVertexAttribPointer(2, 2, GL_FLOAT, false, 0, null);
            glEnableVertexAttribArray(0);
            glEnableVertexAttribArray(1);
            glEnableVertexAttribArray(2);

            fixed (uint* texturePtr = &_texture)
            {
                glGenTextures(1, texturePtr);
            }
            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _texture);
                        
            // Image is an RGBImage.
            var image = Image.LoadTga("Box.tga").To<Rgb24>();
            using (var data = image.GetDataPointer())
            {
                glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGB, image.Width, image.Height, 0, GL_RGB, GL_UNSIGNED_BYTE, data.Pointer.ToPointer());
            }

            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);

            uint vs = GLUtility.CreateAndCompileShader(GL_VERTEX_SHADER, VertexShader);
            uint fs = GLUtility.CreateAndCompileShader(GL_FRAGMENT_SHADER, FragmentShader);
            _program = GLUtility.CreateAndLinkProgram(vs, fs);

            _fragTextureLocation = glGetUniformLocation(_program, "fragTexture");

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

            glViewport(0, 0, Width, Height);

            glUseProgram(_program);
            glBindVertexArray(_vertexArray);

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _texture);
            glUniform1ui(_fragTextureLocation, 0); // 0 indicates Texture Unit 0

            glDrawArrays(GL_TRIANGLES, 0, 3);
        }

        public static void Main(string[] args)
        {
            using (var sample = new HelloTriangleSample())
                sample.Run();
        }
    }
}
