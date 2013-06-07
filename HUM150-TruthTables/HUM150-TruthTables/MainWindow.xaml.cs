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
        private bool _result;

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
            var button = sender as Button;
            if (button != null)
            {
                var prop = button.DataContext as Proposition;
                if (prop != null)
                {
                    _propositions.Remove(prop);
                }
            }
        }

        private void SaveResultButton_OnClick(object sender, RoutedEventArgs e)
        {
            var op = String.Empty;
            switch (Sign.SelectedIndex)
            {
                case 0:
                    op = "and";
                    break;
                case 1:
                    op = "or";
                    break;
                case 2:
                    op = "implies";
                    break;
                case 3:
                    op = "is implied by";
                    break;
                case 4:
                    op = "is true if and only if";
                    break;
                case 5:
                    op = "is exclusively true vs";
                    break;
            }
            var def = String.Format("{0} {1} {2}", _propositions[FirstPropList.SelectedIndex].Definition, op,
                                    _propositions[SecondPropList.SelectedIndex].Definition);
            CalculateButton_OnClick(null, null);
            var prop = new Proposition
                {
                    Definition = def,
                    Value = _result
                };
            _propositions.Add(prop);
        }

        private void CalculateButton_OnClick(object sender, RoutedEventArgs e)
        {
            var firstProp = FirstPropList.SelectedIndex;
            var prop1 = _propositions[firstProp];

            var secondProp = SecondPropList.SelectedIndex;
            var prop2 = _propositions[secondProp];

            int sign = Sign.SelectedIndex;

            _result = false;
            switch (sign)
            {
                case 0:
                    _result = prop1.And(prop2);
                    break;

                    case 1:
                    _result = prop1.Or(prop2);
                    break;

                    case 2:
                    _result = prop1.Hook(prop2);
                    break;

                    case 3:
                    _result = prop2.Hook(prop1);
                    break;

                    case 4:
                    _result = prop1.Iff(prop2);
                    break;

                    case 5:
                    _result = prop1.Xor(prop2);
                    break;
            }

            ResultLabel.Content = _result;
        }
    }
}
