using Academico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Academico.Controllers
{
    public class AlunoController : Controller
    {
        private static List<Aluno> _alunos = new List<Aluno>();
        public IActionResult Index()
        {
            return View(_alunos);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    aluno.AlunoId = _alunos.Select(a => a.AlunoId).DefaultIfEmpty(0).Max() + 1;
                    _alunos.Add(aluno);
                    return RedirectToAction("Index");
                }
                return View(aluno);
            }
            catch
            {
                return View(aluno);
            }
        }

    }
}
