using System;
using System.Collections.Generic;

namespace Kata
{
    // https://www.codewars.com/kata/591eab1d192fe0435e000014
    // 5 kyu
    public class CarPark
    {
        public string[] Escape(int[,] carpark)
        {
            if (carpark[carpark.GetLength(0) - 1, carpark.GetLength(1) - 1] == 2)
            {
                return new string[0];
            }
            var result = new List<string>();

            var nextStart = FindStart(carpark);

            nextStart = FindWayToLastLevel(carpark, nextStart, result);

            var calculateToExit = CalculateToExit(carpark, nextStart.Position);
            if (calculateToExit != null)
            {
                result.Add(calculateToExit);
            }
            
            return result.ToArray();
        }

        private Point FindWayToLastLevel(int[,] carpark, Point nextStart, List<string> result)
        {
            var lastStair = nextStart.Position;
            for (int level = nextStart.Level; level < carpark.GetLength(0) - 1;)
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
                result.Add(stepToStair);
                lastStair = stairIdx;
                
                
                for (var stairlevel = level; stairlevel < carpark.GetLength(1); stairlevel++)
                {
                    if (carpark[stairlevel, stairIdx] != 1)
                    {
                        result.Add("D" + (stairlevel - level));
                        level += (stairlevel - level);
                        break;
                    }
                }
            }
            return new Point()
            {
                Level = 0,
                Position = lastStair
            };
        }

        private Point FindStart(int[,] carpark)
        {
            var nextStart = new Point();
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
            if (stepCount != 0)
            {
                return "R" + stepCount;
            }

            return null;
        }
    }

    public class Point
    {
        public int Level { get; set; }
        public int Position { get; set; }
    }
}
