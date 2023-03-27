using MarsRobotProblem.Interfaces;
using MarsRobotProblem.MarsRobot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobotProblem.MarsRobot.Service
{
    internal class LeftCommand : INavigationCommand
    {
        public void Execute(Robot robot)
        {
            try
            {
                switch (robot.Direction)
                {
                    case Direction.North:
                        robot.Direction = Direction.West;
                        break;
                    case Direction.South:
                        robot.Direction = Direction.East;
                        break;
                    case Direction.East:
                        robot.Direction = Direction.North;
                        break;
                    case Direction.West:
                        robot.Direction = Direction.South;
                        break;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
