using NUnit.Framework;
using FizzBuzzPlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundredDoors.Tests
{
    [TestFixture]
    public class FizzBuzzPlusTests
    {
        [Test]
        public void ShouldReturnANumberIfNotMultipleOf3Or5()
        {
            Assert.That(Program.FizzBuzzPlus(7), Is.EqualTo("7"));
        }

        [Test]
        public void ShouldReturnFizzForMultiplesOf3()
        {
            Assert.That(Program.FizzBuzzPlus(3), Is.EqualTo("...Fizz..."));
        }

        [Test]
        public void ShouldReturnBuzzForMultiplesOf5()
        {
            Assert.That(Program.FizzBuzzPlus(5), Is.EqualTo("...Buzz..."));
        }

        [Test]
        public void ShouldReturnFizzIfNumberContains3(
                    [Values(13,23,31,32,33,34,36,37,38,39,43,63,73,83,93)] int x)
        {
            Assert.That(Program.FizzBuzzPlus(x), Is.EqualTo("...Fizz..."));
        }

        [Test]
        public void ShouldReturnBuzzIfNumberContains5(
                    [Values (52,56,58,59)] int x)
        {
            Assert.That(Program.FizzBuzzPlus(x), Is.EqualTo("...Buzz..."));
        }

        [Test]
        public void ShouldReturnFizzBuzzIfNumberContains3Or5OrMultipleOf3OrMultipleOf5(
            [Values(35, 51, 53, 54, 57)] int x)
        {
            Assert.That(Program.FizzBuzzPlus(x), Is.EqualTo("FizzBuzz"));
        }
    }
}
