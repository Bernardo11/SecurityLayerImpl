using SecurityLayerImpl.Tests.Data.Config;
using Xunit;

namespace SecurityLayerImpl.Tests
{
    
    public class SecurityTest
    {
        [Fact]
        public void AssertSavePrice_ShouldReceive_InvalidKey()
        {
            // Arrange
            var securityService = ServiceFactory.BuildSecurityService();
            var isinKey = "asdf";

            //Act
            var serviceResponse = securityService.SaveISINPrice(isinKey);

            //Assert
            Assert.False(serviceResponse.Success);
            Assert.Equal("Invalid key", serviceResponse.Message);
        }

        [Fact]
        public void AssertSavePrice_ShouldReceive_SuccessMessage()
        {
            // Arrange
            var securityService = ServiceFactory.BuildSecurityService();
            var isinKey = "123456789101";

            //Act
            var serviceResponse = securityService.SaveISINPrice(isinKey);

            //Assert
            Assert.True(serviceResponse.Success);
            Assert.Equal("Price saved successfully", serviceResponse.Message);
        }

        [Fact]
        public void AssertSavePrice_ShouldReceive_NotFoundMessage()
        {
            // Arrange
            var securityService = ServiceFactory.BuildSecurityService();
            var isinKey = "1234567891012";

            //Act
            var serviceResponse = securityService.SaveISINPrice(isinKey);

            //Assert
            Assert.False(serviceResponse.Success);
            Assert.Equal("Price not found", serviceResponse.Message);
        }
    }
}