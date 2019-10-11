using GLDotNet.Samples;
using ImageDotNet;
using static GLDotNet.GL;
using GLDotNet.Utilities;
using System;

namespace Framebuffer
{
    public unsafe class FramebufferSample : Sample
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

        private const string ScreenVertexShader = @"#version 400
layout(location = 0) in vec3 vertPosition;
layout(location = 1) in vec2 vertUV;

out vec2 fragUV;

void main()
{
	gl_Position = vec4(vertPosition, 1.0);
    fragUV = vertUV;
}";

        private const string ScreenFragmentShader = @"#version 400
in vec2 fragUV;

layout(location = 0) out vec4 outColor;

uniform sampler2D fragTexture;
uniform float fragTime;

void main()
{
	outColor = texture(fragTexture, fragUV + 0.005 * vec2(sin(fragTime + 1024.0 * fragUV.x), cos(fragTime + 768.0 * fragUV.y)));
}";

        private uint _texture;

        private uint _framebuffer;
        private uint _framebufferTexture;
        private uint _framebufferVertexArray;
        private uint _framebufferProgram;
        private int _framebufferFragTextureLocation;

        private uint _screenVertexArray;
        private uint _screenProgram;
        private int _screenFragTextureLocation;
        private int _screenFragTimeLocation;

        private float _totalElapsedTime;

        public FramebufferSample()
        {
            Title = "Framebuffer";

            float[] points = new float[]
            {
                -0.5f, -0.5f, 0.0f,
                -0.5f, 0.5f, 0.0f,
                0.5f, 0.5f, 0.0f,

                -0.5f, -0.5f, 0.0f,
                0.5f, 0.5f, 0.0f,
                0.5f, -0.5f, 0.0f,
            };

            float[] colors = new float[]
            {
                1.0f, 0.0f, 0.0f,
                0.0f, 1.0f, 0.0f,
                0.0f, 0.0f, 1.0f,

                1.0f, 0.0f, 0.0f,
                0.0f, 1.0f, 0.0f,
                1.0f, 0.0f, 1.0f
            };

            float[] uv = new float[]
            {
                0.0f, 1.0f,
                0.0f, 0.0f,
                1.0f, 0.0f,

                0.0f, 1.0f,
                1.0f, 0.0f,
                1.0f, 1.0f
            };

            float[] screenPoints = new float[]
            {
                -1.0f, -1.0f, 0.0f,
                -1.0f, 1.0f, 0.0f,
                1.0f, 1.0f, 0.0f,

                -1.0f, -1.0f, 0.0f,
                1.0f, 1.0f, 0.0f,
                1.0f, -1.0f, 0.0f,
            };

            float[] screenUv = new float[]
            {
                0.0f, 1.0f,
                0.0f, 0.0f,
                1.0f, 0.0f,

                0.0f, 1.0f,
                1.0f, 0.0f,
                1.0f, 1.0f
            };

            var pointsBuffer = glGenBuffer();
            glBindBuffer(GL_ARRAY_BUFFER, pointsBuffer);
            glBufferData(GL_ARRAY_BUFFER, sizeof(float) * points.Length, points, GL_STATIC_DRAW);

            var colorsBuffer = glGenBuffer();
            glBindBuffer(GL_ARRAY_BUFFER, colorsBuffer);
            glBufferData(GL_ARRAY_BUFFER, sizeof(float) * colors.Length, colors, GL_STATIC_DRAW);

            var uvBuffer = glGenBuffer();
            glBindBuffer(GL_ARRAY_BUFFER, uvBuffer);
            glBufferData(GL_ARRAY_BUFFER, sizeof(float) * uv.Length, uv, GL_STATIC_DRAW);

            _framebufferVertexArray = glGenVertexArray();
            glBindVertexArray(_framebufferVertexArray);
            glBindBuffer(GL_ARRAY_BUFFER, pointsBuffer);
            glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, IntPtr.Zero);
            glBindBuffer(GL_ARRAY_BUFFER, colorsBuffer);
            glVertexAttribPointer(1, 3, GL_FLOAT, false, 0, IntPtr.Zero);
            glBindBuffer(GL_ARRAY_BUFFER, uvBuffer);
            glVertexAttribPointer(2, 2, GL_FLOAT, false, 0, IntPtr.Zero);
            glEnableVertexAttribArray(0);
            glEnableVertexAttribArray(1);
            glEnableVertexAttribArray(2);
            glBindVertexArray(0);

            var screenPointsBuffer = glGenBuffer();
            glBindBuffer(GL_ARRAY_BUFFER, screenPointsBuffer);
            glBufferData(GL_ARRAY_BUFFER, sizeof(float) * screenPoints.Length, screenPoints, GL_STATIC_DRAW);

            var screenUvBuffer = glGenBuffer();
            glBindBuffer(GL_ARRAY_BUFFER, screenUvBuffer);
            glBufferData(GL_ARRAY_BUFFER, sizeof(float) * screenUv.Length, screenUv, GL_STATIC_DRAW);

