using Forums.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Forums.Tests.ControllerTests
{
    public class TopicsControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            HomeController controller = new HomeController();
            //Act
            var result = controller.Index();
            //Assert
            Assert.IsType<ViewResult>(result);
      }
    }
}
