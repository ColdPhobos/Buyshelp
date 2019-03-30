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
            if(EntryProduct.Text != "")
            {
                products.Add(EntryProduct.Text);
                EntryProduct.Text = "";

                ListViewProducts.ScrollTo(products.LastOrDefault(), ScrollToPosition.End, false);
            }

        }

        private void Button_Clicked(Button sender, EventArgs e)
        {
            DisplayAlert("fhj", sender.Text, "asf");

            products.Remove(sender.Text);
        }

        private void BtnDelete_Clicked(object sender, EventArgs e)
        {   
            products.Remove(ListViewProducts.SelectedItem.ToString());
            BtnDelete.IsVisible = false;
        }
    }
}