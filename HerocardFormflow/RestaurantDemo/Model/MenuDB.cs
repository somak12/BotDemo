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
                new MenuOption(){ItemName = "CrispyChicken" , Description ="4 pcs of crispy chicken.", ItemImage="http://divascancook.com/wp-content/uploads/2015/01/IMG_0231.jpg" }, 
                new MenuOption(){ ItemName = "ChickenWings" , Description= "6 pcs of crispy chicken wings." , ItemImage="https://www.munatycooking.com/wp-content/uploads/2016/05/crispy-spicy-chicken-wings-5.jpg"},
                new MenuOption(){ ItemName = "ChickenDrumStick" , Description="4 pcs of chicken drumsticks." , ItemImage="https://www.budgetbytes.com/wp-content/uploads/2016/03/Crispy-Baked-Honey-Sriracha-Chicken-Drumsticks-above-straight.jpg" },
                new MenuOption(){ ItemName = "ChickenPopcorn", Description = "1 medium chicken popcorn.", ItemImage = "http://mybodymykitchen.com/wp-content/uploads/2016/02/jalapeno-popcorn-chicken-1024x1024.jpg" },
            };
        }
    }
}