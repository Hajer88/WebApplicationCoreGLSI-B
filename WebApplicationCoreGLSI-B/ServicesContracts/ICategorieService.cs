using WebApplicationCoreGLSI_B.Models;
using WebApplicationCoreGLSI_B.Models.DTO;

namespace WebApplicationCoreGLSI_B.ServicesContracts
{
    public interface ICategorieService
    {
        //Signature de la méthode permettant de récupérer la liste de catégories
        Task<ICollection<CategorieDTO>> GetAll();
        Task<CategorieDTO> Create(CategorieDTO c);
        CategorieDTO Edit(int Id, CategorieDTO c);
        void Delete(int Id);
    }
}
