using Buyshelp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Buyshelp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnCreateProductList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MakeShoppingListPage());          
        }
    }
}
