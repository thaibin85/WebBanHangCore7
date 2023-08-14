using AspNetCaNhan.Models;

namespace AspNetCaNhan.Repository
{
    public interface ICategoryRepository
    {
        public ICollection<Category> GetAll();
        public Category GetById(int id);
        public bool Save();
        public bool Delete(Category category);
        public bool Update(Category category);
        public bool Create(Category category);
    }
}
