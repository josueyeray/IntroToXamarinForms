using Converters.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Converters.View
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();

            var locator = (ViewModelLocator)App.Current.Resources["Locator"];
            BindingContext = locator.MainVM;
        }
    }
}
