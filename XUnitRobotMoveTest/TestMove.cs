using System;
using Xunit;
using RobotMovement;

namespace XUnitRobotMoveTest
{
    public class TestMove
    {
        [Fact]
        public void MoveThreeTimesEast()
        {
            Robot Toy = new Robot { direction = "east" };

            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.Equal(3, Toy.east);
        }

        [Fact]
        public void MoveFourTimesEast()
        {
            Robot Toy = new Robot { direction = "east" };

            Toy.Move();
            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.Equal(4, Toy.east);
        }

        [Fact]
        public void MoveThreeTimesWest()
        {
            Robot Toy = new Robot { direction = "west" };

            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.Equal(-3, Toy.east);
        }

        [Fact]
        public void MoveFourTimesWest()
        {
            Robot Toy = new Robot { direction = "west" };

            Toy.Move();
            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.Equal(-4, Toy.east);
        }

        [Fact]
        public void MoveThreeTimesNorth()
        {
            Robot Toy = new Robot { direction = "north" };

            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.Equal(3, Toy.north);
        }

        [Fact]
        public void MoveFourTimesNorth()
        {
            Robot Toy = new Robot { direction = "north" };

            Toy.Move();
            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.Equal(4, Toy.north);
        }

        [Fact]
        public void MoveThreeTimesSouth()
        {
            Robot Toy = new Robot { direction = "south" };

            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.Equal(-3, Toy.north);
        }

        [Fact]
        public void MoveFourTimesSouth()
        {
            Robot Toy = new Robot { direction = "south" };

            Toy.Move();
            Toy.Move();
            Toy.Move();
            Toy.Move();

            Assert.Equal(-4, Toy.north);
        }

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
