using System;
using System.Collections.Generic;
using Kata.Models;

namespace Kata
{
    // https://www.codewars.com/kata/591eab1d192fe0435e000014
    // 5 kyu
    public class CarPark
    {
        private int _carParkLevel;
        private int _carParkWidth;
        
        public string[] Escape(int[,] carpark)
        {
            _carParkLevel = carpark.GetLength(0);
            _carParkWidth = carpark.GetLength(1);

            if (carpark[_carParkLevel - 1, _carParkWidth - 1] == 2)
            {
                return new string[0];
            }
            

            var nextStart = FindStart(carpark);
            
            var steps = new List<string>();
            nextStart = StepsToLastLevel(carpark, nextStart, steps);

            var calculateToExit = CalculateToExit(carpark, nextStart.Position);
            if (calculateToExit != null)
            {
                steps.Add(calculateToExit);
            }
            
            return steps.ToArray();
        }

        private CarpakPoint StepsToLastLevel(int[,] carpark, CarpakPoint nextStart, List<string> result)
        {
            var lastStair = nextStart.Position;
            for (int level = nextStart.Level; level < _carParkLevel - 1;)
            {
                var stairIdx = -1;
                for (int i = 0; i < _carParkWidth; i++)
                {
                    if (carpark[level, i] == 1)
                    {
                        stairIdx = i;
                    }
                }

                var stepToStair = (stairIdx > lastStair ? "R" : "L") + Math.Abs(stairIdx - lastStair);
                result.Add(stepToStair);
                lastStair = stairIdx;
                
                for (var stair = level; stair < _carParkWidth; stair++)
                {
                    if (carpark[stair, stairIdx] != 1)
                    {
                        result.Add("D" + (stair - level));
                        level += (stair - level);
                        break;
                    }
                }
            }
            return new CarpakPoint()
            {
                Level = 0,
                Position = lastStair
            };
        }

        private CarpakPoint FindStart(int[,] carpark)
        {
            var nextStart = new CarpakPoint();
            for (int level = 0; level < _carParkLevel - 1; level++)
            {
                var startIdx = FindStart(carpark, level);
                if (startIdx == -1)
                {
                    continue;
                }

                nextStart = new CarpakPoint()
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
            for (int i = 0; i < _carParkWidth; i++)
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
            var stepCount = _carParkWidth - 1 - startIdx;
            if (stepCount != 0)
            {
                return "R" + stepCount;
            }

            return null;
        }
    }
}
