namespace AirplaneNS
{
    public class MockTanker : ITanker
    {
        public MockTanker(double initialFuel)
        {
            if (initialFuel < 15)
            {
                throw new InvalidOperationException("Недостаточно топлива в танкере.");
            }
            fuel = initialFuel;
        }

        public double getFuel() => fuel;

        public double Request(double request)
        {
            if (fuel <= 15)
            {
                throw new InvalidOperationException("Недостаточно топлива в танкере.");
            }

            double availableFuel = Math.Min(request, fuel - 15);

            fuel -= availableFuel;

            return availableFuel;
        }

        private double fuel;
    }
}