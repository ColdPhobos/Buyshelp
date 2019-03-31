using System.Collections.Generic;
using Buyshelp.Models;
using Buyshelp.Views;

namespace Buyshelp.Strategy
{
    public class CreateMenuListAndroidIOSStrategy : ICreateViews
    {
        public List<MainMenuItems> CreateMenuList(List<MainMenuItems> menuList)
        {
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

            return menuList;
        }
    }
}
