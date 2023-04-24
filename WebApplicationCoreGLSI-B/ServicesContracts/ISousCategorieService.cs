using WebApplicationCoreGLSI_B.Models;

namespace WebApplicationCoreGLSI_B.ServicesContracts
{
    public interface ISousCategorieService
    {
        IEnumerable<SousCategorie> getAll();
    }
}
