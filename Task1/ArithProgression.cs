using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class ArithProgression : ISeries
    {
        int d;
        int startValue;
        int currentValue;
        public int D
        {
            get => d;
            set => d = value;
        }
        public int GetNext()
        {
            currentValue += D;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = startValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }
    }
}
