using Core;
using IService.IServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService : IProductService
    {
        private List<Product> products;
        public ProductService()
        {
            products = new List<Product>()
            {
                new Product { Id = 1,Name="Redmi",CategoryId=2,Price=5000,Quantity=10,Rate=5},
                new Product { Id = 2,Name="Rtx5090ti",CategoryId=3,Price=100000,Quantity=10,Rate=5},
                new Product { Id = 3,Name="IPhone",CategoryId=2,Price=40000,Quantity=10,Rate=5},
                new Product { Id = 4,Name="Hdd 1Tb",CategoryId=4,Price=700,Quantity=10,Rate=5},
            };
        }
        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategoryId(int CategoryId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
