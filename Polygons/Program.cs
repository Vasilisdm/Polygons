using System;
using Polygons.Library;

namespace Polygons
{
    class Program
    {
        static void Main()
        {
            var octagon = new Octagon(3);
            Console.WriteLine(octagon.GetArea());
        }
    }
}