            _screenVertexArray = glGenVertexArray();
            glBindVertexArray(_screenVertexArray);
            glBindBuffer(GL_ARRAY_BUFFER, screenPointsBuffer);
            glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, IntPtr.Zero);
            glBindBuffer(GL_ARRAY_BUFFER, screenUvBuffer);
            glVertexAttribPointer(1, 2, GL_FLOAT, false, 0, IntPtr.Zero);
            glEnableVertexAttribArray(0);
            glEnableVertexAttribArray(1);
            glBindVertexArray(0);

            _framebuffer = glGenFramebuffer();
            glBindFramebuffer(GL_FRAMEBUFFER, _framebuffer);
            _framebufferTexture = glGenTexture();
            glBindTexture(GL_TEXTURE_2D, _framebufferTexture);
            glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA, 1024, 768, 0, GL_RGBA, GL_UNSIGNED_BYTE, IntPtr.Zero);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_NEAREST);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_NEAREST);
            uint renderbuffer = glGenRenderbuffer();
            glBindRenderbuffer(GL_RENDERBUFFER, renderbuffer);
            glRenderbufferStorage(GL_RENDERBUFFER, GL_DEPTH_COMPONENT, 1024, 768);
            glFramebufferRenderbuffer(GL_FRAMEBUFFER, GL_DEPTH_ATTACHMENT, GL_RENDERBUFFER, renderbuffer);

            glFramebufferTexture(GL_FRAMEBUFFER, GL_COLOR_ATTACHMENT0, _framebufferTexture, 0);

            // Set the list of draw buffers.
            uint[] drawBuffers = new uint[] { GL_COLOR_ATTACHMENT0 };
            unsafe
            {
                fixed (uint* drawBuffersPtr = drawBuffers)
                {
                    glDrawBuffers(1, drawBuffersPtr);
                }
            }

            if (glCheckFramebufferStatus(GL_FRAMEBUFFER) != GL_FRAMEBUFFER_COMPLETE)
                throw new InvalidOperationException("Framebuffer Incomplete");

            glBindFramebuffer(GL_FRAMEBUFFER, 0);

            _texture = glGenTexture();
            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _texture);

            // Image is an RGBImage.
            var image = Image.LoadTga("Box.tga").To<Rgb24>();
            using (var data = image.GetDataPointer())
            {
                glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGB, image.Width, image.Height, 0, GL_RGB, GL_UNSIGNED_BYTE, data.Pointer);
            }

            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);

            uint vs = GLUtility.CreateAndCompileShader(GL_VERTEX_SHADER, VertexShader);
            uint fs = GLUtility.CreateAndCompileShader(GL_FRAGMENT_SHADER, FragmentShader);
            _framebufferProgram = GLUtility.CreateAndLinkProgram(vs, fs);
            _framebufferFragTextureLocation = glGetUniformLocation(_framebufferProgram, "fragTexture");

            uint screenVs = GLUtility.CreateAndCompileShader(GL_VERTEX_SHADER, ScreenVertexShader);
            uint screenFs = GLUtility.CreateAndCompileShader(GL_FRAGMENT_SHADER, ScreenFragmentShader);
            _screenProgram = GLUtility.CreateAndLinkProgram(screenVs, screenFs);
            _screenFragTextureLocation = glGetUniformLocation(_screenProgram, "fragTexture");
            _screenFragTimeLocation = glGetUniformLocation(_screenProgram, "fragTime");

            glEnable(GL_DEPTH_TEST);
            glDepthFunc(GL_LESS);

            glEnable(GL_CULL_FACE);
            glCullFace(GL_BACK);
            glFrontFace(GL_CW);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            glDeleteProgram(_framebufferProgram);
            glDeleteProgram(_screenProgram);
            glDeleteFramebuffer(_framebuffer);
            glDeleteTexture(_texture);
            glDeleteTexture(_framebufferTexture);
            glDeleteVertexArray(_framebufferVertexArray);
            glDeleteVertexArray(_screenVertexArray);
        }

        protected override void Update(float elapsed)
        {
            _totalElapsedTime += elapsed;
        }

        protected override void Draw()
        {
            glBindFramebuffer(GL_FRAMEBUFFER, _framebuffer);
            glClearColor(0, 0, 0, 0);
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glViewport(0, 0, 1024, 768);

            glUseProgram(_framebufferProgram);
            glBindVertexArray(_framebufferVertexArray);

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _texture);
            glUniform1ui(_framebufferFragTextureLocation, 0); // 0 indicates Texture Unit 0

            glDrawArrays(GL_TRIANGLES, 0, 6);

            glBindFramebuffer(GL_FRAMEBUFFER, 0);
            glClearColor(0, 0, 0, 0);
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glViewport(0, 0, Width, Height);

            glUseProgram(_screenProgram);
            glBindVertexArray(_screenVertexArray);

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _framebufferTexture);
            glUniform1ui(_screenFragTextureLocation, 0); // 0 indicates Texture Unit 0
            glUniform1f(_screenFragTimeLocation, _totalElapsedTime);

            glDrawArrays(GL_TRIANGLES, 0, 6);
        }

        public static void Main(string[] args)
        {
            using (var sample = new FramebufferSample())
                sample.Run();
        }
    }
}
