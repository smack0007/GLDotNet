using System;
using System.ComponentModel;
using System.Diagnostics;

namespace GLDotNet.Samples
{
    public partial class Sample : IDisposable
    {
        private const int DefaultWidth = 1024;
        private const int DefaultHeight = 768;
        private const float TimeBetweenFrames = 1000.0f / 60.0f;

        private string title;
        private int x;
        private int y;
        private int width;
        private int height;

        private Stopwatch stopwatch;
        private float lastElapsed;
        private float elapsedSinceLastFrame;

        private float fpsElapsed;

        public IntPtr Handle
        {
            get { return this.PlatformGetHandle(); }
        }

        public string Title
        {
            get { return this.title; }

            set
            {
                if (value != this.title)
                {
                    this.title = value;
                    this.PlatformSetTitle(value);
                }
            }
        }

        public int X
        {
            get { return this.x; }

            set
            {
                if (value != this.x)
                {
                    this.x = value;
                    this.PlatformSetPosition(this.x, this.y);
                }
            }
        }

        public int Y
        {
            get { return this.y; }

            set
            {
                if (value != this.y)
                {
                    this.y = value;
                    this.PlatformSetPosition(this.x, this.y);
                }
            }
        }

        public int Width
        {
            get { return this.width; }

            set
            {
                if (value != this.width)
                {
                    this.width = value;
                    this.PlatformSetSize(this.width, this.height);
                }
            }
        }

        public int Height
        {
            get { return this.height; }

            set
            {
                if (value != this.height)
                {
                    this.height = value;
                    this.PlatformSetSize(this.width, this.height);
                }
            }
        }

        public bool IsClosed { get; private set; }

        public event EventHandler<EventArgs> PositionChanged;

        public event EventHandler<EventArgs> SizeChanged;

        public event EventHandler<CancelEventArgs> Closing;

        public event EventHandler<EventArgs> Closed;

        public int FramesPerSecond { get; private set; }

        public GL GL { get; }

        public Sample()
        {
            this.PlatformInitialize();

            this.GL = new GL(new WGL(this.Handle, 4, 5));
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
            this.PlatformDispose(disposing);
        }

        private bool TriggerClose()
        {
            CancelEventArgs cancelEventArgs = new CancelEventArgs();
            this.OnClosing(cancelEventArgs);

            if (cancelEventArgs.Cancel)
                return false;

            this.OnClose(EventArgs.Empty);

            return true;
        }

        private void TriggerPositionChanged(int x, int y)
        {
            this.x = x;
            this.y = y;

            this.OnPositionChanged(EventArgs.Empty);
        }

        private void TriggerSizeChanged(int width, int height)
        {
            this.width = width;
            this.height = height;

            this.OnSizeChanged(EventArgs.Empty);
        }

        protected virtual void OnPositionChanged(EventArgs e)
        {
            this.PositionChanged?.Invoke(this, e);
        }

        protected virtual void OnSizeChanged(EventArgs e)
        {
            this.SizeChanged?.Invoke(this, e);
        }

        protected virtual void OnClosing(CancelEventArgs e)
        {
            this.Closing?.Invoke(this, e);
        }

        protected virtual void OnClose(EventArgs e)
        {
            this.IsClosed = true;
            this.Closed?.Invoke(this, e);
        }

        public void Show()
        {
            this.PlatformShow();
        }

        public void Hide()
        {
            this.PlatformHide();
        }

        public void Run()
        {
            this.Show();

            this.stopwatch = Stopwatch.StartNew();

            while (true)
            {
                if (this.IsClosed)
                    break;

                this.PlatformPollEvents();

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
