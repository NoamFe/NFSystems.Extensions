using Shouldly;
using Xunit;

namespace NFSystems.Extensions.Tests
{
    public class EnumExtensionsTests
    {
        [Fact]
        public void Random_ShouldCreateEnum_Succesfully()
        {
            var _enum = EnumExtensions.Random<TestEnum>();
            _enum.ShouldNotBeNull();
        }
    }

    public enum TestEnum
    {
        Small,Medium,Large,XLarge
    }
}
