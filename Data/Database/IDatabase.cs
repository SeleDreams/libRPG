// Copyright - SeleDreams - 2019
namespace SeleDreams.libRPG
{
    public interface IDatabase
    {
        IDatabaseItem GetItem(int key);
        int ItemsCount { get; }
    }
}
