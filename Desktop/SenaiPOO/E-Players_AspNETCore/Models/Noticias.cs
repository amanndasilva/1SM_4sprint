using System;
using System.Collections.Generic;
using System.IO;
using E_Players_AspNETCore.Interfaces;

namespace E_Players_AspNETCore.Models
{
    public class Noticias : EPalyersBase , INoticias
    {
        public int IdNoticia { get; set; }
        public string Titulo { get; set; }
        public string Imagem { get; set; }
        public string Texto { get; set; }

        private const string PATH = "Database/noticias.csv";

        // Cria o arquivo Notícias na pasta Database
        public Noticias()
        {
            CreateFolderAndFile(PATH);
        }

        public void Create(Noticias n)
        {
            string[] linha = {PrepararLinha(n)};
            File.AppendAllLines(PATH, linha);
        }

        /// <summary>
        /// Prepara uma linha de Notícia no CSV
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private string PrepararLinha(Noticias n)
        {
            return $"{n.IdNoticia};{n.Titulo};{n.Imagem};{n.Texto}";
        }

        /// <summary>
        /// Lê todas as linhas da lista Notícias
        /// </summary>
        /// <returns></returns>
        public List<Noticias> ReadAll()
        {
            List<Noticias> noticias = new List<Noticias>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Noticias noticia = new Noticias();
                noticia.IdNoticia = Int32.Parse(linha[0]);
                noticia.Titulo = linha[1];
                noticia.Imagem = linha[2];
                noticia.Texto = linha[3];

                noticias.Add(noticia);
            }
            return noticias;
        }

        /// <summary>
        /// Altera uma linha na lista Notícias e reescreve
        /// </summary>
        /// <param name="n"></param>
        public void Update(Noticias n)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == n.IdNoticia.ToString());
            linhas.Add(PrepararLinha(n));
            RewriteCSV(PATH, linhas);
        }

        /// <summary>
        /// Deleta uma linha na lista Notícias selecionada no CSV e a resscreve
        /// </summary>
        /// <param name="idNoticias"></param>
        public void Delete(int idNoticias)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == idNoticias.ToString());

            RewriteCSV(PATH, linhas);
        }
    }
}
