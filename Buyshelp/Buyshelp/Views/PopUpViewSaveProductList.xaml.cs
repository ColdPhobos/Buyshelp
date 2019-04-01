using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buyshelp.Models;
using Rg.Plugins.Popup.Services;
using SQLite;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Buyshelp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopUpViewSaveProductList
	{
        ObservableCollection<string> products;

        public PopUpViewSaveProductList (ObservableCollection<string> _products)
		{ 
            InitializeComponent ();
            products = _products;
        }

        private async void BtnSaveList_Clicked(object sender, EventArgs e)
        {
            //create path for database
            var directory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var databaseName = EntryListName.Text.ToUpper();
            var extension = ".db3";
            var path = Path.Combine(directory, databaseName + extension);

            //try create database            
            if (CheckDoesDatabaseAlreadyExist(directory, databaseName)) await DisplayAlert(EntryListName.Text, "Taka lista już istnieje", "Ok");
            else
            {
                var db = new SQLiteConnection(path);
                db.CreateTable<Products>();
                foreach (var product in products)
                {
                    Products item = new Products()
                    {
                        Name = product
                    };

                    db.Insert(item);
                }

                //Exit popup view
                await PopupNavigation.Instance.RemovePageAsync(this, true);

            }
            
        }

        private bool CheckDoesDatabaseAlreadyExist(string path, string checkingFile)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles("*.db3");

            List<FileInfo> existingFIles =  files.Where(x => x.Name == checkingFile + ".db3").ToList();

            if (existingFIles.Count == 0) return false;
            else return true;
        }
    }
}