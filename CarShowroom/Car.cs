namespace CarShowroom
{
    public class Car : Vehicle
    {
        private float horsePower;
        private double engineDisplacement;

        public float HorsePower
        {
            get { return horsePower; }
            set { horsePower = value; }
        }
        public double EngineDisplacement
        {
            get { return engineDisplacement; }
            set { engineDisplacement = value; }
        }
        public Car(float horsePower, double engineDisplacement, string brand, string model, string colour) : base(brand, model, colour)
        {
            this.horsePower = horsePower;
            this.engineDisplacement = engineDisplacement;
        }
    }
}
