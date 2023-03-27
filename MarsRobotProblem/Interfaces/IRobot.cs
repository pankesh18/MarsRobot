using MarsRobotProblem.MarsRobot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobotProblem.Interfaces
{
    public class IRobot
    {
        public Direction Direction { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }
}
