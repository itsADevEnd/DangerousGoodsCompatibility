using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace DangerousGoodsCompatibility
{
    public partial class MainPage : ContentPage
    {
        public static MainPage MainPageSingleton { get; set; } = new MainPage();
        public DangerousGood DiamondSelector1DangerousGood { get; set; } = DangerousGood.EmptyDiamond;
        public DangerousGood DiamondSelector2DangerousGood { get; set; } = DangerousGood.EmptyDiamond;
        public string Incompatible { get; set; } = "Must not be loaded in the same vehicle or freight container";
        public string StrongCaution { get; set; } = "Can only be loaded in the same vehicle or freight container if all but one is in an approved segregation device and are NOT Packing Group I";
        public string Separate { get; set; } = "Separate by at least 3 meters or pack all but one in separate freight containers";
        public string SeparateOrAdjacent { get; set; } = "Separate as (S) above or can be loaded adjacent in the same vehicle or freight container if all but one is in an approved segregation device and are NOT Packing Group I";
        public string Compatible { get; set; } = "Load together with care, but do not load Acids with Cyanides or strong Acids with strong Alkalis";
        public string CheckDocuments { get; set; } = "Always Check documents for special requirements";
        public string CheckForExceptions { get; set; } = "Check DG Rule for exceptions before loading as per";

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called when the first Empty Diamond is clicked.
        /// </summary>
        /// <param name="sender">Empty Diamond object</param>
        /// <param name="e">Empty Diamond event</param>
        private void DiamondSelector1_Clicked(object sender, EventArgs e)
        {
            DangerousGoodsSelection dangerousGoodsSelection = new DangerousGoodsSelection(DiamondSelector.DiamondSelector1);
            Navigation.PushModalAsync(dangerousGoodsSelection);
        }

        /// <summary>
        /// Called when the first Second Diamond is clicked.
        /// </summary>
        /// <param name="sender">Empty Diamond object</param>
        /// <param name="e">Empty Diamond event</param>
        private void DiamondSelector2_Clicked(object sender, EventArgs e)
        {
            DangerousGoodsSelection dangerousGoodsSelection = new DangerousGoodsSelection(DiamondSelector.DiamondSelector2);
            Navigation.PushModalAsync(dangerousGoodsSelection);
        }

        public static void SetDiamondSelector(ImageSource selectedDangerousGoodImageSource, DiamondSelector selectedDiamond)
        {
            switch (selectedDiamond)
            {
                case DiamondSelector.DiamondSelector1:
                    MainPageSingleton.DiamondSelector1.Source = selectedDangerousGoodImageSource;
                    MainPageSingleton.UpdateSelectedDangerousGood(MainPageSingleton.DiamondSelector1DangerousGood, StringModification.ConvertStringToFileName(selectedDangerousGoodImageSource.ToString()));
                    break;
                case DiamondSelector.DiamondSelector2:
                    MainPageSingleton.DiamondSelector2.Source = selectedDangerousGoodImageSource;
                    MainPageSingleton.UpdateSelectedDangerousGood(MainPageSingleton.DiamondSelector2DangerousGood, StringModification.ConvertStringToFileName(selectedDangerousGoodImageSource.ToString()));
                    break;
            }
        }

        private void UpdateSelectedDangerousGood(DangerousGood diamondSelectorDangerousGood, string selectedDangerousGoodImageSourceText)
        {
            switch (selectedDangerousGoodImageSourceText)
            {
                case "Corrosive.png":
                    diamondSelectorDangerousGood = DangerousGood.Corrosive;
                    break;
                case "DangerousWhenWet.png":
                    diamondSelectorDangerousGood = DangerousGood.DangerousWhenWet;
                    break;
                case "Explosives.png":
                    diamondSelectorDangerousGood = DangerousGood.Explosives;
                    break;
                case "FlammableGas.png":
                    diamondSelectorDangerousGood = DangerousGood.FlammableGas;
                    break;
                case "FlammableLiquid.png":
                    diamondSelectorDangerousGood = DangerousGood.FlammableLiquid;
                    break;
                case "MiscellaneousDangerousGoods.png":
                    diamondSelectorDangerousGood = DangerousGood.MiscellaneousDangerousGoods;
                    break;
                case "NonFlammableNonToxicGas.png":
                    diamondSelectorDangerousGood = DangerousGood.NonFlammableNonToxicGas;
                    break;
                case "OrganicPeroxide.png":
                    diamondSelectorDangerousGood = DangerousGood.OrganicPeroxide;
                    break;
                case "OxidizingSubstances.png":
                    diamondSelectorDangerousGood = DangerousGood.OxidizingSubstances;
                    break;
                case "SpontaneouslyCombustible.png":
                    diamondSelectorDangerousGood = DangerousGood.SpontaneouslyCombustible;
                    break;
                case "Toxic.png":
                    diamondSelectorDangerousGood = DangerousGood.Toxic;
                    break;
                case "ToxicGas.png":
                    diamondSelectorDangerousGood = DangerousGood.ToxicGas;
                    break;
            }
        }

        public enum DiamondSelector
        {
            DiamondSelector1,
            DiamondSelector2
        }

        public enum DangerousGood
        {
            EmptyDiamond,
            Corrosive,
            DangerousWhenWet,
            Explosives,
            FlammableGas,
            FlammableLiquid,
            MiscellaneousDangerousGoods,
            NonFlammableNonToxicGas,
            OrganicPeroxide,
            OxidizingSubstances,
            SpontaneouslyCombustible,
            Toxic,
            ToxicGas
        }

        private void DiamondSelector1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Source")
            {
                
            }
        }
    }
}
