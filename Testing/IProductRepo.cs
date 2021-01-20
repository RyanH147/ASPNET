using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;

namespace Testing
{
    public interface IProductRepo
    {
        public IEnumerable<ProductModel> GetAllProducts();

        public ProductModel GetProduct(int id);

        public void UpdateProduct(ProductModel product);

        public void InsertProduct(ProductModel productToInsert);

        public IEnumerable<Category> GetCategories();

        public ProductModel AssignCategory();

        public void DeleteProduct(ProductModel product);
    }
}
