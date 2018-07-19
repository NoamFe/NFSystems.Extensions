using Shouldly;
using Xunit;

namespace NFSystems.Extensions.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void IsEmpty_ShouldReturnTrue_WhenStringIsEmpty()
        {
            "".IsEmpty().ShouldBe(true);
        }

        [Fact]
        public void IsEmpty_ShouldReturnFalse_WhenStringIsNotEmpty()
        {
            "1".IsEmpty().ShouldBe(false);
        }

        [Fact]
        public void IsNotEmpty_ShouldReturnFalse_WhenStringIsEmpty()
        {
            "".IsNotEmpty().ShouldBe(false);
        }

        [Fact]
        public void IsNotEmpty_ShouldReturnTrue_WhenStringIsNotEmpty()
        {
            "1".IsNotEmpty().ShouldBe(true);
        } 

        [Fact]
        public void SplitCamelCase_ShouldSplitStringToArray_Successully()
        {
            var input = "MyNameIsJohnSmithNiceToMeetYou";
            var response = input.SplitCamelCase();
            response.Length.ShouldBe(9);
            response[0].ShouldBe("My");
            response[1].ShouldBe("Name");
            response[2].ShouldBe("Is");
            response[3].ShouldBe("John");
            response[4].ShouldBe("Smith");
            response[5].ShouldBe("Nice");
            response[6].ShouldBe("To");
            response[7].ShouldBe("Meet");
            response[8].ShouldBe("You");
        }
    }
     
}
