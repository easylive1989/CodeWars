using System;
using System.Collections.Generic;

namespace Kata
{
    // https://www.codewars.com/kata/5870db16056584eab0000006
    // 5 kyu
    public class Dartboard
    {
        private class DistanceRange
        {
            private readonly double _minDistance;
            private readonly double _maxDistance;

            public DistanceRange(double min, double max)
            {
                _maxDistance = max;
                _minDistance = min;
            }

            public Boolean IsThisDistance(double distance)
            {
                return _minDistance <= distance && _maxDistance >= distance;
            }
        }

        private class AngleRange
        {
            private readonly double _minAngle;
            private readonly double _maxAngle;

            public AngleRange(double min, double max)
            {
                _maxAngle = max;
                _minAngle = min;
            }

            public Boolean IsThisRange(double angle)
            {
                if (_minAngle < _maxAngle)
                {
                    return _minAngle < angle && _maxAngle > angle;
                }
                else
                {
                    return _minAngle < angle || (angle > 0 && angle < _maxAngle);
                }
            }
        }

        private readonly Dictionary<DistanceRange, String> _magniDistanceDict = new Dictionary<DistanceRange, string>()
        {
            {new DistanceRange(0, 6.35), "DB"},
            {new DistanceRange(6.35, 15.9), "SB"},
            {new DistanceRange(15.9, 99), ""},
            {new DistanceRange(99, 107), "T"},
            {new DistanceRange(107, 162), ""},
            {new DistanceRange(162, 170), "D"},
            {new DistanceRange(170, Double.MaxValue), "X"},
        };

        private readonly Dictionary<AngleRange, int> _scoreAngleDict = new Dictionary<AngleRange, int>()
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

        private readonly List<String> _fixResultMagni = new List<string>() { "X", "DB", "SB"};

        public string GetScore(double x, double y)
        {
            var mangi = GetMagniByPosition(x, y);
            var score = _fixResultMagni.Contains(mangi) ? "" : GetScoreByPosition(x, y);
            return mangi + score;
        }

        private string GetMagniByPosition(double x, double y)
        {
            var distance = GetDistance(x, y);
            foreach (KeyValuePair<DistanceRange, string> entry in _magniDistanceDict)
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
            foreach (KeyValuePair<AngleRange, int> entry in _scoreAngleDict)
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