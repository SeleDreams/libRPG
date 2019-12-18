// Copyright - SeleDreams - 2019
namespace SeleDreams.libRPG
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
            set => _value = (value < _minValue) ? _minValue : (value > _maxValue) ? _maxValue : value;
        }

        public float Max { get => _maxValue; }
        public float Min { get => _minValue; }
        private readonly float _maxValue;
        private readonly float _minValue;
        private float _value;
    }
}
