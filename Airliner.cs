namespace Mentoring.Solid.InterfaceSegregation.Principle
{
    public class Airliner : IAirCraft
    {
        public bool HasOnboardMeal { get; set; }
        public int Capacity { get; set; }

        public void Fly()
        {
        }

        public void Break()
        {
        }

        public void Accelerate()
        {
        }

        public void TurnLeft()
        {
        }

        public void TurnRight()
        {
        }

        public void StartBeverageService()
        {
        }
    }
}
