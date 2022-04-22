using System;
using System.Collections.Generic;
using System.Text;

namespace STYLEONMobile.Model
{
    public  static class ClotheRepository
    {
        // Create A method  dat returns a LiSt of Product
        public static List<Clothe> GetClothesList()
        {
            return new List<Clothe>()
            {
                new Clothe {Name = "Coats", Price =200, ImageUrl="coats.png" , LargeSize=true},
                new Clothe {Name = "ElegantCol", Price =200, ImageUrl="elegantCol.png",LargeSize=true},
                new Clothe {Name = "LeatherBag ", Price =200, ImageUrl="leatherBag.png",LargeSize=true},
                new Clothe {Name = "Minidress", Price =200, ImageUrl="minidress.png" ,LargeSize=true},
                new Clothe {Name = "Minidress", Price =200, ImageUrl="minidress.png" ,LargeSize=false},
                new Clothe {Name = "Minidress", Price =200, ImageUrl="minidress.png" ,LargeSize=true},
                new Clothe {Name = "Minidress", Price =200, ImageUrl="minidress.png" ,LargeSize=true},
                new Clothe {Name = "Minidress", Price =200, ImageUrl="minidress.png" ,LargeSize=true},
                new Clothe {Name = "Minidress", Price =200, ImageUrl="minidress.png" ,LargeSize=false},
                new Clothe {Name = "Minidress", Price =200, ImageUrl="minidress.png",LargeSize=true},
                new Clothe {Name = "Minidress", Price =200, ImageUrl="minidress.png" ,LargeSize=false},
                new Clothe {Name = "Minidress", Price =200, ImageUrl="minidress.png" ,LargeSize=true},
                new Clothe {Name = "Minidress", Price =200, ImageUrl="minidress.png" ,LargeSize=false},
                new Clothe {Name = "Minidress", Price =200, ImageUrl="minidress.png" ,LargeSize=false},
                new Clothe {Name = "Minidress", Price =200, ImageUrl="minidress.png" ,LargeSize=false},
                new Clothe {Name = "Minidress", Price =200, ImageUrl="minidress.png" ,LargeSize=true},
                new Clothe {Name = "Minidress", Price =200, ImageUrl="minidress.png" ,LargeSize=false},
                new Clothe {Name = "Minidress", Price =200, ImageUrl="minidress.png" ,LargeSize=true},
                new Clothe{Name="WpmenCol", Price=200, ImageUrl="womenCol.png"}
            };
        }
    }
}
