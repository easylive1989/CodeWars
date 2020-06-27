using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class CarPark
    {
        public string[] Escape(int[,] carpark)
        {
            var result = new List<string>();

            Point nextStart = FindStart(carpark);

            nextStart = FindWayToLastLevel(carpark, nextStart, result);
            
            result.Add(CalculateToExit(carpark, nextStart.Position));
            
            return result.ToArray();
        }

        private Point FindWayToLastLevel(int[,] carpark, Point nextStart, List<string> result)
        {
            var lastStair = nextStart.Position;
            for (int level = nextStart.Level; level < carpark.GetLength(0) - 1; level++)
            {
                var stairIdx = -1;
                for (int i = 0; i < carpark.GetLength(1); i++)
                {
                    if (carpark[level, i] == 1)
                    {
                        stairIdx = i;
                    }
                }

                var stepToStair = (stairIdx > lastStair ? "R" : "L") + Math.Abs(stairIdx - lastStair);
                lastStair = stairIdx;
                result.Add(stepToStair);
            }
            return new Point()
            {
                Level = 0,
                Position = lastStair
            };
        }

        private Point FindStart(int[,] carpark)
        {
            Point nextStart = new Point();
            for (int level = 0; level < carpark.GetLength(0) - 1; level++)
            {
                var startIdx = FindStart(carpark, level);
                if (startIdx == -1)
                {
                    continue;
                }

                nextStart = new Point()
                {
                    Level = level,
                    Position = startIdx
                };
                break;
            }

            return nextStart;
        }


        private int FindStart(int[,] carpark, int level)
        {
            int startIdx = -1;
            for (int i = 0; i < carpark.GetLength(1); i++)
            {
                if (carpark[level, i] == 2)
                {
                    startIdx = i;
                }
            }

            return startIdx;
        }

        private string CalculateToExit(int[,] carpark, int startIdx)
        {
            var stepCount = carpark.GetLength(1) - 1 - startIdx;
            return "R" + stepCount;
        }
    }

    public class Point
    {
        public int Level { get; set; }
        public int Position { get; set; }
    }
}
