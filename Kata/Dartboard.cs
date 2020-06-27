using System;
using System.Collections.Generic;

namespace Kata
{
    public class Dartboard
    {
        internal class DistanceRange
        {
            public double MinDistance;
            public double MaxDistance;

            public DistanceRange(double min, double max)
            {
                MaxDistance = max;
                MinDistance = min;
            }

            public Boolean IsThisDistance(double distance)
            {
                return MinDistance <= distance && MaxDistance >= distance;
            }
        }

        internal class AngleRange
        {
            public double MinAngle;
            public double MaxAngle;

            public AngleRange(double min, double max)
            {
                MaxAngle = max;
                MinAngle = min;
            }

            public Boolean IsThisRange(double angle)
            {
                if (MinAngle < MaxAngle)
                {
                    return MinAngle < angle && MaxAngle > angle;
                }
                else
                {
                    return MinAngle < angle || (angle > 0 && angle < MaxAngle);
                }
            }
        }

        private Dictionary<DistanceRange, String> _MagniDistanceDict = new Dictionary<DistanceRange, string>()
        {
            {new DistanceRange(0, 6.35), "DB"},
            {new DistanceRange(6.35, 15.9), "SB"},
            {new DistanceRange(15.9, 99), ""},
            {new DistanceRange(99, 107), "T"},
            {new DistanceRange(107, 162), ""},
            {new DistanceRange(162, 170), "D"},
            {new DistanceRange(170, Double.MaxValue), "X"},
        };

        private Dictionary<AngleRange, int> _ScoreAngleDict = new Dictionary<AngleRange, int>()
        {
            {new AngleRange(351, 9), 6},
            {new AngleRange(9, 27), 13},
            {new AngleRange(27, 45), 4},
            {new AngleRange(45, 63), 18},
            {new AngleRange(63, 81), 1},
            {new AngleRange(81, 99), 20},
            {new AngleRange(99, 117), 5},
            {new AngleRange(117, 135), 12},
            {new AngleRange(135, 153), 9},
            {new AngleRange(153, 171), 14},
            {new AngleRange(171, 189), 11},
            {new AngleRange(189, 207), 8},
            {new AngleRange(207, 225), 16},
            {new AngleRange(225, 243), 7},
            {new AngleRange(243, 261), 19},
            {new AngleRange(261, 279), 3},
            {new AngleRange(279, 297), 17},
            {new AngleRange(297, 315), 2},
            {new AngleRange(315, 333), 15},
            {new AngleRange(333, 351), 10},
        };

        private List<String> _FixResultMagni = new List<string>() { "X", "DB", "SB"};

        public string GetScore(double x, double y)
        {
            var mangi = GetMagniByPosition(x, y);
            var score = _FixResultMagni.Contains(mangi) ? "" : GetScoreByPosition(x, y);
            return mangi + score;
        }

        private string GetMagniByPosition(double x, double y)
        {
            var distance = GetDistance(x, y);
            foreach (KeyValuePair<DistanceRange, string> entry in _MagniDistanceDict)
            {
                if (entry.Key.IsThisDistance(distance))
                {
                    return entry.Value;
                }
            }
            return "";
        }

        private string GetScoreByPosition(double x, double y)
        {
            var angle = GetAngle(x, y);
            foreach (KeyValuePair<AngleRange, int> entry in _ScoreAngleDict)
            {
                if (entry.Key.IsThisRange(angle))
                {
                    return Convert.ToString(entry.Value);
                }
            }
            return "";
        }

        private double GetDistance(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }

        private double GetAngle(double x, double y)
        {
            var result = Math.Atan2(y, x) * 180.0 / Math.PI;
            return result > 0 ? result : 360 + result;
        }
    }
}