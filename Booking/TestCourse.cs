using System.Net;
using System.Runtime.CompilerServices;
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

        [Fact]
        public void canHaveTown()
        {
            Assert.Equal("Glasgow", _sut.Town);
        }

        [Fact]
        public void canHaveRating()
        {
            Assert.Equal(4, _sut.StarRating);
        }
    }
    
    
}