// Copyright - SeleDreams - 2019
namespace libRPG.Battle
{

    /// <summary>
    /// Implementation of IBattler
    /// Base class of all kinds of battlers that will be used by the game.
    /// </summary>
    public class Battler : IBattler
    {
        public Battler(int id, string name = "", int type = 0)
        {
            Name = name;
            Type = type;
            ID = id;
        }

        public string Name { get; set; }

        public int Type { get; set; }

        public int DataID { get; set; }
        public int ID { get; set; }
    }
}
