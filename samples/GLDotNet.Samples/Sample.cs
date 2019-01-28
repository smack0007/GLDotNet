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

        private IntPtr _window;

        private Stopwatch _stopwatch;
        private float _lastElapsed;
        private float _elapsedSinceLastFrame;

        private float _fpsElapsed;

        private GLFWwindowsizefun _windowResizeCallback;
        private GLFWkeyfun _keyboardCallback;

        public abstract int VersionMajor { get; }
        public abstract int VersionMinor { get; }

        private string _title = "GLDotNet Sample";

        public string Title
        {
            get { return _title; }

            set
            {
                if (value != _title)
                {
                    _title = value;
                    glfwSetWindowTitle(_window, value);
                }
            }
        }

        private int _width = 1024;

        public int Width
        {
            get { return _width; }

            set
            {
                if (value != _width)
                {
                    _width = value;
                    glfwSetWindowSize(_window, _width, _height);
                }
            }
        }

        private int _height = 768;

        public int Height
        {
            get { return _height; }

            set
            {
                if (value != _height)
                {
                    _height = value;
                    glfwSetWindowSize(_window, _width, _height);
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
            glfwWindowHint(GLFW_CONTEXT_VERSION_MAJOR, VersionMajor);
            glfwWindowHint(GLFW_CONTEXT_VERSION_MINOR, VersionMinor);

            _window = glfwCreateWindow(_width, _height, _title, IntPtr.Zero, IntPtr.Zero);
            if (_window == IntPtr.Zero)
            {
                glfwTerminate();
                throw new InvalidOperationException("Failed to create window.");
            }

            _windowResizeCallback = OnWindowResized;
            glfwSetWindowSizeCallback(_window, _windowResizeCallback);

            _keyboardCallback = OnKeyboard;
            glfwSetKeyCallback(_window, _keyboardCallback);

            glfwMakeContextCurrent(_window);

            glInit(glfwGetProcAddress, VersionMajor, VersionMinor);

            var basePath = Path.GetDirectoryName(typeof(Sample).Assembly.Location);
            Directory.SetCurrentDirectory(basePath);
        }

        ~Sample()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            glfwTerminate();
        }

        private void OnWindowResized(IntPtr window, int width, int height)
        {
            _width = width;
            _height = height;
        }

        private void OnKeyboard(IntPtr window, int key, int scancode, int action, int mods)
        {
            if (action == GLFW_PRESS)
            {
                OnKeyPress((Keys)key, (KeyMods)mods);
            }
        }

        protected virtual void OnKeyPress(Keys key, KeyMods mods)
        {
        }

        public void Run()
        {
            _stopwatch = Stopwatch.StartNew();

            while (glfwWindowShouldClose(_window) == 0)
            {
                glfwPollEvents();

                Tick();
            }
        }

        private void Tick()
        {
            float currentElapsed = (float)_stopwatch.Elapsed.TotalMilliseconds;
            float deltaElapsed = currentElapsed - _lastElapsed;
            _elapsedSinceLastFrame += deltaElapsed;
            _lastElapsed = currentElapsed;

            bool shouldDraw = _elapsedSinceLastFrame >= TimeBetweenFrames;

            while (_elapsedSinceLastFrame >= TimeBetweenFrames)
            {
                Update(_elapsedSinceLastFrame);
                _elapsedSinceLastFrame -= TimeBetweenFrames;
            }

            if (shouldDraw)
            {
                Draw();
                glfwSwapBuffers(_window);
                FramesPerSecond++;
            }
            
            _fpsElapsed += deltaElapsed;

            if (_fpsElapsed >= 1000.0f)
            {
                _fpsElapsed -= 1000.0f;
                FramesPerSecond = 0;
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
