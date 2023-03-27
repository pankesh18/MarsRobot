using MarsRobotProblem.Interfaces;
using MarsRobotProblem.MarsRobot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobotProblem.MarsRobot.Service.MarsRobot.Factories
{
    public static class RobotFactory
    {
        public static IRobot CreateRobot()
        {
            return new Robot();
        }
    }
}
