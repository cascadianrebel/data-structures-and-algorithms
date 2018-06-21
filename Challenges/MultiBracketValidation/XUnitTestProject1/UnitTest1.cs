
using MultiBracketValidation;
using System;
using System.Collections.Generic;
using Xunit;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{}{Code}[Fellows](())")]
        public void CanSeparateBrackets(string input)
        {
            Program.SeparateBrackets(input);
            string SquareStrings = string.Join("", Program.SquareList.ToArray());

            string CurlyStrings = string.Join("", Program.CurlyList.ToArray());

            string RoundStrings = string.Join("", Program.RoundList.ToArray());

            Assert.Equal("[]", SquareStrings);
            Assert.Equal("{}{}", CurlyStrings);
            Assert.Equal("(())", RoundStrings);
        }

        [Theory]
        [InlineData("{}{Code}[Fellows](())", true)]
        public void TestForBracketListBalance(string input, bool expectedReturn)
        {
            Program.SameReversed(input);

            Assert.True(expectedReturn);
        }
    }
}
