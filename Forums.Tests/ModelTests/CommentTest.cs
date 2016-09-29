using Forums.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Forums.Tests.ModelTests
{
    public class CommentTest
    {
        [Fact]
        public void GetTextTest()
        {
            //Arrange
            var comment = new Comment();
            comment.Text = "I don't know";
            //Act
            var result = comment.Text;
            //Assert
            Assert.Equal("I don't know", result);
        }
    }
}
