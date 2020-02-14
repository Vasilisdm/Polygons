using System;

namespace Polygons.Library
{
    public class ConcreteRegularPolygon
    {
        public int NumberOfSides { get; set; }
        private int _sideLength;
        public int SideLength { get { return _sideLength; } set { _sideLength = value; } };
    }
}
