using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using leLab.Views;

namespace leLab
{
    public partial class App : Application
    {

        public App()
        {
           

            MainPage = new MainPage();
            //point d'entrée
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
