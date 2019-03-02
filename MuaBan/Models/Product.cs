using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace MuaBan.Models
{
    public class Product
    {
        public string Brandproduct { get; set; }
        public string Nameproduct { get; set; }
        public string ImageProductShow { get; set; }
        public string ImageProductDetail1 { get; set; }
        public string ImageProductDetail2 { get; set; }
        public string ImageProductDetail3 { get; set; }             
        public string Price { get; set; }
        public bool TopSell { get; set; }
        public bool Check { get; set; }
        public string Decription { get; set; }
        public Product() { }
        public Product(string brandproduct = null, string nameproduct = null, string imageproductshow = null, string imageproductdetail1 = null, string imageproductdetail2 = null, string imageproductdetail3 = null, string price = null, bool topsell = false, bool check = false, string decription=null)
        {
            Brandproduct = brandproduct;
            Nameproduct = nameproduct;
            ImageProductShow = ImageProductShow;
            ImageProductDetail1 = imageproductdetail1;
            ImageProductDetail2 = imageproductdetail2;
            ImageProductDetail3 = imageproductdetail3;
            Price = price;
            TopSell = topsell;
            Check = check;
            Decription = decription;
        }
    }
}