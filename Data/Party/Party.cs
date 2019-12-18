// Copyright - SeleDreams - 2019
namespace libRPG.Party
{
    using System.Collections.Generic;
    using libRPG.Exceptions;
    using libRPG.Battle;

    /// <summary>
    /// Party containing battlers.
    /// Use this if you want to use the entity component battle system, else, use the IParty interface to implement your own
    /// </summary>
    public class Party : IParty
    {
        public int MembersCount => members.Count;

        public Party()
        {
            members = new List<IBattler>();
        }

        public void AddMember(IBattler battler)
        {
            if (GlobalPartySettings.MAX_PARTY_MEMBERS > members.Count)
            {
                throw new FullPartyException("The party members are superior to the maximum amount");
            }
            members.Add(battler);
        }

        public void RemoveMember(int id)
        {
            members.RemoveAt(id);
        }

        public IBattler GetMember(int id)
        {
            return members[id];
        }

        public IBattler[] GetMembers()
        {
            return members.ToArray();
        }

        protected List<IBattler> members;
    }
}
