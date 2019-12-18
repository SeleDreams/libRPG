// Copyright - SeleDreams - 2019
namespace libRPG.Battle
{
    using libRPG;
    public interface IBattler : INamed, IIdentifiable,ITyped
    {
        int DataID { get; set; }
    }
}
