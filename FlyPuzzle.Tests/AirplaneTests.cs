using System;
using Xunit;
using FlyPuzzle.BusinessLogic;

namespace FlyPuzzle.Tests
{
    public class AirplaneTests
    {
        [Fact]
        public void ShouldBeAbleToCreateAirplane()
        {
            Airplane airplane = new Airplane();
        }

        [Fact]
        public void ShouldBeAbleToSetSpeed()
        {
            Airplane airplane = new Airplane();
            airplane.SetSpeed(200);
           
        }

        [Fact]
        public void ShouldBeAbleToGetSpeed()
        {
            Airplane airplane = new Airplane();
            airplane.SetSpeed(200);
            int currentSpeed = airplane.GetSpeed();
        }

        [Fact]
        public void ShouldHaveSpeedThatWasSet()
        {
            Airplane airplane = new Airplane();
            airplane.SetSpeed(200);
            int currentSpeed = airplane.GetSpeed();
            Assert.Equal(200, currentSpeed);
        }
    }
}
