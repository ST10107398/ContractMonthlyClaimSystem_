using System.Security.Claims;

namespace ClaimServiceTests
{
    public class ClaimServiceTests
    {
        [Fact]
        public void SubmitClaim_ValidClaim_ShouldReturnTrue()
        {
            var claimService = new ClaimService();
            var claim = new Claim { HoursWorked = 8, HourlyRate = 100, Notes = "Test" };

            var result = claimService.SubmitClaim(claim);

            Assert.True(result);
        }
    }


}