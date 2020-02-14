using System;
namespace Polygons.Library
{
    public class Octagon : IRegularPolygon
    {
        public Octagon()
        {
        }

        public int NumberOfSides { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int SideLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double GetArea()
        {
            throw new NotImplementedException();
        }

        public double GetPerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
