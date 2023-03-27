using MarsRobotProblem.Interfaces;
using MarsRobotProblem.MarsRobot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobotProblem.MarsRobot.Service
{
    internal class Navigator 
    {
        private Robot robot;

        private string commands;


        public Navigator(Robot robot, string commands)
        {
            this.robot = robot;
            this.commands = commands;
        }


        public void Navigate()
        {
            ICommandInterpreter interpreter = new NavCommandInterpreter();

            foreach(char cmd in this.commands)
            {
                INavigationCommand command= interpreter.Interpret(cmd);
                command.Execute(robot);
            }
            
        }

   
    }
}
