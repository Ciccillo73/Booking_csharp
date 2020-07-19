using Xunit;

namespace Booking
{
    public class TestBooking
    {
        private readonly Booking _sut;

        public TestBooking()
        {
            _sut = new Booking("11/02/2020");
        }

        [Fact]
        public void customerListStartsEmpty()
        {
            Assert.Equal(0, _sut.getCustomerList());
        }
    }
}