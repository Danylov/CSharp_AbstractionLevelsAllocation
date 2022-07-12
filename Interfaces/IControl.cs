namespace AbstractionLevelsAllocation.Interfaces
{
    public interface IControl
    {
        void SpeedUp(float deltaSpeed);
        void SpeedDown(float deltaSpeed);
        void turnLeft(float deltaAngle);
        void turnRight(float deltaAngle);
    }
}