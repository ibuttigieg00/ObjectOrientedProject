using System.Drawing;
using System.Reflection;

namespace CarShowroom
{
    public class Boat : Vehicle
    {
        private string type;
        private float length;
        private int engineCount;
        private bool bIsEngineInboard;
        private bool bIsEngineOutboard;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public float Length
        {
            get { return length; }
            set { length = value; }
        }
        public int EngineCount
        {
            get { return engineCount; }
            set { engineCount = value; }
        }
        public bool IsEngineInboard
        {
            get { return bIsEngineInboard; }
            set { bIsEngineInboard = value; }
        }
        private bool IsEngineOutboard
        {
            get { return bIsEngineOutboard; }
            set { bIsEngineOutboard = value; }
        }
        public Boat (string type, float length, int engineCount, bool bIsEngineInboard, bool bIsEngineOutboard, string brand, string model, string colour) 
            : base (brand, model, colour)
        {
            this.type = type;
            this.length = length;
            this.engineCount = engineCount;
            this.bIsEngineInboard = bIsEngineInboard;
            this.bIsEngineOutboard = bIsEngineOutboard;
        }
    }
}
