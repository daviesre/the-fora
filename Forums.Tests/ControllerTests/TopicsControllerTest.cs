using Forums.Controllers;
using Forums.Models;
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

        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            ViewResult indexView = new HomeController().Index() as ViewResult;
    
            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Topic>>(result);
        }
    }
}
