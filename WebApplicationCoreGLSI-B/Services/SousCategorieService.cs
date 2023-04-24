using Microsoft.EntityFrameworkCore;
using WebApplicationCoreGLSI_B.Models;
using WebApplicationCoreGLSI_B.ServicesContracts;

namespace WebApplicationCoreGLSI_B.Services
{
    public class SousCategorieService : ISousCategorieService
    {
        private readonly AppDbContext appDbContext;
        public SousCategorieService(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<SousCategorie> getAll()
        {
            return appDbContext.sscats.
                Include(c=>c.categorie)
                .ToList();
        }
    }
}
