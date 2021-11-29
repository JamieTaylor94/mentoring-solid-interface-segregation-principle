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
            });

            var airCraft = service.GetAirCraft();

            Assert.That(airCraft.HasOnboardMeal);
            Assert.That(airCraft.Capacity == 200);
        }

        [Test]
        public void ArmyAirlineService()
        {
            
        }
    }
}
