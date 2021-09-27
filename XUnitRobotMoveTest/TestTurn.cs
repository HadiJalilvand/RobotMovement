using System;
using Xunit;
using RobotMovement;

namespace XUnitRobotMoveTest
{
    public class TestTurn
    {
        [Fact]
        public void WhenFacingNorthTurnLeft()
        {
            Robot Toy = new Robot { direction = "north" };

            Toy.TurnLeft();

            Assert.Equal("west", Toy.direction);

        }

        [Fact]
        public void WhenFacingNorthTurnRight()
        {
            Robot Toy = new Robot { direction = "north" };

            Toy.TurnRight();

            Assert.Equal("east", Toy.direction);

        }

        [Fact]
        public void WhenFacingEastTurnLeft()
        {
            Robot Toy = new Robot { direction = "east" };

            Toy.TurnLeft();

            Assert.Equal("north", Toy.direction);

        }

        [Fact]
        public void WhenFacingEastTurnRight()
        {
            Robot Toy = new Robot { direction = "east" };

            Toy.TurnRight();

            Assert.Equal("south", Toy.direction);

        }

        [Fact]
        public void WhenFacingSouthTurnLeft()
        {
            Robot Toy = new Robot { direction = "south" };

            Toy.TurnLeft();

            Assert.Equal("east", Toy.direction);

        }

        [Fact]
        public void WhenFacingSouthTurnRight()
        {
            Robot Toy = new Robot { direction = "south" };

            Toy.TurnRight();

            Assert.Equal("west", Toy.direction);

        }

        [Fact]
        public void WhenFacingWestTurnLeft()
        {
            Robot Toy = new Robot { direction = "west" };

            Toy.TurnLeft();

            Assert.Equal("south", Toy.direction);

        }

        [Fact]
        public void WhenFacingWestTurnRight()
        {
            Robot Toy = new Robot { direction = "west" };

            Toy.TurnRight();

            Assert.Equal("north", Toy.direction);

        }
    }
}
