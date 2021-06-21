using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DangerousGoodsCompatibility
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = DangerousGoodsCompatibility.MainPage.MainPageSingleton;
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
