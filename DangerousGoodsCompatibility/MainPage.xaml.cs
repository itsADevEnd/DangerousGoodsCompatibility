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
        //public float DiamondSelector1DangerousGoodNumber { get; set; }
        //public float DiamondSelector2DangerousGoodNumber { get; set; }
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
                    MainPageSingleton.UpdateSelectedDangerousGood(1, StringModification.ConvertStringToFileName(selectedDangerousGoodImageSource.ToString()));
                    MainPageSingleton.DiamondSelector1.Source = selectedDangerousGoodImageSource;
                    //MainPageSingleton.ConvertDangerousGoodToNumber(MainPageSingleton.DiamondSelector1DangerousGood);
                    break;
                case DiamondSelector.DiamondSelector2:
                    MainPageSingleton.UpdateSelectedDangerousGood(2, StringModification.ConvertStringToFileName(selectedDangerousGoodImageSource.ToString()));
                    MainPageSingleton.DiamondSelector2.Source = selectedDangerousGoodImageSource;
                    //MainPageSingleton.ConvertDangerousGoodToNumber(MainPageSingleton.DiamondSelector2DangerousGood);
                    break;
            }
        }

        //private float ConvertDangerousGoodToNumber(DangerousGood dangerousGood)
        //{
        //    switch (dangerousGood)
        //    {
        //        case DangerousGood.Corrosive:
        //            return 8;
        //        case DangerousGood.DangerousWhenWet:
        //            return 4.3F;
        //        case DangerousGood.Explosives:
        //            return 1;
        //        case DangerousGood.FlammableGas:
        //            return 2.1F;
        //        case DangerousGood.FlammableLiquid:
        //            return 3;
        //        case DangerousGood.MiscellaneousDangerousGoods:
        //            return 9;
        //        case DangerousGood.NonFlammableNonToxicGas:
        //            return 2.2F;
        //        case DangerousGood.OrganicPeroxide:
        //            return 5.2F;
        //        case DangerousGood.OxidizingSubstances:
        //            return 5.1F;
        //        case DangerousGood.SpontaneouslyCombustible:
        //            return 4.2F;
        //        case DangerousGood.Toxic:
        //            return 2.3F;
        //        case DangerousGood.ToxicGas:
        //            return 2.3F;
        //        default:
        //            return 0;
        //    }
        //}

        private void UpdateSelectedDangerousGood(int diamondNumber, string selectedDangerousGoodImageSourceText)
        {
            switch (selectedDangerousGoodImageSourceText)
            {
                case "Corrosive.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.Corrosive;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.Corrosive;
                            break;
                        default:
                            break;
                    }
                    break;
                case "DangerousWhenWet.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.DangerousWhenWet;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.DangerousWhenWet;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Explosives.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.Explosives;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.Explosives;
                            break;
                        default:
                            break;
                    }
                    break;
                case "FlammableGas.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.FlammableGas;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.FlammableGas;
                            break;
                        default:
                            break;
                    }
                    break;
                case "FlammableLiquid.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.FlammableLiquid;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.FlammableLiquid;
                            break;
                        default:
                            break;
                    }
                    break;
                case "MiscellaneousDangerousGoods.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.MiscellaneousDangerousGoods;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.MiscellaneousDangerousGoods;
                            break;
                        default:
                            break;
                    }
                    break;
                case "NonFlammableNonToxicGas.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.NonFlammableNonToxicGas;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.NonFlammableNonToxicGas;
                            break;
                        default:
                            break;
                    }
                    break;
                case "OrganicPeroxide.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.OrganicPeroxide;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.OrganicPeroxide;
                            break;
                        default:
                            break;
                    }
                    break;
                case "OxidizingSubstances.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.OxidizingSubstances;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.OxidizingSubstances;
                            break;
                        default:
                            break;
                    }
                    break;
                case "SpontaneouslyCombustible.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.SpontaneouslyCombustible;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.SpontaneouslyCombustible;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Toxic.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.Toxic;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.Toxic;
                            break;
                        default:
                            break;
                    }
                    break;
                case "ToxicGas.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.ToxicGas;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.ToxicGas;
                            break;
                        default:
                            break;
                    }
                    break;
            }
        }

        public enum DiamondSelector
        {
            DiamondSelector1,
            DiamondSelector2
        }

        /* Key
         * 
         * Note: This may need updating. Yet to verify all symbols are accurate
         * Question mark (?) denotes symbols have not yet been found
         * 
         * Explosives = 1
         * FlammableGas = 2.1
         * NonFlammableNonToxicGas = 2.2
         * ToxicGas = 2.3
         * FlammableLiquid = 3
         * FlammableSolid = ?
         * SpontaneouslyCombustible = 4.2
         * DangerousWhenWet = 4.3
         * OxidizingSubstances = 5.1
         * OrganicPeroxide = ?
         * Toxic = 6.1
         * Infectious = ?
         * RadioactiveMaterials = ?
         * Corrosives = 8
         * MiscellaneousDangerousGoods = 9
         */
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
                string source = StringModification.ConvertStringToFileNameWithoutExtension((sender as ImageButton).Source.ToString());
                string source2 = MainPageSingleton.DiamondSelector1DangerousGood.ToString();

                if (StringModification.ConvertStringToFileNameWithoutExtension((sender as ImageButton).Source.ToString()) == MainPageSingleton.DiamondSelector1DangerousGood.ToString())
                {
                    ValidateCompatibility();
                }
            }
        }

        private void DiamondSelector2_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Source")
            {
                string source = StringModification.ConvertStringToFileNameWithoutExtension((sender as ImageButton).Source.ToString());
                string source2 = MainPageSingleton.DiamondSelector2DangerousGood.ToString();

                if (StringModification.ConvertStringToFileNameWithoutExtension((sender as ImageButton).Source.ToString()) == MainPageSingleton.DiamondSelector2DangerousGood.ToString())
                {
                    ValidateCompatibility();
                }
            }
        }

        /* Explosives = 1
         * FlammableGas = 2.1
         * NonFlammableNonToxicGas = 2.2
         * ToxicGas = 2.3
         * FlammableLiquid = 3
         * FlammableSolid = ?
         * SpontaneouslyCombustible = 4.2
         * DangerousWhenWet = 4.3
         * OxidizingSubstances = 5.1
         * OrganicPeroxide = ?
         * Toxic = 6.1
         * Infectious = ?
         * RadioactiveMaterials = ?
         * Corrosives = 8
         * MiscellaneousDangerousGoods = 9
         */

        private void ValidateCompatibility()
        {
            if (MainPageSingleton.DiamondSelector1DangerousGood != DangerousGood.EmptyDiamond && MainPageSingleton.DiamondSelector2DangerousGood != DangerousGood.EmptyDiamond)
            {
                DangerousGood[] dangerousGoods = new DangerousGood[2];
                dangerousGoods[0] = DiamondSelector1DangerousGood;
                dangerousGoods[1] = DiamondSelector2DangerousGood;

                // Block of conditional statements where both selected Dangerous Goods are the same
                if (dangerousGoods[0] == DangerousGood.Explosives && dangerousGoods[1] == DangerousGood.Explosives)
                {
                    MainPageSingleton.CompatibilityOverview.Text = CheckForExceptions;
                }
                else if ((dangerousGoods[0] == DangerousGood.FlammableGas && dangerousGoods[1] == DangerousGood.FlammableGas) || (dangerousGoods[0] == DangerousGood.NonFlammableNonToxicGas && dangerousGoods[1] == DangerousGood.NonFlammableNonToxicGas) || (dangerousGoods[0] == DangerousGood.ToxicGas && dangerousGoods[1] == DangerousGood.ToxicGas) || (dangerousGoods[0] == DangerousGood.FlammableLiquid && dangerousGoods[1] == DangerousGood.FlammableLiquid) || (dangerousGoods[0] == DangerousGood.SpontaneouslyCombustible && dangerousGoods[1] == DangerousGood.SpontaneouslyCombustible) || (dangerousGoods[0] == DangerousGood.DangerousWhenWet && dangerousGoods[1] == DangerousGood.DangerousWhenWet) || (dangerousGoods[0] == DangerousGood.OxidizingSubstances && dangerousGoods[1] == DangerousGood.OxidizingSubstances) || (dangerousGoods[0] == DangerousGood.Toxic && dangerousGoods[1] == DangerousGood.Toxic) || (dangerousGoods[0] == DangerousGood.MiscellaneousDangerousGoods && dangerousGoods[1] == DangerousGood.MiscellaneousDangerousGoods))
                {
                    MainPageSingleton.CompatibilityOverview.Text = Compatible;
                }
                // Incompatible Dangerous Goods (1)
                // Note: This conditional statement is missing several Dangerous Good checks as the images for them do not yet exist in this project
                else if
                    ((dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.FlammableGas)) || (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.FlammableLiquid)) || (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible)) || (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.DangerousWhenWet)) || (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.OxidizingSubstances)) || (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.Corrosive)) || (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible)) || (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.OxidizingSubstances)) || (dangerousGoods.Contains(DangerousGood.ToxicGas) && dangerousGoods.Contains(DangerousGood.FlammableLiquid)) || (dangerousGoods.Contains(DangerousGood.ToxicGas) && dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible)))
                {
                    MainPageSingleton.CompatibilityOverview.Text = Incompatible;
                }
                // StrongCaution Dangerous Goods (2)
                else if (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.FlammableGas))
                {
                    MainPageSingleton.CompatibilityOverview.Text = Incompatible;
                }
                // Separate Dangerous Goods (3)
                else if
                    ((dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible)))
                {
                    MainPageSingleton.CompatibilityOverview.Text = Separate;
                }
                // SeparateOrAdjacent Dangerous Goods (4)
                else if
                    ((dangerousGoods.Contains(DangerousGood.FlammableLiquid) && dangerousGoods.Contains(DangerousGood.DangerousWhenWet)) || (dangerousGoods.Contains(DangerousGood.DangerousWhenWet) && dangerousGoods.Contains(DangerousGood.Corrosive)) || (dangerousGoods.Contains(DangerousGood.OxidizingSubstances) && dangerousGoods.Contains(DangerousGood.Toxic)))
                {
                    MainPageSingleton.CompatibilityOverview.Text = SeparateOrAdjacent;
                }
                // Compatible (5)
                else if
                    ((dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas)) || (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.ToxicGas)) || (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.DangerousWhenWet)) || (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.Corrosive)) || (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) || (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.ToxicGas)) || (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.FlammableLiquid)) || (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.DangerousWhenWet)) || (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.OxidizingSubstances)) || (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.Toxic)) || (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.Corrosive)) || (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) || (dangerousGoods.Contains(DangerousGood.Toxic) && dangerousGoods.Contains(DangerousGood.DangerousWhenWet)) || (dangerousGoods.Contains(DangerousGood.ToxicGas) && dangerousGoods.Contains(DangerousGood.Toxic)) || (dangerousGoods.Contains(DangerousGood.Toxic) && dangerousGoods.Contains(DangerousGood.Corrosive)) || (dangerousGoods.Contains(DangerousGood.Toxic) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) || (dangerousGoods.Contains(DangerousGood.FlammableLiquid) && dangerousGoods.Contains(DangerousGood.Toxic)) || (dangerousGoods.Contains(DangerousGood.FlammableLiquid) && dangerousGoods.Contains(DangerousGood.Corrosive)) || (dangerousGoods.Contains(DangerousGood.FlammableLiquid) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) || (dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible) && dangerousGoods.Contains(DangerousGood.DangerousWhenWet)) || (dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible) && dangerousGoods.Contains(DangerousGood.Toxic)) || (dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible) && dangerousGoods.Contains(DangerousGood.Corrosive)) || (dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible) && dangerousGoods.Contains(DangerousGood.Corrosive)) || (dangerousGoods.Contains(DangerousGood.DangerousWhenWet) && dangerousGoods.Contains(DangerousGood.Toxic)) || (dangerousGoods.Contains(DangerousGood.DangerousWhenWet) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) || (dangerousGoods.Contains(DangerousGood.Toxic) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) || (dangerousGoods.Contains(DangerousGood.Corrosive) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)))
                {
                    MainPageSingleton.CompatibilityOverview.Text = Compatible;
                }
                // CheckDocuments (6)
                // CheckForExceptions (7)
            }
        }
    }
}
