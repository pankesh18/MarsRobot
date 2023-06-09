﻿using MarsRobotProblem.MarsRobot.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobotProblem.Interfaces
{
    public interface ICommandInterpreter
    {
        public INavigationCommand Interpret(char command);
    }
}
