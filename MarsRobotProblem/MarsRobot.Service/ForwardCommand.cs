using MarsRobotProblem.Interfaces;
using MarsRobotProblem.MarsRobot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobotProblem.MarsRobot.Service
{
    internal class ForwardCommand : INavigationCommand
    {
        public void Execute(Robot robot)
        {
            try
            {
                switch (robot.Direction)
                {
                    case Direction.East:
                        if (robot.x < Plateau.xLimit)
                            robot.x++;
                        break;
                    case Direction.West:
                        if (robot.x > 1)
                            robot.x--;
                        break;
                    case Direction.North:
                        if (robot.y < Plateau.yLimit)
                            robot.y++;
                        break;
                    case Direction.South:
                        if (robot.y > 1)
                            robot.y--;
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
