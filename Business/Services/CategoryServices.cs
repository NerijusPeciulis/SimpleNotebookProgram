using Repository.DBContext;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class CategoryServices
    {
        private NotebookDBContext _context;

        public CategoryServices(NotebookDBContext context)
        {
            _context = context;
        }

        public void CreateNewCategory(string name)
        {
            Category category = new(name);


            _context.Add(category);
            _context.SaveChanges();

            var categories = _context.Categories.
                FirstOrDefault(categories => categories.Name == name);


        }

        public void ShowCategories()
        {
            _context.DisplayAndSearch("SELECT id, Name", dataGridview);

        }

    }
}
