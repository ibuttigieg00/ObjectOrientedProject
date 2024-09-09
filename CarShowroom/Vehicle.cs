namespace CarShowroom
{
    public class Vehicle
    {
        private string brand;
        private string model;
        private string colour;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public Vehicle(string brand, string model, string colour)
        {
            this.brand = brand;
            this.model = model;
            this.colour = colour;
        }
    }
}
