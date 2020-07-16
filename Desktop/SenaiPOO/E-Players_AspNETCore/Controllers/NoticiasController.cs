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
    public class NoticiasController : Controller
    {
        Noticias noticiaModel = new Noticias();

        public IActionResult Index()
        {
            ViewBag.Noticia = noticiaModel.ReadAll();
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            Noticias novaNoticia = new Noticias();
            novaNoticia.IdNoticia = Int32.Parse(form["IdEquipe"]);
            novaNoticia.Titulo = form["Titulo"];

            // Início do upload
            var file = form.Files[0];
            var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Noticias");

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

                novaNoticia.Imagem = file.FileName;
            }
            else
            {
                novaNoticia.Imagem = "padrao.png";
            }

            novaNoticia.Texto = form["Texto"];

            noticiaModel.Create(novaNoticia);

            ViewBag.Noticia = noticiaModel.ReadAll();
            return LocalRedirect("~/Noticias");
        }

        public IActionResult Excluir(int id)
        {
            noticiaModel.Delete(id);
            return LocalRedirect("~/Noticias");
        }

    }
}
