using System;
using System.IO;
using GLDotNet.Samples;
using ImageDotNet;
using static GLDotNet.GL;

namespace HelloTriangle
{
    public class HelloTriangleSample : Sample
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

        private uint vertexArray;
        private uint texture;
        private uint program;

        private int fragTextureLocation;

        public HelloTriangleSample()
        {
            this.Title = "Hello Textures";

            float[] points = new float[] { 0.0f, 0.5f, 0.0f, 0.5f, -0.5f, 0.0f, -0.5f, -0.5f, 0.0f };
            float[] colors = new float[] { 1.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 1.0f };
            float[] uv = new float[] { 0.5f, 0.0f, 1.0f, 1.0f, 0.0f, 1.0f };

            var pointsBuffer = glGenBuffer();
            glBindBuffer(GL_ARRAY_BUFFER, pointsBuffer);
            glBufferData(GL_ARRAY_BUFFER, sizeof(float) * points.Length, points, GL_STATIC_DRAW);

            var colorsBuffer = glGenBuffer();
            glBindBuffer(GL_ARRAY_BUFFER, colorsBuffer);
            glBufferData(GL_ARRAY_BUFFER, sizeof(float) * colors.Length, colors, GL_STATIC_DRAW);

            var uvBuffer = glGenBuffer();
            glBindBuffer(GL_ARRAY_BUFFER, uvBuffer);
            glBufferData(GL_ARRAY_BUFFER, sizeof(float) * uv.Length, uv, GL_STATIC_DRAW);

            this.vertexArray = glGenVertexArray();
            glBindVertexArray(this.vertexArray);
            glBindBuffer(GL_ARRAY_BUFFER, pointsBuffer);
            glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, IntPtr.Zero);
            glBindBuffer(GL_ARRAY_BUFFER, colorsBuffer);
            glVertexAttribPointer(1, 3, GL_FLOAT, false, 0, IntPtr.Zero);
            glBindBuffer(GL_ARRAY_BUFFER, uvBuffer);
            glVertexAttribPointer(2, 2, GL_FLOAT, false, 0, IntPtr.Zero);
            glEnableVertexAttribArray(0);
            glEnableVertexAttribArray(1);
            glEnableVertexAttribArray(2);

            this.texture = glGenTexture();
            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, this.texture);
                        
            // Image is an RGBImage.
            var image = Image.LoadTga("Box.tga");
            using (var data = image.GetDataPointer())
            {
                glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGB, image.Width, image.Height, 0, GL_RGB, GL_UNSIGNED_BYTE, data.Pointer);
            }

            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);

            uint vs = GLUtility.CreateAndCompileShader(GL_VERTEX_SHADER, VertexShader);
            uint fs = GLUtility.CreateAndCompileShader(GL_FRAGMENT_SHADER, FragmentShader);
            this.program = GLUtility.CreateAndLinkProgram(vs, fs);

            this.fragTextureLocation = glGetUniformLocation(this.program, "fragTexture");

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

            glUseProgram(this.program);
            glBindVertexArray(this.vertexArray);

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, this.texture);
            glUniform1ui(this.fragTextureLocation, 0); // 0 indicates Texture Unit 0

            glDrawArrays(GL_TRIANGLES, 0, 3);
        }

        public static void Main(string[] args)
        {
            using (var sample = new HelloTriangleSample())
                sample.Run();
        }
    }
}
