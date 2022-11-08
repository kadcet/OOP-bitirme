using Cdr.Domain.Entities;
using Cdr.Data.IOToTxt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cdr.Domain.Interfaces;
using Cdr.Infrastructer;
using System.Text.Json;

namespace Cdr.AppLayer
{
    public class CategoryService : ICategoryService
    {
        IRepository<Category> _categoryRepository;

        public CategoryService()
        {
            _categoryRepository = IOCContainer.Resolve<IRepository<Category>>();
           // _categoryRepository = new TextFileRepository<Category>();
        }
        private static List<Category> listeCategory = new List<Category>();

        public Category Creat(string name)
        {
            Category category = new Category();
            category.Id = Guid.NewGuid().ToString();
            category.Name = name;
            _categoryRepository.Add(category);
            //listeCategory.Add(category);
            return category;

        }

        public void DeleteCategory(string id)
        {
            _categoryRepository.Delete(id);
        }

        

        public void RemoveCategory(string namebafore,string nameafter)
        {
            _categoryRepository.RemoveCategory(namebafore, nameafter);
        }



        public IReadOnlyList<Category> GetAllCategories()
        {
            

            List<Category> categories = new List<Category>();
            string jsonst = "";
            if (File.Exists("Category.txt"))
            {
                jsonst = File.ReadAllText("Category.txt");
            }

            categories = JsonSerializer.Deserialize<List<Category>>(jsonst, new JsonSerializerOptions { IncludeFields = true });

            return categories.AsReadOnly();
        }
        
    }
}
