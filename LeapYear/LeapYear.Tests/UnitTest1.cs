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
        public void isLeapYear_returnTest(int year, bool expected)
        {
            Assert.Equal(Program.isLeapYear(year),expected);
        }

        [Theory]
        [InlineData("Test",0)]
        [InlineData("-100",-100)]
        [InlineData("32412",32412)]
        public void convertInputToInt_returnTest(string input, int convertedInt)
        {
            Assert.Equal(Program.convertInputToInt(input),convertedInt);
        }

        [Fact]
        public void Main_returnsYayWhenInputIsLeapYer()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[]{"2000"});

            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("yay",output);
        }

        [Fact]
        public void Main_returnsNayWhenInputIsNotLeapYear()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[]{"3323"});

            var output = writer.GetStringBuilder().ToString().Trim();

            Assert.Equal("nay",output);
        }
        
        


       


    }
}
