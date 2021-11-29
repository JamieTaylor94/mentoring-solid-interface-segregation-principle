namespace Mentoring.Solid.InterfaceSegregation.Principle
{
    public class PassengerAirlinesService
    {
        private readonly PassengerAirlineRequest _passengerAirlineRequest;

        public PassengerAirlinesService(PassengerAirlineRequest passengerAirlineRequest)
        {
            _passengerAirlineRequest = passengerAirlineRequest;
        }

        public Airliner GetAirCraft()
        {
            return new Airliner
            {
                Capacity = _passengerAirlineRequest.Capacity,
                HasOnboardMeal = _passengerAirlineRequest.HasMeal,
            };
        }
    }
}
