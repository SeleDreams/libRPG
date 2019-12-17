// Copyright - SeleDreams - 2019
namespace SeleDreams.libRPG
{
    public interface IStatsManager
    {
        IStat GetStat(int id);
        void SetStat(int id,IStat value);
        void Save();
    }
}
