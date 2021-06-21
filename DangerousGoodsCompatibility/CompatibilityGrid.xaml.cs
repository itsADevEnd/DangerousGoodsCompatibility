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
    public partial class CompatibilityGrid : ContentView
    {
        public CompatibilityGrid()
        {
            InitializeComponent();
        }
    }
}