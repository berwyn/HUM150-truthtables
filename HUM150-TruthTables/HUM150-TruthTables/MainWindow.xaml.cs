using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
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
            _propositions = new ObservableCollection<Proposition> { new Proposition() };
            PropositionsList.DataContext = _propositions;
            FirstPropList.DataContext = _propositions;
            SecondPropList.DataContext = _propositions;

        }

        private void AddPropButton_OnClick(object sender, RoutedEventArgs e)
        {
            _propositions.Add(new Proposition());
        }

        private void DeletePropButton_OnClick(object sender, RoutedEventArgs e)
        {
            var propCount = _propositions.Count();
            if (propCount > 0)
                _propositions.RemoveAt(propCount - 1);
        }

        private void SaveResultButton_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CalculateButton_OnClick(object sender, RoutedEventArgs e)
        {
            var firstProp = FirstPropList.SelectedIndex;
            var prop1 = _propositions[firstProp];

            var secondProp = SecondPropList.SelectedIndex;
            var prop2 = _propositions[secondProp];

            int sign = Sign.SelectedIndex;

            var result = false;
            switch (sign)
            {
                case 0:
                    result = prop1.And(prop2);
                    break;

                    case 1:
                    result = prop1.Or(prop2);
                    break;

                    case 2:
                    result = prop1.Hook(prop2);
                    break;

                    case 3:
                    result = prop2.Hook(prop1);
                    break;

                    case 4:
                    result = prop1.Hook(prop2);
                    break;

                    case 5:
                    result = prop1.Hook(prop2);
                    break;
            }

            ResultLabel.Content = result;
        }
    }
}
