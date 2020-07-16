using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using E_Players_AspNETCore.Models;
using Microsoft.AspNetCore.Http;

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
            novaNoticia.Imagem = form["Imagem"];
            novaNoticia.Texto = form["Texto"];

            noticiaModel.Create(novaNoticia);

            ViewBag.Noticia = noticiaModel.ReadAll();
            return LocalRedirect("~/Noticias");
        }

    }
}
