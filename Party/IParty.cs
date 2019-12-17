// Copyright - SeleDreams - 2019
namespace SeleDreams.libRPG
{
    public interface IParty
    {
        IBattler GetMember(int id);
        IBattler[] GetMembers();
        void AddMember(IBattler battler);
        void RemoveMember(int id);
        int MembersCount { get; }
    }
}
