
namespace MilitaryElite.Contracs
{
    public interface IRepair
    {
        string PartName { get; }
        int HoursWork { get; }

        //void AddRepair(IRepair repair);
    }
}
