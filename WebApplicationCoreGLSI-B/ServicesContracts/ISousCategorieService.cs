using WebApplicationCoreGLSI_B.Models;

namespace WebApplicationCoreGLSI_B.ServicesContracts
{
    public interface ISousCategorieService
    {
        IEnumerable<SousCategorie> getAll();
        //Get All sousCat associés à une catégorie
        IEnumerable<SousCategorie> getByCatName(string name);
        //Get all SousCat Ordered
        IEnumerable<SousCategorie> getAllssCatOrderBy();
        IEnumerable<SousCategorie> getById(int id);
    }
}
