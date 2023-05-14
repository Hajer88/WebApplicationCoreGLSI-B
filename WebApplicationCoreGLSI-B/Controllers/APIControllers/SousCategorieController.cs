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
        [HttpGet]
        [Route("{name}")]
        public IActionResult GetssCatByName(string name)
        {
            var c = _service.getByCatName(name);
            return Ok(c);
        }
        [HttpGet]
        [Route("/api/getOrderBy")]
        public IActionResult GetssCatOrdered()
        {
            var x = _service.getAllssCatOrderBy();
            return Ok(x);
        }
    }
}
