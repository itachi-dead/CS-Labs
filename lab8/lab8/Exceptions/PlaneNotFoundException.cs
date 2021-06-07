using System;
using System.Collections.Generic;
using System.Text;

namespace lab8.Exceptions
{
    public class PlaneNotFoundException: Exception
    {
        public PlaneNotFoundException() { }

        public PlaneNotFoundException(string message)
            : base(message) { }

        public PlaneNotFoundException(string message, Exception inner)
            : base(message, inner) { }
    }
}
