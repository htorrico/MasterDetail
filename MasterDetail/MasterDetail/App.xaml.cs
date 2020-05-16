using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetail
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new MasterDetailPage1Detail();
            MainPage = new MasterDetailPage1();
            //MainPage = new MasterDetailPage1Master();
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
