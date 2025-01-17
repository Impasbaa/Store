using Entities.Models;
using Services.Contracts;
using Repositories.Contracts;

namespace Services
{
    public class CategoryManager : ICategoryService
    {
        private readonly IRepositoryManager _manager;
        public CategoryManager(IRepositoryManager manager){
            _manager = manager;
        }
        public IEnumerable<Category> GetAllCategories(bool trackChanges){
            return _manager.Category.FindAll(trackChanges);
        }
    }
}