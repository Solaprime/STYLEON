using System;
using System.Collections.Generic;
using System.Text;

namespace STYLEONMobile.Model
{
   public  class Clothe
    {
        private string imageUrl;
        private double price;
        private string name;
        private bool largeSize;

        public bool LargeSize
        {
            get { return largeSize; }
            set { largeSize = value; }
        }

        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        } 
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
         public string Name
        {
            get { return name; }
            set { name = value; }
        }


    }
}
