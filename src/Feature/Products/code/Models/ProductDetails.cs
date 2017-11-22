using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;

namespace Sitecore.Feature.Products.Models
{
    public class ProductDetails
    {
        public string Title { get; set; }
        public  string Summary { get; set; }
        public  string Body { get; set; }
        public  string Image { get; set; }
        public   Item DataSource { get; set; }


        public List<Sitecore.Data.Items.Item> childItems { get; set; }
    }
}