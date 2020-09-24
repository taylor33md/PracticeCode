using Fishing_Pond;
using Xunit;
using FluentAssertions;

namespace UnitTesting
{
    public class FishingPondUnitTests
    {
        [Fact]
        public void FishPond_PositiveOrZeroFishAmounts_RemainingFishAmountCorrect()
        {
            // Arrange
            var testFishPond = new Pond(100,10,2);

            // Act
            testFishPond.FishPond(100, 10, 2);

            // Assert
            testFishPond.NumFish.Should().Be(100);
        }
    }
}
