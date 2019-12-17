// Copyright - SeleDreams - 2019
namespace SeleDreams.libRPG
{
    /// <summary>
    /// Implementation of IBattler
    /// Base class of all kinds of battlers that will be used by the game.
    /// </summary>
    public class Battler : IBattler
    {
        public Battler(int id,string name = "", int type = 0)
        {
            Name = name;
            Type = type;
            _id = id;
        }

        public string Name { get; set; }

        public int Type { get; set; }

        protected int _id;
        public int ID { get => _id; set => _id = value; }

        public int DataID { get; set; }
    }
}
