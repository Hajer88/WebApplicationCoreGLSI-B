using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCoreGLSI_B.ServicesContracts;

namespace WebApplicationCoreGLSI_B.Controllers.APIControllers
{
    
    public class SousCategorieController : CustomController
    {
        private readonly ISousCategorieService _service;
        public SousCategorieController(ISousCategorieService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetAllssCat()
        {
            var c = _service.getAll();
            return Ok(c);
        }
    }
}
