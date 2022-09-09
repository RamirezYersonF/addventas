using appventas.Services;
using appventas.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appventas
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new iniciarsesion();
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
