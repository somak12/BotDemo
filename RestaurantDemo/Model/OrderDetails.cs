using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Bot.Builder.Dialogs;

namespace RestaurantDemo.Model
{
    [Serializable]
    public class OrderDetails
    {
        public List<MenuOptions> Items { get; set; }

        public DeliveryOptions DeliveryMode { get; set; }

        public string UserName { get; set; }
        public string Phone { get; set; }
        public string address { get; set; }


        public static IForm<OrderDetails> BuildForm()
        {
            return new FormBuilder<OrderDetails>()
                    .Message("Welcome to demo Restaurant bot!")
                    .OnCompletion(async (context, order) =>
                    {
                        await context.PostAsync("Thanks for your order!");
                    })
                    .Build();
        }

    }
    // This starts at 1 because 0 is the "no value" value
    public enum DeliveryOptions
    {
        TakeAway = 1,
        Delivery
    }
    public enum MenuOptions
    {
        CrispyChicken = 1,
        ChickenWings,
        ChickenDrumStick,
        ChickenPopcorn

    }

    
}