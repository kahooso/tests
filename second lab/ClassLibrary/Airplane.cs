namespace AirplaneNS
{
    public class Airplane
    {
        public Airplane() { }

        public Airplane(int seats, double capacity, double fuel)
        {
            if (seats < 10 || seats > 200)
            {
                throw new ArgumentOutOfRangeException("Seats number out of range!");
            }
            if (capacity < 300 || capacity > 5000)
            {
                throw new ArgumentOutOfRangeException("Capacity out of range!");
            }
            this.seats = seats;
            this.capacity = capacity;
            this.fuel = fuel;
        }

        public double getFuel() => fuel;
        public double getCapacity() => capacity;
        public double getSeats() => seats;
        public double getPassengers() => passengers;
        public double getPilots() => pilots;
        public double getStewardesses() => stewardesses;

        public void Refuel(double fuel)
        {
            if (fuel < 0)
            {
                throw new ArgumentOutOfRangeException("Отрицательное значение.");
            }
            if ((this.fuel + fuel) > capacity)
            {
                this.fuel = capacity;
            }
            else this.fuel += fuel;
        }

        public double Fly()
        {
            double burned = new Random().Next(500, 801);
            if (burned > fuel)
            {
                throw new InvalidOperationException("Недостаточно топлива для полёта.");
            }
            fuel -= burned;
            return burned;
        }

        public double Refuel(ITanker tanker)
        {
            double requiredFuel = capacity - fuel;

            if (requiredFuel <= 0)
                return 0;

            double fuelFromTanker = tanker.Request(requiredFuel);

            fuel += fuelFromTanker;

            if (fuel > capacity)
            {
                fuel = capacity;
            }

            return fuelFromTanker;
        }

        private double capacity;
        private double fuel;

        private int seats;
        private int passengers;
        private int pilots;
        private int stewardesses;
    }
}