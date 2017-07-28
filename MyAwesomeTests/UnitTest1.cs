using System;
using MyAwesomeData.Models;
using Xunit;

namespace MyAwesomeTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("Hello","Hello");
        }
        [Fact]
        public void Test2()
        {
            Student student = new Student();
            student.FirstName = "Kevin";
            Assert.Equal("Kevin", student.FirstName);
        }
    }
}
