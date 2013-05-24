using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUM150_TruthTables
{
    public class Proposition
    {
        public bool Value { get; set; }

        public Proposition(bool first)
        {
            Value = first;
        }

        public bool Equals(Proposition prop)
        {
            return Value == prop.Value;
        }

        public bool Hook(Proposition prop)
        {
            if (And(prop))
                return true;
            if (!Value && prop.Value)
                return true;
            return !Value && !prop.Value;
        }

        public bool And(Proposition prop)
        {
            return Value && prop.Value;
        }

        public bool Or(Proposition prop)
        {
            return Value || prop.Value;
        }

        public bool NotEqual(Proposition prop)
        {
            return Value != prop.Value;
        }
    }
}
