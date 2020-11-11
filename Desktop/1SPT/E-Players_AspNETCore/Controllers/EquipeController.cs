using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using E_Players_AspNETCore.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace E_Players_AspNETCore.Controllers
{
    public class EquipeController : Controller
    {
        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            ViewBag.Equipes = equipeModel.ReadAll();
            return View();
        }

        /// <summary>
        /// Vai cadastrar as equipes no programa e no CSV
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();
            novaEquipe.IdEquipe = Int32.Parse(form["IdEquipe"]);
            novaEquipe.Nome = form["Nome"];

            // Upload início
            var file = form.Files[0];
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

            if(file != null)
            {
                if(!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
 
                var path = Path.Combine(Directory.GetCurrentDirectory(), folder, file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;
            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }

            // Upload final
            equipeModel.Create(novaEquipe);

            ViewBag.Equipes = equipeModel.ReadAll();
            return LocalRedirect("~/Equipe");
        }

        [Route("{id}")]

        public IActionResult Excluir(int id)
        {
            equipeModel.Delete(id);
            return LocalRedirect("~/Equipe");
        }

    }
}
