using MarsRobotProblem.Interfaces;
using MarsRobotProblem.MarsRobot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobotProblem.MarsRobot.Service
{
    internal class RightCommand : INavigationCommand
    {
        public void Execute(IRobot robot)
        {

            try
            {
                switch (robot.Direction)
                {
                    case Direction.North:
                        robot.Direction = Direction.East;
                        break;
                    case Direction.South:
                        robot.Direction = Direction.West;
                        break;
                    case Direction.East:
                        robot.Direction = Direction.South;
                        break;
                    case Direction.West:
                        robot.Direction = Direction.North;
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
