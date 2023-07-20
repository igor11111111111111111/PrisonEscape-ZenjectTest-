using System;

namespace Project
{
    public class Progress
    {
        public Action<float> OnValueChanged;
        public float CurValue
        {
            get
            {
                return _curValue;
            }
            set
            {
                _curValue = value;
                OnValueChanged?.Invoke(_curValue / _maxValue);
            }
        }
        private float _curValue;
        private float _maxValue;
        public float Income;

        public Progress(float maxValue, float income)
        {
            _maxValue = maxValue;
            Income = income;
        }

        public void Change()
        {
            CurValue += Income;
        }
    }
}

