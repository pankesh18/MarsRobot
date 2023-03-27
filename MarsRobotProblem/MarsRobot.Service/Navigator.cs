using MarsRobotProblem.Interfaces;
using MarsRobotProblem.MarsRobot.Data;
using MarsRobotProblem.MarsRobot.Service.MarsRobot.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobotProblem.MarsRobot.Service
{
    public class Navigator 
    {
        private IRobot robot;

        private string commands;

        private static Navigator instance = null;


        public static Navigator GetNavigator(IRobot robot, string commands)
        {
            if (instance == null)
            {
                    instance = new Navigator(robot, commands);
            }
            return instance;
        }

        private Navigator(IRobot robot, string commands)
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
