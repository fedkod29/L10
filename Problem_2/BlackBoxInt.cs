using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Problem_2
{
    internal class BlackBoxInt
    {
        private int _value = 0;

        private void Add(int value)
        {
            this._value += value;
        }

        private void Subtract(int subValue)
        {
            this._value -= subValue;
        }

        private void Divide(int divideValue)
        {
            this._value /= divideValue;
        }

        private void Multiply(int multiplyValue)
        {
            this._value *= multiplyValue;
        }

        private void RightShift(int shiftValue)
        {
            this._value >>= shiftValue;
        }

        private void LeftShift(int shiftValue)
        {
            this._value <<= shiftValue;
        }
    }
}
