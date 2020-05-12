using System.Collections.Generic;


namespace CO453_WebApplication.Models
{
    public enum DishCategories
    {
        Starters,
        Mains,
        Deserts
    }

    public class MenuList
    {
        private readonly List<Dish> menu = new List<Dish>()
        {
            new Dish
            {
                ID = 1,
                Category = DishCategories.Starters,
                Name = "Cauliflower Veneziana",
                Description = "Grated prosociano with sultanas, roasted peppers, pine kernels & capers",
                Price = 6.50m
            },
            new Dish
            {
                ID = 2,
                Category = DishCategories.Starters,
                Name = "Spring Greens",
                Description = "Kentish spring greens, dill and roasted onion",
                Price = 3.50m
            },
            new Dish
            {
                ID = 3,
                Category = DishCategories.Starters,
                Name = "House Fishcake",
                Description = "Baby spinach, caper & parsley butter sauce",
                Price = 7.95m
            }
        };

        public IEnumerable<Dish> GetDishes()
        {
            return menu;
        }
    }

    public class Dish
    {
        public int ID { get; set; }

        public DishCategories Category { get; set; }
        
        public string Name { get; set; }
        
        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}
