using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DangerousGoodsCompatibility
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void UseCompatibilityTool_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(MainPage.MainPageSingleton);
        }
    }
}