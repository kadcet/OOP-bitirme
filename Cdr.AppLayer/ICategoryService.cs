using Cdr.Domain.Entities;

namespace Cdr.AppLayer
{
    // Bu katmanda servisler olabilir hatta application servisler olabilir
    public interface ICategoryService
    {
        Category Creat(string name);
        void DeleteCategory(string id);
        
        void RemoveCategory(string namebefore,string nameafter);

        IReadOnlyList<Category> GetAllCategories();
    }
}