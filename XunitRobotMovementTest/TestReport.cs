using System;
using Xunit;
using RobotMovement;

namespace XUnitRobotMoveTest
{
    public class TestReport
    {
        [Fact]
        public void ReportLocation()
        {
            Robot Toy = new Robot
            {
                direction = "north",
                east = 5,
                north = 4
            };

            string expected = "5,4,NORTH";

            string position = Toy.Report();

            Assert.Equal(expected, position);
        }
    }
}
