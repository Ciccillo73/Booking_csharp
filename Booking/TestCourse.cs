using System.Security.Cryptography;
using Xunit;

namespace Booking
{
    public class TestCourse
    {
        private readonly Course _sut;

        public TestCourse()
        {
            _sut = new Course("Java", "Glasgow", 4);
            
        }

        [Fact]
        public void canHaveName()
        {
            Assert.Equal("Java", _sut.Name);
        }
    }
    
    
}