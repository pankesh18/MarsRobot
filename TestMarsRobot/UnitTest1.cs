using MarsRobotProblem.Interfaces;
using MarsRobotProblem.MarsRobot.Data;
using MarsRobotProblem.MarsRobot.Service;
using MarsRobotProblem.MarsRobot.Service.MarsRobot.Factories;

namespace TestMarsRobot
{
    public class Tests
    {

        [Test]
        public void TestNavigateLeft()
        {
            Plateau.xLimit = 5;
            Plateau.yLimit = 5;
            char command = 'l';

            IRobot robot = RobotFactory.CreateRobot();
            ICommandInterpreter interpreter = new NavCommandInterpreter();
            var robot_cmd= interpreter.Interpret(command);
            robot_cmd.Execute(robot);


            Assert.That(robot.Direction, Is.EqualTo(Direction.West));
        }

        [Test]
        public void TestNavigateRight()
        {
            Plateau.xLimit = 5;
            Plateau.yLimit = 5;
            char command = 'r';

            IRobot robot = RobotFactory.CreateRobot();
            ICommandInterpreter interpreter = new NavCommandInterpreter();
            var robot_cmd = interpreter.Interpret(command);
            robot_cmd.Execute(robot);


            Assert.That(robot.Direction, Is.EqualTo(Direction.East));
        }


        [Test]
        public void TestNavigateForward()
        {
            Plateau.xLimit = 5;
            Plateau.yLimit = 5;
            char command = 'f';

            IRobot robot = RobotFactory.CreateRobot();
            ICommandInterpreter interpreter = new NavCommandInterpreter();
            var robot_cmd = interpreter.Interpret(command);
            robot_cmd.Execute(robot);


            Assert.That(robot.y, Is.EqualTo(2));
        }

        [Test]
        public void TestPositionZero()
        {
            Plateau.xLimit = 5;
            Plateau.yLimit = 5;
            string nav_path = "FFRFLFLF";

            IRobot robot = RobotFactory.CreateRobot();
            Navigator nav = Navigator.GetNavigator(robot, nav_path);
            nav.Navigate();

            Assert.GreaterOrEqual(robot.x, 1);
            Assert.GreaterOrEqual(robot.y, 1);

        }


        [Test]
        public void TestPositionOutOfBound()
        {
            Plateau.xLimit = 5;
            Plateau.yLimit = 5;
            string nav_path = "FFRFLFLF";

            IRobot robot = RobotFactory.CreateRobot();
            Navigator nav = Navigator.GetNavigator(robot, nav_path);
            nav.Navigate();

            Assert.That(robot.x <= Plateau.xLimit);
            Assert.That(robot.y <= Plateau.yLimit);

        }
    }
}