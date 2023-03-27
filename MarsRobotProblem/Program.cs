using MarsRobotProblem.Interfaces;
using MarsRobotProblem.MarsRobot.Data;
using MarsRobotProblem.MarsRobot.Service;
using MarsRobotProblem.MarsRobot.Service.MarsRobot.Factories;

namespace MarsPlateauRobot
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter grid size of the Mars Plateau (Example 3x3):");
                string[] GridSize = (Console.ReadLine()).ToLower().Split('x');
                Plateau.xLimit = Convert.ToInt32(GridSize[0]);
                Plateau.yLimit = Convert.ToInt32(GridSize[1]);

                Console.WriteLine("Enter navigation instructions (Example RLRLFL)");
                string Instruction = Console.ReadLine();

                IRobot robot = RobotFactory.CreateRobot();
                Navigator nav = Navigator.GetNavigator(robot, Instruction);
                nav.Navigate();

                Console.WriteLine(robot.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!!!");
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
