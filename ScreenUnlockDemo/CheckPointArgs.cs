using System;

namespace ScreenUnlockDemo
{
    public  class CheckPointArgs:EventArgs
    {
        public CheckPointArgs()
        {
        }

        public bool Result { get; set; }
    }
}