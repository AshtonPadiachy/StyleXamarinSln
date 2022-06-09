using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StyleXamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            NavigationPage navPage = new NavigationPage(new MainPage());

            navPage.BarBackgroundColor = Color.Black;
            

            MainPage = navPage;
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
