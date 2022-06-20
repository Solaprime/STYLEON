using System;
using System.Collections.Generic;
using System.Text;
using STYLEONMobile.Model;

namespace STYLEONMobile.ViewModel
{
    public class HomePageViewModel
    {
      public List<Clothe> GetClothes { get; set; }
        public List<Carousel> GetCarousel { get; set; }
        public HomePageViewModel()
        {
            GetClothes = ClotheRepository.GetClothesList();
            GetCarousel = CarouselRepository.GetCarousels();
        }
    }
}
