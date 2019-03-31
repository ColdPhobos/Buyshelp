using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Buyshelp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpViewEditProduct
    {
        ObservableCollection<string> products;
        int choosenProduct_Index;


        public PopUpViewEditProduct(ObservableCollection<string> _products,  int _choosenProduct_Index)
        {
            InitializeComponent();

            products = _products;
            choosenProduct_Index = _choosenProduct_Index;

            DisplayChoosenProductInEntry(_products, _choosenProduct_Index);
        }

        private void DisplayChoosenProductInEntry(ObservableCollection<string> products, int choosenProduct_Index)
        {
            EntryNewNameProduct.Text = products[choosenProduct_Index];
        }

        private async void BtnAcceptChange_Clicked(object sender, EventArgs e)
        {
            products[choosenProduct_Index] = EntryNewNameProduct.Text;

            await PopupNavigation.Instance.RemovePageAsync(this, true);
        }
    }
}