using FluentAssertions;
using Moq;
using PremiumCalculator.Core.Interfaces;
using PremiumCalculator.Core.Models;
using PremiumCalculator.Infrastructure.Services;

public class PremiumServiceTests
{
    [Fact]
    public void CalculatePremium_ShouldReturnCorrectValue()
    {
        var repoMock = new Mock<IOccupationRepository>();

        repoMock.Setup(x => x.GetRatingFactor("Doctor"))
            .Returns(1.5);

        var service = new PremiumService(repoMock.Object);

        var model = new MemberModel
        {
            AgeNextBirthday = 30,
            DeathSumInsured = 100000,
            Occupation = "Doctor"
        };

        var result = service.CalculatePremium(model);

        result.Should().Be(54000);
    }
}