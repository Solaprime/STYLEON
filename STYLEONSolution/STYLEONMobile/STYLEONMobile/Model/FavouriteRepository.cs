using System;
using System.Collections.Generic;
using System.Text;

namespace STYLEONMobile.Model
{
  public static   class FavouriteRepository
    {
        public static List<Clothe> GetFavouriteList()
        {
            return new List<Clothe>()
            {
                new Clothe { Name = "Coats", Price = 200, ImageUrl = "coats.png", LargeSize = true },
                new Clothe { Name = "ElegantCol", Price = 200, ImageUrl = "elegantCol.png", LargeSize = true },
                new Clothe { Name = "LeatherBag ", Price = 200, ImageUrl = "leatherBag.png", LargeSize = true },
                new Clothe { Name = "Minidress", Price = 200, ImageUrl = "minidress.png", LargeSize = true },
                new Clothe { Name = "Minidress", Price = 200, ImageUrl = "minidress.png", LargeSize = false },
                new Clothe { Name = "Minidress", Price = 200, ImageUrl = "minidress.png", LargeSize = true }
            };
         }
    }
}
