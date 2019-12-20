using System;
using FluentAssertions;
using Xunit;

namespace CSGOStats.Infrastructure.Validation.Tests
{
    public class InstanceTests
    {
        [Fact]
        public void NotNullForClassesTest()
        {
            {
                var defaultClass = GetDefaultClassInstance();
                Record.Exception(() => defaultClass.NotNull(nameof(defaultClass))).Should().BeNull();
            }

            {
                var nullClass = GetNullClassInstance();
                const string parameterName = nameof(nullClass);
                var exception = Record.Exception(() => nullClass.NotNull(parameterName));
                exception.Should().BeOfType<ArgumentNullException>().Which.ParamName.Should().Be(parameterName);
            }
        }

        [Fact]
        public void NotNullForStructuresTest()
        {
            {
                var defaultStructure = GetDefaultStructInstance();
                Record.Exception(() => defaultStructure.NotNull(nameof(defaultStructure))).Should().BeNull();
            }

            {
                var nullStructure = GetNullStructInstance();
                const string parameterName = nameof(nullStructure);
                var exception = Record.Exception(() => nullStructure.NotNull(parameterName));
                exception.Should().BeOfType<ArgumentNullException>().Which.ParamName.Should().Be(parameterName);
            }
        }

        private static TestClass GetDefaultClassInstance() => new TestClass();

        private static TestClass GetNullClassInstance() => null;

        private static TestStruct? GetDefaultStructInstance() => new TestStruct();

        private static TestStruct? GetNullStructInstance() => null;
    }

    public interface ITestInterface
    {
    }

    public class TestClass : ITestInterface
    {
    }

    public struct TestStruct : ITestInterface
    {
    }
}