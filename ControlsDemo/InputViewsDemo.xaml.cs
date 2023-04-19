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
    public partial class InputViewsDemo : ContentPage
    {
        public InputViewsDemo()
        {
            InitializeComponent();
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblSlider.Text = slider.Value.ToString();
        }

        private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblSlider.Text = stepper.Value.ToString();
        }
    }
}