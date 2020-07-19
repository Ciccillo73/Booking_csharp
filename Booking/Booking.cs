using System.Collections.Generic;

namespace Booking
{
    public class Booking
    {
        private string _date;
        private List<Customer> _customers;
        
        public Booking(string date)
        {
            _date = date;
            _customers = new List<Customer>();
        }

        public string Date
        {
            get => _date;
            set => _date = value;
        }
        
        
    }
}