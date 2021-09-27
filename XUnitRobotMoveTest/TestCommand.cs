using System;
using Xunit;
using RobotMovement;

namespace XUnitRobotMoveTest
{
    public class TestCommand
    {
        [Fact]
        public void ProcessPlaceCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 2,3,EAST");

            Assert.NotNull(testSetup.Simulation.Toy);
        }

        [Fact]
        public void ProcessInvalidPlaceCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 6,3,EAST");

            Assert.Same(testSetup.ErrorInputs, testSetup.Message);
        }

        [Fact]
        public void ProcessMoveCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 2,3,EAST");
            testSetup.ProcessCommand("MOVE");

            Robot expected = new Robot { east = 3, north = 3, direction = "east" };

            Assert.Equal(expected.east, testSetup.Simulation.Toy.east);
        }

        [Fact]
        public void ProcessMoveWallCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 4,4,EAST");
            testSetup.ProcessCommand("MOVE");

            Robot expected = new Robot { east = 4, north = 4, direction = "east" };

            Assert.Equal(expected.east, testSetup.Simulation.Toy.east);
        }

        [Fact]
        public void ProcessRightCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 2,3,EAST");
            testSetup.ProcessCommand("RIGHT");

            Robot expected = new Robot { east = 2, north = 3, direction = "south" };

            Assert.Equal(expected.direction, testSetup.Simulation.Toy.direction);
        }

        [Fact]
        public void ProcessLeftCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 2,3,EAST");
            testSetup.ProcessCommand("LEFT");

            Robot expected = new Robot { east = 2, north = 3, direction = "north" };

            Assert.Equal(expected.direction, testSetup.Simulation.Toy.direction);
        }

        [Fact]
        public void ProcessReportCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("PLACE 2,3,EAST");
            testSetup.ProcessCommand("REPORT");

            string expected = "2,3,EAST";

            Assert.Equal(expected, testSetup.Message);
        }

        [Fact]
        public void ProcessInvalidCommand()
        {
            Command testSetup = new Command();
            Table table = new Table(5, 5);
            testSetup.Simulation = new Simulator(table);
            testSetup.ProcessCommand("GIBBERISH");

            string expected = testSetup.ErrorInputs;

            Assert.Equal(expected, testSetup.Message);
        }
    }
}
