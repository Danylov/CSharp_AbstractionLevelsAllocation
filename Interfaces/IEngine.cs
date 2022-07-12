using AbstractionLevelsAllocation.Enums;

namespace AbstractionLevelsAllocation.Interfaces
{
    public interface IEngine
    {
        EEngineType EngineType
        {
            get;
            set;
        }
        void TurnEngine();
    }
}