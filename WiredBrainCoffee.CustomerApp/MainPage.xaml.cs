using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System;

namespace WiredBrainCoffee.CustomerApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void ButtonAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            var messageDialog = new MessageDialog("Customer added!");
            await messageDialog.ShowAsync();
        }

        private void ButtonDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonMove_Click(object sender, RoutedEventArgs e)
        {
            int column = (int)customerListGrid.GetValue(Grid.ColumnProperty);

            int newColumn = column == 0 ? 2 : 0;

            customerListGrid.SetValue(Grid.ColumnProperty, newColumn);

            moveSymbolIcon.Symbol = newColumn == 0 ? Symbol.Forward : Symbol.Back;
        }
    }
}
