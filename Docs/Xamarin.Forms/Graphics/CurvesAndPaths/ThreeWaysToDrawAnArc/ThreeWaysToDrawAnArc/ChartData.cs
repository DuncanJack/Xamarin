using System;
using SkiaSharp;

namespace ThreeWaysToDrawAnArc
{
    class ChartData
    {
        public ChartData(int value, SKColor color)
        {
            Value = value;
            Color = color;
        }

        public int Value { get; private set; }
        public SKColor Color { get; private set; }
    }
}
