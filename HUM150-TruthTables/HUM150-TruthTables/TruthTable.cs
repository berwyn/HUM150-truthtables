using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUM150_TruthTables
{
    public class TruthTable
    {
        Proposition[,] Table { get; set; }

        public Proposition[,] CreateTable(List<Proposition> propositions)
        {
            foreach (var proposition in propositions)
            {
                
            }
            return Table;
        }
    }
}
