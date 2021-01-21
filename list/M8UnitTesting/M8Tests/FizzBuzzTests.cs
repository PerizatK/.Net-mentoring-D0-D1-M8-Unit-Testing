using System.Text;
using M8Project;
using NUnit.Framework;

namespace M8Tests
{
    public class FizzBuzzTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Print_ShouldReturnExpectedValue()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("12Fizz4BuzzFizz78FizzBuzz");
            FizzBuzz fizz = new FizzBuzz();
            var sbTest = fizz.Print(10);
            Assert.IsTrue(sb.ToString().Equals(sbTest.ToString()));
        }
    }
}