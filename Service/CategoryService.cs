using AspNetCaNhan.Data;
using AspNetCaNhan.Models;
using AspNetCaNhan.Repository;

namespace AspNetCaNhan.Service
{
    public class CategoryService : ICategoryRepository
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }
        public bool Create(Category category)
        {
            _context.Categories.Add(category);
            return Save();
        }

        public bool Delete(Category category)
        {
            _context.Categories.Remove(category);
            return Save();
        }

        public ICollection<Category> GetAll()
        {
            var categories = _context.Categories.ToList();
            return categories;
        }

        public Category GetById(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            return category;
        }

        public bool Save()
        {
            var save = _context.SaveChanges();
            return save > 0? true: false;
        }

        public bool Update(Category category)
        {
            _context.Categories.Update(category);
            return Save();
        }
    }
}
