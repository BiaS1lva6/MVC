using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Beatriz silva", "beatriz080407@gmail.com", 123456);
            Aluno a2 = new Aluno(2, "Livia solla", "livia.linda@gmail.com", 987543);
            Aluno a3 = new Aluno(3, "Ana julia", "anageremiias@gmail.com", 976564);
            Aluno a4 = new Aluno(4, "Ana Clara", "ana.chiaramonte@gmail.com", 888888);
            Aluno a5 = new Aluno(5, "Flaviana", "flaviana16nasc@gmail.com", 645902);

            //Criar uma lista de alunos
            List<Aluno> listAlunos = new List<Aluno>();
            //Adicionar os objetos alunos na lista alunos 
            listAlunos.Add(a1);
            listAlunos.Add(a2);
            listAlunos.Add(a3);
            listAlunos.Add(a4);
            listAlunos.Add(a5);

            // Enviando a lista de Alunos por parametro na View index
            return View(listAlunos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

    }
}
