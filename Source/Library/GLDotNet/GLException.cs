using System;

namespace GLDotNet
{
    public class GLException : Exception
    {
        public GLException(string message)
            : base(message)
        {
        }
    }
}
