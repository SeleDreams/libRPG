// Copyright - SeleDreams - 2019
namespace libRPG.Battle
{
    using System;
    public class LeadBattler : Battler, ILeadBattler
    {
        public event Action<int> OnHit;

        public LeadBattler(int id, string name = "", int type = 0) : base(id, name, type)
        {
           Health = new Stat(200);
        }

        public void Hit(int damages){
            OnHit(damages);
        }
        
        public void OnReceiveDamages(int damages)
        {

        }
        public Stat Health { get; set; }
        public IBattler[] SubBattlers;

    }
}
