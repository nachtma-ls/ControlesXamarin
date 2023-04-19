using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlsDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextViewsDemo : ContentPage
    {
        public TextViewsDemo()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txtName_Completed(object sender, EventArgs e)
        {
            Debug.WriteLine(txtName.Text);
        }
    }
}