using NUnit.Framework;
using System;

namespace FizzBuzz.Test
{
    public class Tests
    {
        FizzBuzz systemUnderTest;

        [SetUp]
        public void Setup()
        {
            systemUnderTest = new FizzBuzz();
        }
        /*
        Print the numbers from 1 to 100. But for 
        multiples of three, print "Fizz” instead of the number and for 
        the multiples of five, print "Buzz". 
        For numbers which are multiples of both three and five, print "FizzBuzz". 
        */

        [Test]
        public void ShouldPrint1IfEntredNumberIs1()
        {
            var print = systemUnderTest.EvaluateNumbers(1);
            var expected = "1";

            Assert.AreEqual(expected, print);
        }
        [Test]
        public void ShouldPrint2IfEntredNumberIs2()
        {
            var print = systemUnderTest.EvaluateNumbers(2);
            var expected = "2";

            Assert.AreEqual(expected, print);
        }
        [Test]
        public void ShouldPrintFizzIfEntredNumberIs3()
        {
            var print = systemUnderTest.EvaluateNumbers(3);
            var expected = "Fizz";

            Assert.AreEqual(expected, print);
        }
        [Test]
        public void ShouldPrintFizzIfEntredNumberIs9()
        {
            var print = systemUnderTest.EvaluateNumbers(9);
            var expected = "Fizz";

            Assert.AreEqual(expected, print);
        }
        [Test]
        public void ShouldPrintBuzzIfEntredNumberIs5()
        {
            var print = systemUnderTest.EvaluateNumbers(5);
            var expected = "Buzz";

            Assert.AreEqual(expected, print);
        }
        [Test]
        public void ShouldPrintBuzzIfEntredNumberIs10()
        {
            var print = systemUnderTest.EvaluateNumbers(10);
            var expected = "Buzz";

            Assert.AreEqual(expected, print);
        }
        [Test]
        public void ShouldPrintFizzBuzzIfEntredNumberIs15()
        {
            var print = systemUnderTest.EvaluateNumbers(15);
            var expected = "FizzBuzz";

            Assert.AreEqual(expected, print);
        }
        [Test]
        public void ShouldPrint12FizzIfEntredNumberIsFrom1To3()
        {
            var print = systemUnderTest.EvaluateNumbers(1, 3);
            var expected = "12Fizz";

            Assert.AreEqual(expected, print);
        }
        [Test]
        public void ShouldThrowExceptionIfNonValidNumber()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => systemUnderTest.EvaluateNumbers(10, 7));
        }
        [Test]
        public void ShouldPrint12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzzIfEntredNumberIsFrom1To15()
        {
            var print = systemUnderTest.EvaluateNumbers(1, 15);
            var expected = "12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz";

            Assert.AreEqual(expected, print);
        }
    }
}