using System;
using System.Collections.Generic;
using System.Text;

namespace STYLEONMobile.Model
{
   public static class CarouselRepository
    {
        public static List<Carousel> GetCarousels()
        {
            return new List<Carousel>()
            {
                new Carousel{Body="40% Header" ,Header="Summer Cloth", ImageUrl="elegantCol.png"},
                new Carousel{Body="40% Header" ,Header="Summer Cloth", ImageUrl="elegantCol.png"},
                new Carousel{Body="40% Header" ,Header="Summer Cloth", ImageUrl="elegantCol.png"},
                new Carousel{Body="40% Header" ,Header="Summer Cloth", ImageUrl="elegantCol.png"},
                new Carousel{Body="40% Header" ,Header="Summer Cloth", ImageUrl="elegantCol.png"}
            };
         }
    }
}
