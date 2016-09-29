using Forums.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Forums.Tests.ModelTests
{
    public class PostTest
    {
        [Fact]
        public void GetTitleTest()
        {
            //Arrange
            var post = new Post();
            post.Title = "Where should I go to eat?";
            //Act
            var result = post.Title;
            //Assert
            Assert.Equal("Where should I go to eat?", result);
        }
    }
}
