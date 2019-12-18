// Copyright - SeleDreams - 2019
namespace libRPG.Party
{
    using libRPG.Battle;
    public interface IParty
    {
        IBattler GetMember(int id);
        IBattler[] GetMembers();
        void AddMember(IBattler battler);
        void RemoveMember(int id);
        int MembersCount { get; }
    }
}
