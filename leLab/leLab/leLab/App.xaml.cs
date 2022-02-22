using leLab.Views.trainig;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace leLab
{
    public partial class App : Application
    {

        public App()
        {
           

            MainPage = new NavigationPage(new Page1());
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
