namespace Sprites
{
    public struct Rectangle
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;

        public int Left => this.X;

        public int Top => this.Y;

        public int Right => this.X + this.Width;

        public int Bottom => this.Y + this.Height;

        public Rectangle(int x, int y, int width, int height)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }
    }
}
