namespace CarManufacturer
{
    public class Engine
    {
        private int hoursePower;
        private double cubicCapacity;

        public Engine(int hoursePower, double cubicCapacity)
        {
            this.HoursePower = hoursePower;
            this.CubicCapacity = cubicCapacity;
        }
        public int HoursePower
        {
            get
            {
                return this.hoursePower;
            }
            set
            {
                this.hoursePower = value;
            }
        }
        public double CubicCapacity
        {
            get
            {
                return this.cubicCapacity;
            }
            set
            {
                this.cubicCapacity = value;
            }
        }
    }
}
