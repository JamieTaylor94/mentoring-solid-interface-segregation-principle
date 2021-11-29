using NUnit.Framework;

namespace Mentoring.Solid.InterfaceSegregation.Principle
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void PassengerAirlineService()
        {
            var service = new PassengerAirlinesService(new PassengerAirlineRequest
            {
                Capacity = 200,
                HasMeal = true,
                HasWings = true
            });

            var airCraft = service.GetAirCraft();

            Assert.That(airCraft.HasOnboardMeal);
            Assert.That(airCraft.HasWings);
            Assert.That(airCraft.Capacity == 200);
        }

        [Test]
        public void ArmyAirlineService()
        {
            
        }
    }

    public class PassengerAirlineRequest
    {
        public bool HasMeal { get; set; }
        public bool HasWings { get; set; }
        public int Capacity { get; set; }
    }
}
