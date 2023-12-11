using Core;
using IService.IServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CategoryService : ICategoryService
    {
        private List<Category> categories;
        public CategoryService()
        {

            categories = new List<Category>()
            {
                new Category{ Name= "Laptop",Description="Tech",Id=1},
                new Category{ Name= "Phone",Description="Tech",Id=2},
                new Category{ Name= "GraphicCards",Description="Tech",Id=3},
                new Category{ Name= "StorageDisk",Description="Tech",Id=4}
            };
        }
        public void AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void EditCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Category GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
