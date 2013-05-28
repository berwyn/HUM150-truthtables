using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HUM150_TruthTables
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly List<Proposition> _propositions = new List<Proposition>(5)
            {
                new Proposition()
                    {
                        Value = false,
                        Definition = ""
                    },
                    new Proposition()
                    {
                        Value = false,
                        Definition = ""
                    },
                    new Proposition()
                    {
                        Value = false,
                        Definition = ""
                    },
                    new Proposition()
                    {
                        Value = false,
                        Definition = ""
                    },
                    new Proposition()
                    {
                        Value = false,
                        Definition = ""
                    }
            };
        public List<Proposition> Propositions
        {
            get { return _propositions; }
        }

        public MainWindow()
        {
            InitializeComponent();
            this.PropositionsList.ItemsSource = Propositions;
        }
    }
}
