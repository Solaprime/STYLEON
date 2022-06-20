using STYLEONMobile.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace STYLEONMobile.ViewModel
{
    public class FavouritePageViewModel
    {
        public List<Clothe>  FavouriteClothe{ get; set; }
        public FavouritePageViewModel()
        {
            FavouriteClothe = FavouriteRepository.GetFavouriteList();
        }
    }
}
