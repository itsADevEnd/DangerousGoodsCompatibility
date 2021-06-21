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
    public partial class DangerousGoodsSelection : ContentPage
    {
        private readonly MainPage.DiamondSelector _selectedDiamond;

        public DangerousGoodsSelection(MainPage.DiamondSelector diamondSelector)
        {
            InitializeComponent();
            _selectedDiamond = diamondSelector;
        }

        private void DangerousGoodsSelectionExitButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void DangerousGood_Clicked(object sender, EventArgs e)
        {
            MainPage.SetDiamondSelector((sender as ImageButton).Source, _selectedDiamond);
            Navigation.PopModalAsync();
        }
    }
}