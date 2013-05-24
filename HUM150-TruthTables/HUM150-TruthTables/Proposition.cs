using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUM150_TruthTables
{
    public class Proposition
    {
        public bool FirstValue { get; set; }

        public Proposition(bool first)
        {
            FirstValue = first;
        }

        public bool Equals(bool secondValue)
        {
            return FirstValue == secondValue;
        }

        public bool Hook(bool secondValue)
        {
            if (And(secondValue))
                return true;
            if (!FirstValue && secondValue)
                return true;
            return !FirstValue && !secondValue;
        }

        public bool And(bool secondValue)
        {
            return FirstValue && secondValue;
        }

        public bool Or(bool secondValue)
        {
            return FirstValue || secondValue;
        }

        public bool NotEqual(bool secondValue)
        {
            return FirstValue != secondValue;
        }
    }
}
