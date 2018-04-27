using System;
using System.ComponentModel;
using System.Diagnostics;
using static GLFWDotNet.GLFW;
using static GLDotNet.GL;
using System.IO;

namespace GLDotNet.Samples
{
    public abstract class Sample : IDisposable
    {
        private const float TimeBetweenFrames = 1000.0f / 60.0f;

        private IntPtr window;

        private Stopwatch stopwatch;
        private float lastElapsed;
        private float elapsedSinceLastFrame;

        private float fpsElapsed;

        private GLFWwindowsizefun windowResizeCallback;

        public abstract int VersionMajor { get; }
        public abstract int VersionMinor { get; }

        private string title = "GLDotNet Sample";

        public string Title
        {
            get { return this.title; }

            set
            {
                if (value != this.title)
                {
                    this.title = value;
                    glfwSetWindowTitle(this.window, value);
                }
            }
        }

        private int width = 1024;

        public int Width
        {
            get { return this.width; }

            set
            {
                if (value != this.width)
                {
                    this.width = value;
                    glfwSetWindowSize(this.window, this.width, this.height);
                }
            }
        }

        private int height = 768;

        public int Height
        {
            get { return this.height; }

            set
            {
                if (value != this.height)
                {
                    this.height = value;
                    glfwSetWindowSize(this.window, this.width, this.height);
                }
            }
        }

        public int FramesPerSecond { get; private set; }

        public Sample()
        {
            if (glfwInit() == 0)
                throw new InvalidOperationException("Failed to initialize GLFW.");

            glfwWindowHint(GLFW_CLIENT_API, GLFW_OPENGL_API);
            glfwWindowHint(GLFW_OPENGL_PROFILE, GLFW_OPENGL_CORE_PROFILE);
            glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, this.VersionMajor);
            glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, this.VersionMinor);

            this.window = glfwCreateWindow(this.width, this.height, this.title, IntPtr.Zero, IntPtr.Zero);
            if (window == IntPtr.Zero)
            {
                glfwTerminate();
                throw new InvalidOperationException("Failed to create window.");
            }

            this.windowResizeCallback = this.OnWindowResized;
            glfwSetWindowSizeCallback(this.window, this.windowResizeCallback);

            glfwMakeContextCurrent(this.window);

            glInit(glfwGetProcAddress, this.VersionMajor, this.VersionMinor);

            var basePath = Path.GetDirectoryName(typeof(Sample).Assembly.Location);
            Directory.SetCurrentDirectory(basePath);
        }

        ~Sample()
        {
            this.Dispose(false);
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            glfwTerminate();
        }

        private void OnWindowResized(IntPtr window, int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void Run()
        {
            this.stopwatch = Stopwatch.StartNew();

            while (glfwWindowShouldClose(this.window) == 0)
            {
                glfwPollEvents();

                this.Tick();
            }
        }

        private void Tick()
        {
            float currentElapsed = (float)stopwatch.Elapsed.TotalMilliseconds;
            float deltaElapsed = currentElapsed - this.lastElapsed;
            this.elapsedSinceLastFrame += deltaElapsed;
            this.lastElapsed = currentElapsed;

            if (this.elapsedSinceLastFrame >= TimeBetweenFrames)
            {
                this.Update(this.elapsedSinceLastFrame);
                this.Draw();
                glfwSwapBuffers(window);

                this.elapsedSinceLastFrame -= TimeBetweenFrames;
                this.FramesPerSecond++;
            }

            this.fpsElapsed += deltaElapsed;

            if (this.fpsElapsed >= 1000.0f)
            {
                this.fpsElapsed -= 1000.0f;
                this.FramesPerSecond = 0;
            }
        }

        protected virtual void Update(float elapsed)
        {
        }

        protected virtual void Draw()
        {
        }
    }
}
