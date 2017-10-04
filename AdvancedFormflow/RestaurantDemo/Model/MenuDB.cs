using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantDemo.Model
{
    public class MenuDB
    {
        public static List<MenuOption> GetAllMenuOptions()
        {
            return new List<MenuOption>() {
                new MenuOption(){ItemName = "CrispyChicken" }, 
                new MenuOption(){ ItemName = "ChickenWings" },
                new MenuOption(){ ItemName = "ChickenDrumStick" },
                new MenuOption(){ ItemName = "ChickenPopcorn" },
            };
        }
    }
}