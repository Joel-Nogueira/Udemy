using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoStruct
{
    struct Point
    {
        public int X, Y;

        public override string ToString()
        {
            return "( X = " + X + ", Y = " + Y + ")";
        }
    }
}
