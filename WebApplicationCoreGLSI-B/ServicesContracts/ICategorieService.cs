using WebApplicationCoreGLSI_B.Models;

namespace WebApplicationCoreGLSI_B.ServicesContracts
{
    public interface ICategorieService
    {
        //Signature de la méthode permettant de récupérer la liste de catégories
        Task<ICollection<Categorie>> GetAll();
        Task<Categorie> Create(Categorie c);
        Categorie Edit(int Id, Categorie c);
        void Delete(int Id);
    }
}
