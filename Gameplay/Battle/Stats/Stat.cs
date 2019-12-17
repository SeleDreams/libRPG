// Copyright - SeleDreams - 2019
namespace SeleDreams.libRPG
{
    public class Stat : IStat
    {
        public Stat(float value,float max = float.MaxValue)
        {
            Value = value;
            _maxValue = max;
        }

        public float Value { get; set; }

        public float Max { get => _maxValue; }
        private readonly float _maxValue;
    }
}
