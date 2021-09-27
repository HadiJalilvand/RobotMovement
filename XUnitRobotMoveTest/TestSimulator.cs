using System;
using Xunit;
using RobotMovement;

namespace XUnitRobotMoveTest
{
    public class TestSimulator
    {
        [Fact]
        public void PlaceRobotOntoValidLocation()
        {
            Table tableTop = new Table(4, 4);
            Simulator instance = new Simulator(tableTop);
            instance.Place(0, 0, "NORTH");

            Robot expectedToy = new Robot
            {
                direction = "north",
                east = 0,
                north = 0
            };

            Assert.Equal(expectedToy.east, instance.Toy.east);
            Assert.Equal(expectedToy.north, instance.Toy.north);
            Assert.Equal(expectedToy.direction, instance.Toy.direction);
        }

        [Fact]
        public void PlaceRobotOntoInvalidLocation()
        {
            Table tableTop = new Table(4, 4);
            Simulator instance = new Simulator(tableTop);
            instance.Place(5, 5, "NORTH");

            Assert.Null(instance.Toy);
        }
    }
}
