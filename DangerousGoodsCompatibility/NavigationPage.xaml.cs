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
    public partial class NavigationPage : TabbedPage
    {
        public NavigationPage()
        {
            InitializeComponent();

            ContentPage homePage = new HomePage
            {
                Title = "Home"
            };

            ContentPage mainPageSingleton = MainPage.MainPageSingleton;
            mainPageSingleton.Title = "Dangerous Goods";

            Children.Add(homePage);
            Children.Add(mainPageSingleton);
        }
    }
}