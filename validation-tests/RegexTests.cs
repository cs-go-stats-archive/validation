using System.Text.RegularExpressions;
using FluentAssertions;
using Xunit;

namespace CSGOStats.Extensions.Validation.Tests
{
    public class RegexTests
    {
        [Fact]
        public void SucceededRegexTest()
        {
            new Regex(@"\d+").Match("123").ForSucceeded().Success.Should().BeTrue();
        }

        [Fact]
        public void FailedRegexTest()
        {
            Record.Exception(() => new Regex(@"\d").Match("ABCD").ForSucceeded()).Should().BeOfType<ExpressionNotMatched>();
        }
    }
}