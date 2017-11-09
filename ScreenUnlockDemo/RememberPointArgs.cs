using System;
using System.Collections.Generic;

namespace ScreenUnlockDemo
{
    public class RememberPointArgs:EventArgs
    {
        public RememberPointArgs()
        {
        }

        public IList<string> PointArray { get; set; }
    }
}