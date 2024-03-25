using ArqTech.Data;
using ArqTech.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArqTech.Controllers
{
    public class CadastroController : Controller
    {
        readonly private ApplicationDbContext _db;

        public CadastroController(ApplicationDbContext db) 
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<CadastroModel> cadastro = _db.Cargo;
            return View();
        }
    }
}
