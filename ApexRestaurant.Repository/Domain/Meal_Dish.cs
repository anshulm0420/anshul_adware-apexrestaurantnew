using System;
namespace ApexRestaurant.Repository.Domain
{
    public class Meal_Dish
    {
        public int Meal_Id { get; set; }
        public int Menu_Item_Id { get; set; }
        public int Quantity { get; set; }
    }
}