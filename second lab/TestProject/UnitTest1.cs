namespace AirplaneNS.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void TestRefuelAndFly()
        {
            Airplane airplane = new Airplane(100, 1000.0, 200.0);
            ITanker tanker = new MockTanker(3000.0);

            UInt128 counter = 0;

            while (tanker.getFuel() >= 15)
            {
                Console.WriteLine($"--------------------���� -> {counter}--------------------");
                double fuelBefore = airplane.getFuel();
                double fuelRequested = airplane.getCapacity() - fuelBefore;

                if (tanker.getFuel() - fuelRequested >= 15)
                {
                    double fuelTankerGiven = airplane.Refuel(tanker);

                    Assert.That(tanker.getFuel(), Is.GreaterThanOrEqualTo(15.0));
                    Assert.That(airplane.getFuel() - fuelBefore, Is.EqualTo(fuelTankerGiven));

                    Console.WriteLine($"����� ���������: {fuelBefore} �\n���������: {fuelRequested} �\n������� � �������: {tanker.getFuel()} �\n������ ��������: {fuelTankerGiven} �");

                    double burned = airplane.Fly();
                    Assert.That(burned, Is.InRange(500.0, 800.0));

                    Console.WriteLine($"������� � �������� ����� ������: {airplane.getFuel()} �\n������� ���������: {burned} �");

                    fuelBefore = airplane.getFuel();
                    fuelRequested = airplane.getCapacity() - fuelBefore;

                    ++counter; 
                }
                else
                {
                    Console.WriteLine("� ������� ������������ ������� ��� �������� ��������.");
                    break;
                }
            }
        }
    }
}