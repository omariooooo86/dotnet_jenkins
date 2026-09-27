using Microsoft.AspNetCore.Mvc;
using WebApp.Controllers;
using Index = WebApp.Controllers.Index;

namespace webapp_test;

public class IndexTest
{
    [Fact]
    public void Hello_ShouldReturnHelloJenkins()
    {
        // Arrange
        var controller = new Index();

        // Act
        var result = controller.Hello();

        // Assert
        var okResult = Assert.IsType<OkObjectResult>(result);

        Assert.Equal("Hello Jenkins!", okResult.Value);
    }
}