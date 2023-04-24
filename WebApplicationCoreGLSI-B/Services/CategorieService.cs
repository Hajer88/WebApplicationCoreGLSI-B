using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationCoreGLSI_B.Models;
using WebApplicationCoreGLSI_B.ServicesContracts;

namespace WebApplicationCoreGLSI_B.Services
{
    public class CategorieService : ICategorieService
    {
        private readonly AppDbContext _context;
        public CategorieService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Categorie> Create(Categorie c)
        {
            _context.cats.Add(c);
            await _context.SaveChangesAsync();
            return c;
        }

        public void Delete(int Id)
        {
            var cat = _context.cats.Find(Id);
            //var sscats = _context.sscats
            //    .Where(c => c.categorieId == Id)
            //    .ToList();
            //foreach(var item in sscats) { 
            //_context.sscats.Remove(item);
            //    _context.SaveChanges();
            //}
            _context.cats.Remove(cat);
            _context.SaveChanges();
        }

        public Categorie Edit(int Id, Categorie c)
        {
            var catInDb=  _context.cats.Find(Id);

            _context.cats.Update(catInDb);
            _context.SaveChanges();
            return c;

        }

        public async Task<ICollection<Categorie>> GetAll()
        {
            return await _context.cats.ToListAsync();
        }
    }
}
