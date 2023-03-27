using MarsRobotProblem.Interfaces;
using MarsRobotProblem.MarsRobot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobotProblem.MarsRobot.Service.MarsRobot.Factories
{
    public class NavCommandInterpreter : ICommandInterpreter
    {
        public INavigationCommand Interpret(char command)
        {
            try
            {
                if (char.ToLower(command) == 'l')
                {
                    return new LeftCommand();
                }
                else if (char.ToLower(command) == 'r')
                {
                    return new RightCommand();
                }
                else
                {
                    return new ForwardCommand();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
