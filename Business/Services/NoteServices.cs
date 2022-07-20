using Repository.DBContext;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class NoteServices
    {
        private NotebookDBContext _context;

        public NoteServices(NotebookDBContext context)
        {
            _context = context;
        }

        public void CreateNewNote(string name, string description, int categoryId)
        {
            Note note = new(name, description, categoryId);


            _context.Add(note);
            _context.SaveChanges();

            var notes = _context.Notes.
            FirstOrDefault(notes => notes.Name == name);

        }
    }
}
