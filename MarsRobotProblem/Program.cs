using MarsRobotProblem.MarsRobot.Data;
using MarsRobotProblem.MarsRobot.Service;

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


                Console.WriteLine("Enter navigation instructions (Example RLRLFL)");
                string Instruction = Console.ReadLine();

                Robot robot = new Robot();
                Plateau.xLimit = Convert.ToInt32(GridSize[0]);
                Plateau.yLimit = Convert.ToInt32(GridSize[1]);

                Navigator nav = new Navigator(robot, Instruction);
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
