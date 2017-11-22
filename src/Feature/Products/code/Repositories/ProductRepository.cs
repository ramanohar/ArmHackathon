using Sitecore.Feature.Products.Models;
using Sitecore.Feature.Products.Repositories;
using Sitecore.Feature.Products;
using System.Collections.Generic;
using System.Linq;

namespace Sitecore.Feature.Products.Repositories
{
    /// <summary>
    /// This method used for fetching product details 
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        /// <summary>
        ///  Class Name:  Sitecore.Feature.Products.Repositories.ProductRepository
        /// </summary>
        /// <remarks>
        ///This method used to fetch product detials
        /// </remarks>
        /// <returns>ChildList</returns>
        public List<Sitecore.Data.Items.Item> GetProductDetails()
        {
            List<Sitecore.Data.Items.Item> items = new List<Data.Items.Item>();
            if (Sitecore.Context.Database != null)
            {
                //Collections.ChildList homeItem = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath).GetChildren();                
                items = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath).GetChildren().Where(x => x.TemplateID.ToString() == "{FF066D50-D1CF-40F9-94A5-CD0AA6F6F2DA}").ToList();
            }
            return items;
        }
    }
}