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
            if (categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase))) return;
            if(categories!=null&&categories.Count>0)
            {
                var maxId = categories.Max(x => x.Id);
                category.Id = maxId+1;
            }
            else
            {
                category.Id = 1;
            }
            categories.Add(category);
        }

        public void DeleteCategory(int id)
        {
            categories.Remove(GetCategoryById(id));
        }

        public void EditCategory(Category category)
        {
            var CategoryToUpdate =GetCategoryById(category.Id);
            if(CategoryToUpdate != null)
            {
                CategoryToUpdate.Name = category.Name;
                CategoryToUpdate.Description = category.Description;    
            }
            else
            {
                return;
            }
        }

        public List<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int id)
        {
            var category = categories.Find(x => x.Id == id);
            return category;
        }
    }
}
