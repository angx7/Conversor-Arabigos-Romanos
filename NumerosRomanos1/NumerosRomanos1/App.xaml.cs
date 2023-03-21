using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NumerosRomanos1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vistas.V_Principal());
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
