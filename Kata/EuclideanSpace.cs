using System;
using Kata.Models;

namespace Kata
{
    public class EuclideanSpace
    {
        public double Calculate2dDistance(string coordinate1, string coordinate2)
        {
            var point1 = Point.Create2dPoint(coordinate1);
            var point2 = Point.Create2dPoint(coordinate2);
            return Math.Sqrt(Math.Pow(Math.Abs(point1.X - point2.X), 2) +
                             Math.Pow(Math.Abs(point1.Y - point2.Y), 2));
        }

        public double Calculate3dDistance(string coordinate1, string coordinate2)
        {
            var point1 = Point.Create3dPoint(coordinate1);
            var point2 = Point.Create3dPoint(coordinate2);
            return Math.Sqrt(Math.Pow(Math.Abs(point1.X - point2.X), 2) +
                             Math.Pow(Math.Abs(point1.Y - point2.Y), 2) +
                             Math.Pow(Math.Abs(point1.Z - point2.Z), 2));
        }
    }
}