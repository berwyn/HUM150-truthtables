using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace HUM150_TruthTables
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly List<Proposition> _propositions = new List<Proposition>(5)
            {
                new Proposition
                    {
                        Value = false,
                        Definition = ""
                    },
                    new Proposition
                        {
                        Value = false,
                        Definition = ""
                    },
                    new Proposition
                    {
                        Value = false,
                        Definition = ""
                    },
                    new Proposition
                    {
                        Value = false,
                        Definition = ""
                    },
                    new Proposition
                    {
                        Value = false,
                        Definition = ""
                    }
            };

        private IEnumerable<Proposition> Propositions
        {
            get { return _propositions; }
        }

        private readonly TruthTable _table;

        public MainWindow()
        {
            InitializeComponent();
            PropositionsList.ItemsSource = Propositions;
            _table = new TruthTable();
        }

        private void UIElement_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            var count = Propositions.Count(t => !t.Definition.Equals(""));
            PropositionsCount.Text = count.ToString();
            _table.TableCreate(count);
            Console.WriteLine(count);
        }
    }
}
