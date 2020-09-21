using System.Collections.Generic;
using System.Linq;
using Kata.Models;

namespace Kata
{
    public class DragonBalls
    {
        private readonly List<DragonBall> _dragonBalls;
        private const int MaxVisibleDistance = 100;

        public DragonBalls(List<DragonBall> dragonBalls)
        {
            _dragonBalls = dragonBalls;
        }

        public IEnumerable<DragonBall> GetVisibleList()
        {
            return _dragonBalls.Where(ball => ball.Position.GetDistance() < MaxVisibleDistance);
        }

        public DragonBall this[int index] => _dragonBalls[index];
    }

    public class DragonBallRadar
    {
        private readonly DragonBalls _dragonBalls;

        public DragonBallRadar(DragonBalls dragonBalls)
        {
            _dragonBalls = dragonBalls;
        }
        
        public RadarScreen Visible(int index)
        {
            return new RadarScreen()
            {
                UserPosition = GetUserPosition(),
                DragonBalls = new List<DragonBall>() { _dragonBalls[index] },
                Scale = GetScale(),
                Rotation = GetRotation(),
            };
        }
        
        public RadarScreen Visible()
        {
            return new RadarScreen()
            {
                UserPosition = GetUserPosition(),
                DragonBalls = _dragonBalls.GetVisibleList(),
                Scale = GetScale(),
                Rotation = GetRotation(),
            };
        }

        private int GetScale()
        {
            throw new System.NotImplementedException();
        }

        private Point GetUserPosition()
        {
            throw new System.NotImplementedException();
        }

        private int GetRotation()
        {
            throw new System.NotImplementedException();
        }
    }

    public enum Direction
    {
        North,
        South,
        West,
        East
    }

    public class RadarScreen
    {
        public Point UserPosition { get; set; }
        
        public IEnumerable<DragonBall> DragonBalls { get; set; }

        public int Scale { get; set; }
        public int Rotation { get; set; }
    }

    public class DragonBall
    {
        public Point Position { get; set; }
    }
    
    
}