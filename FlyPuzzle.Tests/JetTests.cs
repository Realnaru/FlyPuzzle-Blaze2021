using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FlyPuzzle.BusinessLogic;

namespace FlyPuzzle.Tests
{
    public class JetTests
    {
        [Fact]
        public void ShouldBeAbleToCreateJet()
        {
            Jet jet = new Jet();
            
        }

        [Fact]
        public void ShouldBeAbleToSetSpeed()
        {
            Jet jet = new Jet();
            jet.SetSpeed(200);

        }

        [Fact]
        public void ShouldBeAbleToGetSpeed()
        {
            Jet jet = new Jet();
            jet.SetSpeed(200);
            int currentSpeed = jet.GetSpeed();

        }

        [Fact]
        public void ShouldHaveSpeedTwoTimesHigherThanWasSet()
        {
            Jet jet = new Jet();
            jet.SetSpeed(200);
            int currentSpeed = jet.GetSpeed();
            Assert.Equal(400, currentSpeed);

        }

        [Fact]
        public void ShouldBeAbleToAccelerate()
        {
            Jet jet = new Jet();
            jet.SetSpeed(200);
            int currentSpeed = jet.GetSpeed();
            Assert.Equal(400, currentSpeed);
            jet.Accelerate();
        }

        [Fact]
        public void ShouldBeAbleToFlyTwoTimesFasterAfterAcceleration()
        {
            Jet jet = new Jet();
            jet.SetSpeed(200);
            int currentSpeed = jet.GetSpeed();
            Assert.Equal(400, currentSpeed);
            jet.Accelerate();
            int currentSpeedAfterAcceleration = jet.GetSpeed();
            Assert.Equal(800, currentSpeedAfterAcceleration);
        }



    }
}
