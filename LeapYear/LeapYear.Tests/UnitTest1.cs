using System;
using Xunit;
using System.IO;

namespace LeapYear.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(200, false)]
        [InlineData(800, true)]
        [InlineData(16, true)]
        public void isLeapYear_returnsFalseOn200(int year, bool expected)
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Assert.Equal(Program.isLeapYear(year),expected);

        }
       


    }
}
