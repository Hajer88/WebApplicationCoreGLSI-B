using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationCoreGLSI_B.Models;
using WebApplicationCoreGLSI_B.Models.DTO;
using WebApplicationCoreGLSI_B.ServicesContracts;

namespace WebApplicationCoreGLSI_B.Services
{
    public class CategorieService : ICategorieService
    {
        private readonly AppDbContext _context;
        private readonly IMapper mapper;
        public CategorieService(AppDbContext context, IMapper  mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        public async Task<CategorieDTO> Create(CategorieDTO c)
        {
            var x = mapper.Map<CategorieDTO, Categorie>(c);
            _context.cats.Add(x);
            await _context.SaveChangesAsync();
            return c;
        }

        public void Delete(int Id)
        {
            var cat = _context.cats.Find(Id);
            var sscats = _context.sscats
                .Where(c => c.categorieId == Id)
                .ToList();
            foreach (var item in sscats)
            {
                _context.sscats.Remove(item);
                _context.SaveChanges();
            }
            _context.cats.Remove(cat);
            _context.SaveChanges();
        }

        public CategorieDTO Edit(int Id, CategorieDTO c)
        {
            var catInDb=  _context.cats.Find(Id);

            catInDb.Name = c.Name;
            _context.SaveChanges();
            return mapper.Map<Categorie,CategorieDTO>(catInDb);

        }

        public async Task<ICollection<CategorieDTO>> GetAll()
        {
            //Execution différée exécution de l'opérateur de projection Select
            //var t = from c in _context.cats
            //        select c
            //        ;
            //foreach(var item in t)
            //{
            //    //Affichage
            //}
            //var t1 = (from c in _context.cats
            //          select c)
            //        .ToList();

            //Exécution immédiate DotNotation Syntaxe
            //var x = _context.cats.ToList();
            //var cats2 = from c in _context.cats
                        
            //            select new CategorieDTO
            //            {
            //              c.Id=  ,
            //            };
            var cats= await _context.cats.ToListAsync();
            return mapper.Map<List<CategorieDTO>>(cats);

        }
    }
}
