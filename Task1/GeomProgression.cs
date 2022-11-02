using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class GeomProgression : ISeries
    {
        int q;
        int startValue;
        int currentValue;
        public int Q
        {
            get => q;
            set => q = value;
        }
        public int GetNext()
        {
            currentValue *= Q;
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
