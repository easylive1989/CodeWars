using System;

namespace Kata.Models
{
    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public static Point Create2dPoint(double x, double y)
        {
            return new Point()
            {
                X = x,
                Y = y,
            };
        }
        
        public static Point Create2dPoint(string coordinate)
        {
            var axis = coordinate.Split(',');
            return new Point()
            {
                X = double.Parse(axis[0]),
                Y = double.Parse(axis[1]),
            };
        }
        
        public static Point Create3dPoint(string coordinate)
        {
            
            var axis = coordinate.Split(',');
            return new Point()
            {
                X = double.Parse(axis[0]),
                Y = double.Parse(axis[1]),
                Z = double.Parse(axis[2]),
            };
        }

        public double GetDistance()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public double GetAngle()
        {
            var result = Math.Atan2(Y, X) * 180.0 / Math.PI;
            return result > 0 ? result : 360 + result;
        }
    }
}