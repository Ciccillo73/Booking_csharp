namespace Booking
{
    public class Customer
    {
        private string _name;
        private string _town;
        private int _age;

        public Customer(string name, string town, int age)
        {
            _name = name;
            _town = town;
            _age = age;
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

        public int Age
        {
            get => _age;
            set => _age = value;
        }
    }
}