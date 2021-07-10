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
        public string SeparateOrAdjacent { get; set; } = "Separate by at least 3 meters or can be loaded adjacent in the same vehicle or freight container if all but one is in an approved segregation device and are NOT Packing Group I";
        public string Compatible { get; set; } = "Load together with care, but do not load Acids with Cyanides or strong Acids with strong Alkalis";
        public string CheckDocuments { get; set; } = "Always Check documents for special requirements";
        public string CheckForExceptions { get; set; } = "Check DG Rule for exceptions before loading";

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
                    break;
                case DiamondSelector.DiamondSelector2:
                    MainPageSingleton.UpdateSelectedDangerousGood(2, StringModification.ConvertStringToFileName(selectedDangerousGoodImageSource.ToString()));
                    MainPageSingleton.DiamondSelector2.Source = selectedDangerousGoodImageSource;
                    break;
            }
        }

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
                case "FlammableSolid.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.FlammableSolid;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.FlammableSolid;
                            break;
                        default:
                            break;
                    }
                    break;
                case "FoodstuffsOrFoodContainers.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.FoodstuffsOrFoodContainers;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.FoodstuffsOrFoodContainers;
                            break;
                        default:
                            break;
                    }
                    break;
                case "InfectiousSubstance.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.InfectiousSubstance;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.InfectiousSubstance;
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
                case "RadioactiveMaterials.png":
                    switch (diamondNumber)
                    {
                        case 1:
                            MainPageSingleton.DiamondSelector1DangerousGood = DangerousGood.RadioactiveMaterials;
                            break;
                        case 2:
                            MainPageSingleton.DiamondSelector2DangerousGood = DangerousGood.RadioactiveMaterials;
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

        public enum DangerousGood
        {
            EmptyDiamond,
            Corrosive,
            DangerousWhenWet,
            Explosives,
            FlammableGas,
            FlammableLiquid,
            FlammableSolid,
            FoodstuffsOrFoodContainers,
            InfectiousSubstance,
            MiscellaneousDangerousGoods,
            NonFlammableNonToxicGas,
            OrganicPeroxide,
            OxidizingSubstances,
            RadioactiveMaterials,
            SpontaneouslyCombustible,
            Toxic,
            ToxicGas
        }

        private void DiamondSelector1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Source")
            {
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
                if (StringModification.ConvertStringToFileNameWithoutExtension((sender as ImageButton).Source.ToString()) == MainPageSingleton.DiamondSelector2DangerousGood.ToString())
                {
                    ValidateCompatibility();
                }
            }
        }

        private void ValidateCompatibility()
        {
            if (MainPageSingleton.DiamondSelector1DangerousGood != DangerousGood.EmptyDiamond && MainPageSingleton.DiamondSelector2DangerousGood != DangerousGood.EmptyDiamond)
            {
                DangerousGood[] dangerousGoods = new DangerousGood[2];
                dangerousGoods[0] = DiamondSelector1DangerousGood;
                dangerousGoods[1] = DiamondSelector2DangerousGood;

                // Block of conditional statements where both selected Dangerous Goods are the same
                // CheckForExceptions for array that has the same Dangerous Good twice (6)
                if (dangerousGoods[0] == DangerousGood.Explosives && dangerousGoods[1] == DangerousGood.Explosives)
                {
                    MainPageSingleton.CompatibilityFrame.BackgroundColor = Color.LightGray;
                    MainPageSingleton.CompatibilityOverview.Text = CheckForExceptions;
                }
                // Compatible for array that has the same Dangerous Good twice (5)
                else if ((dangerousGoods[0] == DangerousGood.FlammableGas && dangerousGoods[1] == DangerousGood.FlammableGas) || 
                         (dangerousGoods[0] == DangerousGood.NonFlammableNonToxicGas && dangerousGoods[1] == DangerousGood.NonFlammableNonToxicGas) || 
                         (dangerousGoods[0] == DangerousGood.ToxicGas && dangerousGoods[1] == DangerousGood.ToxicGas) || 
                         (dangerousGoods[0] == DangerousGood.FlammableLiquid && dangerousGoods[1] == DangerousGood.FlammableLiquid) || 
                         (dangerousGoods[0] == DangerousGood.SpontaneouslyCombustible && dangerousGoods[1] == DangerousGood.SpontaneouslyCombustible) || 
                         (dangerousGoods[0] == DangerousGood.DangerousWhenWet && dangerousGoods[1] == DangerousGood.DangerousWhenWet) || 
                         (dangerousGoods[0] == DangerousGood.OxidizingSubstances && dangerousGoods[1] == DangerousGood.OxidizingSubstances) || 
                         (dangerousGoods[0] == DangerousGood.Toxic && dangerousGoods[1] == DangerousGood.Toxic) || 
                         (dangerousGoods[0] == DangerousGood.MiscellaneousDangerousGoods && dangerousGoods[1] == DangerousGood.MiscellaneousDangerousGoods) || 
                         (dangerousGoods[0] == DangerousGood.FlammableSolid && dangerousGoods[1] == DangerousGood.FlammableSolid) || 
                         (dangerousGoods[0] == DangerousGood.InfectiousSubstance && dangerousGoods[1] == DangerousGood.InfectiousSubstance) ||
                         (dangerousGoods[0] == DangerousGood.OrganicPeroxide && dangerousGoods[1] == DangerousGood.OrganicPeroxide) ||
                         (dangerousGoods[0] == DangerousGood.FoodstuffsOrFoodContainers && dangerousGoods[1] == DangerousGood.FoodstuffsOrFoodContainers))
                {
                    MainPageSingleton.CompatibilityFrame.BackgroundColor = Color.Green;
                    MainPageSingleton.CompatibilityOverview.Text = Compatible + Environment.NewLine + Environment.NewLine + CheckDocuments;
                }
                // Compatible + CheckForExceptions for array that has the same Dangerous Good twice (9)
                else if ((dangerousGoods[0] == DangerousGood.Corrosive && dangerousGoods[1] == DangerousGood.Corrosive) ||
                        (dangerousGoods[0] == DangerousGood.RadioactiveMaterials && dangerousGoods[1] == DangerousGood.RadioactiveMaterials))
                {
                    MainPageSingleton.CompatibilityFrame.BackgroundColor = Color.Green;
                    MainPageSingleton.CompatibilityOverview.Text = Compatible + Environment.NewLine + Environment.NewLine + CheckForExceptions;
                }
                // Incompatible Dangerous Goods (1)
                // Note: This conditional statement is missing several Dangerous Good checks as the images for them do not yet exist in this project
                else if ((dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.FlammableGas)) || 
                         (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.FlammableLiquid)) ||
                         (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.FlammableSolid)) ||
                         (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible)) || 
                         (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.DangerousWhenWet)) || 
                         (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.OxidizingSubstances)) || 
                         (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.Corrosive)) ||
                         (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.OrganicPeroxide)) ||
                         (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.InfectiousSubstance)) ||
                         (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.RadioactiveMaterials)) ||
                         (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.OxidizingSubstances)) ||
                         (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.OrganicPeroxide)) ||
                         (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.RadioactiveMaterials)) || 
                         (dangerousGoods.Contains(DangerousGood.ToxicGas) && dangerousGoods.Contains(DangerousGood.FlammableLiquid)) ||
                         (dangerousGoods.Contains(DangerousGood.RadioactiveMaterials) && dangerousGoods.Contains(DangerousGood.FlammableLiquid)) ||
                         (dangerousGoods.Contains(DangerousGood.ToxicGas) && dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible)) ||
                         (dangerousGoods.Contains(DangerousGood.ToxicGas) && dangerousGoods.Contains(DangerousGood.OrganicPeroxide)) ||
                         (dangerousGoods.Contains(DangerousGood.RadioactiveMaterials) && dangerousGoods.Contains(DangerousGood.OrganicPeroxide)) ||
                         (dangerousGoods.Contains(DangerousGood.FlammableSolid) && dangerousGoods.Contains(DangerousGood.RadioactiveMaterials)) || 
                         (dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible) && dangerousGoods.Contains(DangerousGood.RadioactiveMaterials)) ||
                         (dangerousGoods.Contains(DangerousGood.DangerousWhenWet) && dangerousGoods.Contains(DangerousGood.RadioactiveMaterials)) ||
                         (dangerousGoods.Contains(DangerousGood.Corrosive) && dangerousGoods.Contains(DangerousGood.RadioactiveMaterials)) ||
                         (dangerousGoods.Contains(DangerousGood.ToxicGas) && dangerousGoods.Contains(DangerousGood.FoodstuffsOrFoodContainers)))
                {
                    MainPageSingleton.CompatibilityFrame.BackgroundColor = Color.Red;
                    MainPageSingleton.CompatibilityOverview.Text = Incompatible;
                }
                // StrongCaution Dangerous Goods (2)
                else if ((dangerousGoods.Contains(DangerousGood.FlammableSolid) && dangerousGoods.Contains(DangerousGood.OrganicPeroxide)) || 
                         (dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible) && dangerousGoods.Contains(DangerousGood.OrganicPeroxide)) ||
                         (dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible) && dangerousGoods.Contains(DangerousGood.FlammableLiquid)) ||
                         (dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible) && dangerousGoods.Contains(DangerousGood.OxidizingSubstances)) ||
                         (dangerousGoods.Contains(DangerousGood.OxidizingSubstances) && dangerousGoods.Contains(DangerousGood.InfectiousSubstance)) || 
                         (dangerousGoods.Contains(DangerousGood.OrganicPeroxide) && dangerousGoods.Contains(DangerousGood.InfectiousSubstance)) ||
                         (dangerousGoods.Contains(DangerousGood.FlammableLiquid) && dangerousGoods.Contains(DangerousGood.OxidizingSubstances)) ||
                         (dangerousGoods.Contains(DangerousGood.FlammableLiquid) && dangerousGoods.Contains(DangerousGood.OrganicPeroxide)) ||
                         (dangerousGoods.Contains(DangerousGood.DangerousWhenWet) && dangerousGoods.Contains(DangerousGood.OrganicPeroxide)) ||
                         (dangerousGoods.Contains(DangerousGood.OxidizingSubstances) && dangerousGoods.Contains(DangerousGood.OrganicPeroxide)) ||
                         (dangerousGoods.Contains(DangerousGood.OxidizingSubstances) && dangerousGoods.Contains(DangerousGood.Corrosive)) ||
                         (dangerousGoods.Contains(DangerousGood.OrganicPeroxide) && dangerousGoods.Contains(DangerousGood.Corrosive)) ||
                         (dangerousGoods.Contains(DangerousGood.Toxic) && dangerousGoods.Contains(DangerousGood.FoodstuffsOrFoodContainers)) ||
                         (dangerousGoods.Contains(DangerousGood.InfectiousSubstance) && dangerousGoods.Contains(DangerousGood.FoodstuffsOrFoodContainers)) ||
                         (dangerousGoods.Contains(DangerousGood.Corrosive) && dangerousGoods.Contains(DangerousGood.FoodstuffsOrFoodContainers)) ||
                         (dangerousGoods.Contains(DangerousGood.OxidizingSubstances) && dangerousGoods.Contains(DangerousGood.DangerousWhenWet)))
                {
                    MainPageSingleton.CompatibilityFrame.BackgroundColor = Color.Orange;
                    MainPageSingleton.CompatibilityOverview.Text = StrongCaution;
                }
                // Separate Dangerous Goods (3)
                else if ((dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.FlammableSolid)) ||
                         (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.OrganicPeroxide)))
                {
                    MainPageSingleton.CompatibilityFrame.BackgroundColor = Color.Yellow;
                    MainPageSingleton.CompatibilityOverview.Text = Separate;
                }
                // SeparateOrAdjacent Dangerous Goods (4)
                else if ((dangerousGoods.Contains(DangerousGood.FlammableLiquid) && dangerousGoods.Contains(DangerousGood.DangerousWhenWet)) || 
                         (dangerousGoods.Contains(DangerousGood.DangerousWhenWet) && dangerousGoods.Contains(DangerousGood.Corrosive)) || 
                         (dangerousGoods.Contains(DangerousGood.OxidizingSubstances) && dangerousGoods.Contains(DangerousGood.Toxic)) ||
                         (dangerousGoods.Contains(DangerousGood.OrganicPeroxide) && dangerousGoods.Contains(DangerousGood.Toxic)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableSolid) && dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableSolid) && dangerousGoods.Contains(DangerousGood.OxidizingSubstances)))
                {
                    MainPageSingleton.CompatibilityFrame.BackgroundColor = Color.Yellow;
                    MainPageSingleton.CompatibilityOverview.Text = SeparateOrAdjacent;
                }
                // Compatible (5)
                else if ((dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.ToxicGas)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.DangerousWhenWet)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.Corrosive)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) ||
                         (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.Toxic)) ||
                         (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.InfectiousSubstance)) ||
                         (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.ToxicGas)) || 
                         (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.FlammableLiquid)) || 
                         (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.DangerousWhenWet)) || 
                         (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.OxidizingSubstances)) || 
                         (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.Toxic)) || 
                         (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.Corrosive)) || 
                         (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) ||
                         (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.FlammableSolid)) ||
                         (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.FlammableGas)) ||
                         (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.InfectiousSubstance)) ||
                         (dangerousGoods.Contains(DangerousGood.Toxic) && dangerousGoods.Contains(DangerousGood.DangerousWhenWet)) || 
                         (dangerousGoods.Contains(DangerousGood.ToxicGas) && dangerousGoods.Contains(DangerousGood.Toxic)) ||
                         (dangerousGoods.Contains(DangerousGood.ToxicGas) && dangerousGoods.Contains(DangerousGood.DangerousWhenWet)) ||
                         (dangerousGoods.Contains(DangerousGood.ToxicGas) && dangerousGoods.Contains(DangerousGood.OxidizingSubstances)) ||
                         (dangerousGoods.Contains(DangerousGood.ToxicGas) && dangerousGoods.Contains(DangerousGood.InfectiousSubstance)) ||
                         (dangerousGoods.Contains(DangerousGood.ToxicGas) && dangerousGoods.Contains(DangerousGood.Corrosive)) ||
                         (dangerousGoods.Contains(DangerousGood.ToxicGas) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) ||
                         (dangerousGoods.Contains(DangerousGood.Toxic) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableLiquid) && dangerousGoods.Contains(DangerousGood.Toxic)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableLiquid) && dangerousGoods.Contains(DangerousGood.Corrosive)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableLiquid) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) ||
                         (dangerousGoods.Contains(DangerousGood.FlammableLiquid) && dangerousGoods.Contains(DangerousGood.InfectiousSubstance)) ||
                         (dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible) && dangerousGoods.Contains(DangerousGood.DangerousWhenWet)) || 
                         (dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible) && dangerousGoods.Contains(DangerousGood.Toxic)) || 
                         (dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible) && dangerousGoods.Contains(DangerousGood.Corrosive)) ||
                         (dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) ||
                         (dangerousGoods.Contains(DangerousGood.RadioactiveMaterials) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) || 
                         (dangerousGoods.Contains(DangerousGood.DangerousWhenWet) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) ||  
                         (dangerousGoods.Contains(DangerousGood.Corrosive) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) || 
                         (dangerousGoods.Contains(DangerousGood.ToxicGas) && dangerousGoods.Contains(DangerousGood.FlammableSolid)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableLiquid) && dangerousGoods.Contains(DangerousGood.FlammableSolid)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableSolid) && dangerousGoods.Contains(DangerousGood.DangerousWhenWet)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableSolid) && dangerousGoods.Contains(DangerousGood.Toxic)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableSolid) && dangerousGoods.Contains(DangerousGood.InfectiousSubstance)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableSolid) && dangerousGoods.Contains(DangerousGood.Corrosive)) || 
                         (dangerousGoods.Contains(DangerousGood.FlammableSolid) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) ||
                         (dangerousGoods.Contains(DangerousGood.OrganicPeroxide) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) ||
                         (dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible) && dangerousGoods.Contains(DangerousGood.InfectiousSubstance)) || 
                         (dangerousGoods.Contains(DangerousGood.DangerousWhenWet) && dangerousGoods.Contains(DangerousGood.InfectiousSubstance)) || 
                         (dangerousGoods.Contains(DangerousGood.Toxic) && dangerousGoods.Contains(DangerousGood.InfectiousSubstance)) || 
                         (dangerousGoods.Contains(DangerousGood.Corrosive) && dangerousGoods.Contains(DangerousGood.InfectiousSubstance)) || 
                         (dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods) && dangerousGoods.Contains(DangerousGood.InfectiousSubstance)) ||
                         (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.FoodstuffsOrFoodContainers)) ||
                         (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.FoodstuffsOrFoodContainers)) ||
                         (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.FoodstuffsOrFoodContainers)) ||
                         (dangerousGoods.Contains(DangerousGood.FlammableLiquid) && dangerousGoods.Contains(DangerousGood.FoodstuffsOrFoodContainers)) ||
                         (dangerousGoods.Contains(DangerousGood.FlammableSolid) && dangerousGoods.Contains(DangerousGood.FoodstuffsOrFoodContainers)) ||
                         (dangerousGoods.Contains(DangerousGood.SpontaneouslyCombustible) && dangerousGoods.Contains(DangerousGood.FoodstuffsOrFoodContainers)) ||
                         (dangerousGoods.Contains(DangerousGood.DangerousWhenWet) && dangerousGoods.Contains(DangerousGood.FoodstuffsOrFoodContainers)) ||
                         (dangerousGoods.Contains(DangerousGood.OxidizingSubstances) && dangerousGoods.Contains(DangerousGood.FoodstuffsOrFoodContainers)) ||
                         (dangerousGoods.Contains(DangerousGood.OrganicPeroxide) && dangerousGoods.Contains(DangerousGood.FoodstuffsOrFoodContainers)) ||
                         (dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods) && dangerousGoods.Contains(DangerousGood.FoodstuffsOrFoodContainers)))
                {
                    MainPageSingleton.CompatibilityFrame.BackgroundColor = Color.Green;
                    MainPageSingleton.CompatibilityOverview.Text = Compatible + Environment.NewLine + Environment.NewLine + CheckDocuments;
                }
                // Incompatible + CheckForExceptions (7)
                else if ((dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas)) ||
                         (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.ToxicGas)) ||
                         (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.Toxic)) ||
                         (dangerousGoods.Contains(DangerousGood.Explosives) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) ||
                         (dangerousGoods.Contains(DangerousGood.FlammableGas) && dangerousGoods.Contains(DangerousGood.FlammableLiquid)))
                {
                    MainPageSingleton.CompatibilityFrame.BackgroundColor = Color.Red;
                    MainPageSingleton.CompatibilityOverview.Text = Incompatible + Environment.NewLine + Environment.NewLine + CheckForExceptions;
                }
                // Separate + CheckForExceptions (8)
                else if (dangerousGoods.Contains(DangerousGood.OxidizingSubstances) && dangerousGoods.Contains(DangerousGood.RadioactiveMaterials))
                {
                    MainPageSingleton.CompatibilityFrame.BackgroundColor = Color.Yellow;
                    MainPageSingleton.CompatibilityOverview.Text = Separate + Environment.NewLine + Environment.NewLine + CheckForExceptions;
                }
                // Compatible + CheckForExceptions (9)
                else if (dangerousGoods.Contains(DangerousGood.InfectiousSubstance) && dangerousGoods.Contains(DangerousGood.RadioactiveMaterials) ||
                        (dangerousGoods.Contains(DangerousGood.NonFlammableNonToxicGas) && dangerousGoods.Contains(DangerousGood.RadioactiveMaterials)) ||
                        (dangerousGoods.Contains(DangerousGood.ToxicGas) && dangerousGoods.Contains(DangerousGood.RadioactiveMaterials)) ||
                        (dangerousGoods.Contains(DangerousGood.OxidizingSubstances) && dangerousGoods.Contains(DangerousGood.MiscellaneousDangerousGoods)) ||
                        (dangerousGoods.Contains(DangerousGood.Toxic) && dangerousGoods.Contains(DangerousGood.Corrosive)) ||
                        (dangerousGoods.Contains(DangerousGood.RadioactiveMaterials) && dangerousGoods.Contains(DangerousGood.FoodstuffsOrFoodContainers)) ||
                        (dangerousGoods.Contains(DangerousGood.Toxic) && dangerousGoods.Contains(DangerousGood.RadioactiveMaterials)))
                {
                    MainPageSingleton.CompatibilityFrame.BackgroundColor = Color.Green;
                    MainPageSingleton.CompatibilityOverview.TextColor = Color.Black;
                    MainPageSingleton.CompatibilityOverview.Text = Compatible + Environment.NewLine + Environment.NewLine + CheckForExceptions;
                }
            }
        }
    }
}
