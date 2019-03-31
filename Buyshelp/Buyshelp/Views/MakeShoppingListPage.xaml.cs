using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Buyshelp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MakeShoppingListPage : ContentPage
	{
        ObservableCollection<string> products;

		public MakeShoppingListPage ()
		{
			InitializeComponent ();

            products = new ObservableCollection<string>();

            ListViewProducts.ItemsSource = products;

            ListViewProducts.ItemSelected += ListViewProducts_ItemSelected;

        }

        private void ListViewProducts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            BtnDelete.IsVisible = true;
            ListViewProducts.ScrollTo(ListViewProducts.SelectedItem, ScrollToPosition.Center, false);
        }

        private void BtnAddProduct_Clicked(object sender, EventArgs e)
        {
            BtnDelete.IsVisible = false;

            if (!string.IsNullOrEmpty(EntryProduct.Text))
            {
                if (products.Contains(EntryProduct.Text))
                    DisplayAlert($"Produkt : {EntryProduct.Text}", "Ten produkt już jest na liście", "Ok");
                else
                {
                    products.Add(EntryProduct.Text);
                    EntryProduct.Text = "";

                    ListViewProducts.ScrollTo(products.LastOrDefault(), ScrollToPosition.End, false);
                }
            }
            else
                DisplayAlert("Błędna nazwa", "Podaj nazwę produktu!", "Ok");

        }

        private async void Button_Clicked(Button sender, EventArgs e)
        {
            string choosenAction = await DisplayActionSheet(sender.Text.ToUpper(), "Anuluj", null, "Edytuj", "Usuń");

            switch (choosenAction)
            {
                case "Edytuj":
                    {
                        await PopupNavigation.Instance.PushAsync(new PopUpViewEditProduct(products, products.IndexOf(sender.Text)));
                        BtnDelete.IsVisible = false;
                        break;
                    }
                case "Usuń":
                    {
                        products.Remove(sender.Text.ToString());
                        BtnDelete.IsVisible = false;
                        break;
                    }
                default:
                    break;
            }
        }

        private void BtnDelete_Clicked(object sender, EventArgs e)
        {   
            products.Remove(ListViewProducts.SelectedItem.ToString());
            BtnDelete.IsVisible = false; 
        }

        private void BtnSaveList_Clicked(object sender, EventArgs e)
        {

        }
    }
}