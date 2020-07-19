namespace Booking
{
    public class Booking
    {
        private string _date;

        public Booking(string date)
        {
            _date = date;
        }

        public string Date
        {
            get => _date;
            set => _date = value;
        }
    }
}