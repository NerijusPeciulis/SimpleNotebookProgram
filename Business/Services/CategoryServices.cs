using Repository.DBContext;
using Repository.Models;
using System.Linq;

namespace Business.Services
{
    public class CategoryServices
    {
        private NotebookDBContext _context;

        public CategoryServices(NotebookDBContext context)
        {
            _context = context;
        }

        public void CreateNewCategory(string name, int userId)
        {
            Category category = new(name, userId);

            _context.Add(category);
            _context.SaveChanges();
        }
    }
}
