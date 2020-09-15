namespace Kata.Models
{
    public class Point
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

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
    }
}