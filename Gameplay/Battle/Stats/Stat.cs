// Copyright - SeleDreams - 2019
namespace libRPG.Battle
{
    using System;
    public class Stat : IStat
    {
        public Stat(float value, float max = float.MaxValue, float min = 0)
        {
            Value = value;
            _maxValue = max;
            _minValue = min;
        }

        public float Value
        {
            get => _value;
            set
            {
                bool isLowerThanMin = value < _minValue;
                bool isHigherThanHighest = value > _maxValue;
                if (isLowerThanMin)
                {
                    _value = _minValue;
                }
                else if (isHigherThanHighest)
                {
                    _value = _maxValue;
                }
                else
                {
                    _value = value;
                }

            }
        }

        public float Max { get => _maxValue; }
        public float Min { get => _minValue; }
        private readonly float _maxValue;
        private readonly float _minValue;
        private float _value;
    }
}
