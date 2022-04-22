using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using STYLEONMobile.Model;

namespace STYLEONMobile.Common
{
    public class ClothTemplateSelector : DataTemplateSelector
    {
        // this my template selector for the cloth
        // which Propery u use dependly slowly on u
        public DataTemplate BigSize { get; set; }
        public DataTemplate SmallSize { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Clothe)item).LargeSize ? BigSize : SmallSize;
        }
    }
}
