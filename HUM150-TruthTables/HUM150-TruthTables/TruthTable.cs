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

        public void CreateTable(int count)
        {
            // Create the parent FlowDocument...
            flowDoc = new FlowDocument();

            // Create the Table...
            table1 = new Table();
            table1.BringIntoView();
            // ...and add it to the FlowDocument Blocks collection.
            flowDoc.Blocks.Add(table1);

            // Set some global formatting properties for the table.
            table1.CellSpacing = 10;
            table1.Background = Brushes.White;
            // Create 6 columns and add them to the table's Columns collection. 
            int numberOfColumns = 6;
            for (int x = 0; x < numberOfColumns; x++)
            {
                table1.Columns.Add(new TableColumn());

                // Set alternating background colors for the middle colums. 
                if (x % 2 == 0)
                    table1.Columns[x].Background = Brushes.Beige;
                else
                    table1.Columns[x].Background = Brushes.LightSteelBlue;
            }
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
