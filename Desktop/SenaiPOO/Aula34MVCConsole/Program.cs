﻿using System;
using Aula34MVCConsole.Controllers;

namespace Aula34MVCConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.Listar();
            //prod.Buscar("400");
        }
    }
}
