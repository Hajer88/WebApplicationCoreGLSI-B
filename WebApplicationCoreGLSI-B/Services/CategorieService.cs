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

        public Categorie Edit(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Categorie>> GetAll()
        {
            return await _context.cats.ToListAsync();
        }
    }
}
