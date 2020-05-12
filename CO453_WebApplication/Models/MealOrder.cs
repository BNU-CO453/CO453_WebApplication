using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CO453_WebApplication.Models
{
    public class MealOrder
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public Dish Starter { get; set; }
        public Dish Mains { get; set; }
        public Dish Desert { get; set; }

        public decimal CalculateTotal()
        {
            return Starter.Price + Mains.Price + Desert.Price;
        }
    }
}
