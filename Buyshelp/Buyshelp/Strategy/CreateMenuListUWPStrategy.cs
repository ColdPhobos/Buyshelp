using System;
using System.Collections.Generic;
using System.Text;
using Buyshelp.Models;
using Buyshelp.Views;

namespace Buyshelp.Strategy
{
    public class CreateMenuListUWPStrategy : ICreateViews
    {

        public List<MainMenuItems> CreateMenuList(List<MainMenuItems> menuList)
        {
            menuList.Add(new MainMenuItems()
            {
                Title = "Strona główna",
                Icon = @"Images\Home.png",
                TargetType = typeof(MainPage)
            });
            menuList.Add(new MainMenuItems()
            {
                Title = "Stwórz listę",
                Icon = "Images/Createlist.png",
                TargetType = typeof(MakeShoppingListPage)
            });
            menuList.Add(new MainMenuItems()
            {
                Title = "Zacznij zakupy",
                Icon = "Images/Shopping.png",
                TargetType = typeof(MakeShoppingListPage)
            });
            menuList.Add(new MainMenuItems()
            {
                Title = "Moje listy",
                Icon = "Images/Lists.png",
                TargetType = typeof(MakeShoppingListPage)
            });
            menuList.Add(new MainMenuItems()
            {
                Title = "Podsumowanie",
                Icon = "Images/Summary.png",
                TargetType = typeof(MakeShoppingListPage)
            });
            menuList.Add(new MainMenuItems()
            {
                Title = "Pomoc",
                Icon = "Images/Help.png",
                TargetType = typeof(MakeShoppingListPage)
            });
            menuList.Add(new MainMenuItems()
            {
                Title = "Ustawienia",
                Icon = "Images/Settings.png",
                TargetType = typeof(MakeShoppingListPage)
            });

            return menuList;
        }
    }
}
