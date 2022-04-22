using System;
using System.Collections.Generic;
using System.Text;

namespace STYLEONMobile.Model
{
   public  class Carousel
    {
        private String imageUrl;

        public String ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }
        private  string header;

        public string Header
        {
            get { return  header; }
            set {  header = value; }
        }
        private string body;

        public string Body
        {
            get { return body; }
            set { body = value; }
        }


    }
}
