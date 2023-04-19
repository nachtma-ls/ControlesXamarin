using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlsDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new PresentationsViewsDemo();
            MainPage = new CommandsViewsDemo();
            //MainPage =new InputViewsDemo();
            //MainPage = new TextViewsDemo();
            //MainPage = new ActivityIndicatorsDemo();
            //MainPage = new CollectionsDemo(); 
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
