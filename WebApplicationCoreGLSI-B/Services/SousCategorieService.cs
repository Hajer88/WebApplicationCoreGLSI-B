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

        public IEnumerable<SousCategorie> getByCatName(string name)
        {
            var sscatByName = appDbContext.sscats
                 .Where(c => c.categorie.Name == name)
                 .ToList();
            return sscatByName;
        }
        public IEnumerable<SousCategorie> getAllssCatOrderBy()
        {
            var testorderby = appDbContext.sscats.OrderByDescending(c =>
            c.Name)
                .ToList();
            return testorderby;

        }

        public IEnumerable<SousCategorie> getById(int id)
        {
            var sscat = appDbContext.sscats
                .Where(c => c.categorie.Id == id)
                .ToList();
            return sscat;
        }
    }
}
