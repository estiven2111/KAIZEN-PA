using KAIZEN_PA.Services;
using KAIZEN_PA.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KAIZEN_PA
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Errores();
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
