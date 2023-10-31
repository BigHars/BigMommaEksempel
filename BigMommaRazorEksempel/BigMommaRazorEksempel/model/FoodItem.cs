namespace BigMommaRazorEksempel.model
{
    public class FoodItem
    {
        //instance field
        private string _name;
        private string _description;
        private double _price;

        //properties
        public int Id { get; set; }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public FoodItem(string name, string description, double price)
        {
            _name = name;
            _description = description;
            _price = price;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Description: {Description}, Price: {Price}";
        }
    }
}
