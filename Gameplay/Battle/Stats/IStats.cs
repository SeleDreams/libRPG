// Copyright - SeleDreams - 2019
namespace libRPG.Battle
{
    public interface IStats
    {
        IStat GetStat(int id);
        void SetStat(int id,IStat value);
        void Save();
    }
}
