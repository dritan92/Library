using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.CheckoutModels
{
    public class CheckoutModel
    {
        public String LibraryCardId { get; set; }
        public String Title { get; set; }
        public int AssetId { get; set; }
        public string ImageUrl { get; set; }
        public int HoldCount { get; set; }
        public bool isCheckedOut { get; set; }
    }
}
