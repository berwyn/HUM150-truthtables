using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace HUM150_TruthTables
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly ObservableCollection<Proposition> _propositions;

        public MainWindow()
        {
            InitializeComponent();
            _propositions = new ObservableCollection<Proposition> {new Proposition()};
            PropositionsList.DataContext = _propositions;
            FirstPropList.DataContext = _propositions;
            SecondPropList.DataContext = _propositions;
        }

        private void AddPropButton_OnClick(object sender, RoutedEventArgs e)
        {
            _propositions.Add(new Proposition());
        }

        private void SaveResultButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CalculateButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
