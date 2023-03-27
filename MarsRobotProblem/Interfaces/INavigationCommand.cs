
using MarsRobotProblem.MarsRobot.Data;
using MarsRobotProblem.MarsRobot.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRobotProblem.Interfaces
{
    public interface INavigationCommand
    {
        public void Execute(IRobot robot);
    }
}
