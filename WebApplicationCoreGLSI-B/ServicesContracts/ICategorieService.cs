using WebApplicationCoreGLSI_B.Models;

namespace WebApplicationCoreGLSI_B.ServicesContracts
{
    public interface ICategorieService
    {
        Task<ICollection<Categorie>> GetAll();
        Categorie Edit(int id);
    }
}
