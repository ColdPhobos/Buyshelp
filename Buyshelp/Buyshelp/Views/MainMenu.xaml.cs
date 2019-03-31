using Buyshelp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Buyshelp.Views
{
    public partial class MainMenu : MasterDetailPage
    {
        public List<MainMenuItems> menuList { get; set; }

        public MainMenu()
        {
            InitializeComponent();
            menuList = new List<MainMenuItems>();
            // Adding menu items to menuList and you can define title ,page and icon  
            menuList.Add(new MainMenuItems()
            {
                Title = "Strona główna",
                Icon = "Home.png",
                TargetType = typeof(MainPage)
            });
            menuList.Add(new MainMenuItems()
            {
                Title = "Stwórz listę",
                Icon = "Createlist.png",
                TargetType = typeof(MakeShoppingListPage)
            });
            menuList.Add(new MainMenuItems()
            {
                Title = "Zacznij zakupy",
                Icon = "Shopping.png",
                TargetType = typeof(MakeShoppingListPage)
            });
            menuList.Add(new MainMenuItems()
            {
                Title = "Moje listy",
                Icon = "Lists.png",
                TargetType = typeof(MakeShoppingListPage)
            });
            menuList.Add(new MainMenuItems()
            {
                Title = "Podsumowanie",
                Icon = "Summary.png",
                TargetType = typeof(MakeShoppingListPage)
            });
            menuList.Add(new MainMenuItems()
            {
                Title = "Pomoc",
                Icon = "Help.png",
                TargetType = typeof(MakeShoppingListPage)
            });
            menuList.Add(new MainMenuItems()
            {
                Title = "Ustawienia",
                Icon = "Settings.png",
                TargetType = typeof(MakeShoppingListPage)
            });


            // Setting our list to be ItemSource for ListView in MainPage.xaml  
            navigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page  
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(MainPage)))
            {
                BarBackgroundColor = Color.FromRgb(18, 100, 229)
            };
        }
        // Event for Menu Item selection, here we are going to handle navigation based  
        // on user selection in menu ListView  
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {      
            var item = (MainMenuItems)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page))
            {
                BarBackgroundColor = Color.FromRgb(18, 100, 229)
            };
            IsPresented = false;
        }
    }
}