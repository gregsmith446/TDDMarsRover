using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace MarsTravelingRover
{
    [TestFixture]
    public class RoverTests
    {
        [Test]
        public void givenAllInputsReturnAnIntArray()
        {
            int[] location = { };
            char direction = 'e';
            int[] grid = { };
            string commands = "";

            int[] expected = new int[] { };
            int[] output = new MarsRoverMovementClass().RovingRover(location, direction, grid, commands);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void givenInputsWitNoCommandsReturnStartingLocation()
        {
            int[] location = {0, 0};
            char direction = 'e';
            int[] grid = {100, 100};
            string commands = "ff";

            int[] expected = new int[] {0, 2};
            int[] output = new MarsRoverMovementClass().RovingRover(location, direction, grid, commands);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void givenInputsWithCommandBackReturnNewLocation()
        {
            int[] location = { 0, 0 };
            char direction = 'e';
            int[] grid = { 100, 100 };
            string commands = "ffb";

            int[] expected = new int[] { 0, 1 };
            int[] output = new MarsRoverMovementClass().RovingRover(location, direction, grid, commands);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void givenInputsWithCommandRightReturnNewLocation()
        {
            int[] location = { 0, 0 };
            char direction = 'e';
            int[] grid = { 100, 100 };
            string commands = "ffrf";

            int[] expected = new int[] { 1, 2 };
            int[] output = new MarsRoverMovementClass().RovingRover(location, direction, grid, commands);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void givenInputsWithCommandLeftReturnNewLocation()
        {
            int[] location = { 50, 50 };
            char direction = 'e';
            int[] grid = { 100, 100 };
            string commands = "fflf";

            int[] expected = new int[] { 49, 52  };
            int[] output = new MarsRoverMovementClass().RovingRover(location, direction, grid, commands);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void givenMixedCommandsThatMakeASquareReturnToStartingLocationGoingRight()
        {
            int[] location = { 50, 50 };
            char direction = 'e';
            int[] grid = { 100, 100 };
            string commands = "rfrfrfrf";

            int[] expected = new int[] { 50, 50 };
            int[] output = new MarsRoverMovementClass().RovingRover(location, direction, grid, commands);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void givenMixedCommandsThatMakeASquareReturnToStartingLocationGoingLeft()
        {
            int[] location = { 50, 50 };
            char direction = 'e';
            int[] grid = { 100, 100 };
            string commands = "lflflflf";

            int[] expected = new int[] { 50, 50 };
            int[] output = new MarsRoverMovementClass().RovingRover(location, direction, grid, commands);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void givenInputsThatRequireWrappingOnXAxisReturnCorrectLocation()
        {
            int[] location = { 0, 0 };
            char direction = 'w';
            int[] grid = { 100, 100 };
            string commands = "f";

            int[] expected = new int[] { 0 , 100 };
            int[] output = new MarsRoverMovementClass().RovingRover(location, direction, grid, commands);

            Assert.AreEqual(expected, output);
        }

        [Test]
        public void givenInputsThatRequireWrappingOnYAxisReturnCorrectLocation()
        {
            int[] location = { 0, 0 };
            char direction = 'n';
            int[] grid = { 100, 100 };
            string commands = "f";

            int[] expected = new int[] { 100, 0 };
            int[] output = new MarsRoverMovementClass().RovingRover(location, direction, grid, commands);

            Assert.AreEqual(expected, output);
        }
    }
}
