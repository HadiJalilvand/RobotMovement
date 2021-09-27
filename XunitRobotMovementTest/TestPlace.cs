using System;
using Xunit;
using RobotMovement;

namespace XUnitRobotMoveTest
{
    public class TestPlace
    {
        [Fact]
        public void ValidLocationsForFiveByFiveTable()
        {
            Table table = new Table(5, 5);

            Assert.True(table.IsValidLocation(0, 0), "(0, 0) is True");
            Assert.True(table.IsValidLocation(4, 4), "(4, 4) is True");
            Assert.False(table.IsValidLocation(5, 5), "(5, 5) is False");
            Assert.False(table.IsValidLocation(-1, -1), "(-1, -1) is False");
        }
    }
}
