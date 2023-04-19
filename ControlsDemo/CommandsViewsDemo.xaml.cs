using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlsDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CommandsViewsDemo : ContentPage
    {
        public CommandsViewsDemo()
        {
            InitializeComponent();
        }
        private void btnTest_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("WELCOME", "Hello I'am Button", "ok");
        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            DisplayAlert("RadioButton",$"Changed: {e.Value}","Ok");
        }

        private void searchControl_SearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("Searching", $"Searching: {searchControl.Text}","Ok");
        }

        private void SwipeItem_Invoked(object sender, EventArgs e)
        {
            DisplayAlert("SwipeView", $"Element Tapped","ok");
        }
    }
}