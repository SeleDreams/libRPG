// Copyright - SeleDreams - 2019
namespace libRPG.Data
{
    public interface IDatabase
    {
        IDatabaseItem GetItem(int key);
        int ItemsCount { get; }
    }
}
