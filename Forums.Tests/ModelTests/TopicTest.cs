using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Forums.Models;

namespace Forums.Tests.Forums.Tests
{
    public class TopicTest
    {
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var topic = new Topic();
            topic.Name = "Movies";
            //Act
            var result = topic.Name;
            //Assert
            Assert.Equal("Movies", result);
        }
    }
}
