using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sitecore.Feature.Products.Models;
namespace Sitecore.Feature.Products.Repositories
{
    public interface IProductRepository
    {
        List<Sitecore.Data.Items.Item> GetProductDetails();
    }
}
