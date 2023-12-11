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
            if(products != null&&products.Count>0) {
                var maxId = products.Max(p => p.Id);
                product.Id = maxId+1;
            }
            else
            {
                product.Id = 1;
            }
            products.Add(product);
        }

        public void DeleteProduct(int Id)
        {
            products.Remove(GetProduct(Id));
        }

        public Product GetProduct(int Id)
        {
            return products.Find(x=>x.Id==Id);
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public List<Product> GetProductsByCategoryId(int CategoryId)
        {
            return products.Where(x=>x.CategoryId==CategoryId).ToList();
        }

        public void UpdateProduct(Product product)
        {
            var ProductToUpdate=GetProduct(product.Id);
            if (ProductToUpdate!=null)
            {
                ProductToUpdate.Price= product.Price;
                ProductToUpdate.Quantity= product.Quantity;
                ProductToUpdate.Rate= product.Rate;
                ProductToUpdate.CategoryId = product.CategoryId;
                ProductToUpdate.Name= product.Name; 
            }
        }
    }
}
