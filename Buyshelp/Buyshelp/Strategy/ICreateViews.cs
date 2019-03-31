using Buyshelp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Buyshelp.Strategy
{
    public interface ICreateViews
    {
        List<MainMenuItems> CreateMenuList(List<MainMenuItems> menuList);
    }
}
