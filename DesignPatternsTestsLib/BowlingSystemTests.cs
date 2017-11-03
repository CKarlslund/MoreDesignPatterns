using DesignPatternsLib;
using System;
using Xunit;

namespace DesignPatternsTestsLib
{
    public class BowlingSystemTests
    {
        [Fact]
        public void Can_Create_Bowling_System()
        {
            var bowlingSystem1 = BowlingSystem.Instance;
            var bowlingSystem2 = BowlingSystem.Instance;
            Assert.Equal(bowlingSystem1, bowlingSystem2);
        }
    }
}
