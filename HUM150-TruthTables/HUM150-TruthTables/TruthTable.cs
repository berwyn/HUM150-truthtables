using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace HUM150_TruthTables
{
    public class TruthTable
    {
        private const int NumberOfOperations = 6;
        int[,] Table { get; set; }
        private FlowDocument flowDoc;
        private Table table1;
        private List<string> myChars = new List<string>{"q", "p", "r", "s", "t"}; 

        public void TableCreate(int count)
        {
            flowDoc = new FlowDocument();

            var t = new Table();
            for (var i = 0; i < 7; i++)
            {
                t.Columns.Add(new TableColumn());
            }

            var row = new TableRow {Background = Brushes.Blue, FontSize = 40, FontWeight = FontWeights.Bold};

            row.Cells.Add(new TableCell(new Paragraph(new Run("I span 7 columns"))));
            row.Cells[0].ColumnSpan = 6;


            var rg = new TableRowGroup();
            rg.Rows.Add(row);
            t.RowGroups.Add(rg);
            flowDoc.Blocks.Add(t);
        }

       public void FillWithOnes()
       {
           

       }
        public void RowsWithOneZero(int propositions)
        {
            
        }

        public void RowsWithTwoZeros(int propositions)
        {

        }

        public void RowsWithThreeZeros(int propositions)
        {

        }

        public void RowsWithFourZeros(int propositions)
        {

        }

        public void RowsWithFiveZeros(int propositions)
        {

        }

        public void RowsWithZeroZeros()
        {

        }

    }
}
