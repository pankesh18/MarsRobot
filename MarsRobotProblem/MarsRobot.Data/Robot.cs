﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobotProblem.MarsRobot.Data
{
    public class Robot
    {
        public Direction Direction { get;  set; }
        public int x { get;  set; }
        public int y { get;  set; }

        public Robot()
        {
            Direction = Direction.North;
            x = 1;
            y = 1;
        }

        public override string ToString()
        {
            return x.ToString() + "," + y.ToString() + "," + Direction.ToString();
        }
    }
}
