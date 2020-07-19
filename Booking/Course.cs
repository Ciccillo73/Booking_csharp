namespace Booking
{
    public class Course
    {
        private string _name;
        private string _town;
        private int _starRating;

        public Course(string name, string town, int starRating)
        {
            _name = name;
            _town = town;
            _starRating = starRating;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Town
        {
            get => _town;
            set => _town = value;
        }

        public int StarRating
        {
            get => _starRating;
            set => _starRating = value;
        }
    }
}