namespace Mentoring.Solid.InterfaceSegregation.Principle
{
    public interface IAirCraft
    {
        bool HasOnboardMeal { get; set; }
        bool HasWings { get; set; }
        int Capacity { get; set; }

        void Fly();

        void Break();

        void Accelerate();

        void TurnLeft();
        void TurnRight();
        void StartBeverageService();
    }
}