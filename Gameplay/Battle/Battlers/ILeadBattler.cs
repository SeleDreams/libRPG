using System;

namespace libRPG.Battle
{
    public interface ILeadBattler : IBattler
    {

        //event Action<int> OnHit;
        void OnReceiveDamages(int damages);
        Stat Health { get; set; }
    }
}
