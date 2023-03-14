using Microsoft.AspNetCore.Mvc;
using WebApplicationCoreGLSI_B.Models;

namespace WebApplicationCoreGLSI_B.Controllers
{
    public class CategorieController : Controller
    {
        //CRUD pour categorie
        private readonly AppDbContext _context;
        public CategorieController(AppDbContext _context)
        {
            this._context = _context;

        }
        //Lister toutes les catégories
        public IActionResult Index()
        {
            var c = _context.cats.ToList();
            return View(c);
        }
    }
}
