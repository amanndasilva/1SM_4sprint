using System;
using System.Collections.Generic;
using System.IO;
using E_Players_AspNETCore.Interfaces;

namespace E_Players_AspNETCore.Models
{
    public class Equipe : EPalyersBase , IEquipe
    {
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        private const string PATH = "Database/equipe.csv";

        // Cria o arquivo Equipe na pasta Database
        public Equipe()
        {
            CreateFolderAndFile(PATH);
        }

        public void Create(Equipe e)
        {
            string[] linha = {PrepararLinha(e)};
            File.AppendAllLines(PATH, linha);
        }

        /// <summary>
        /// Prepara uma linha de Equipe no CSV
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private string PrepararLinha(Equipe e)
        {
            return $"{e.IdEquipe};{e.Nome};{e.Imagem}";
        }

        /// <summary>
        /// Lê todas as linhas da lista Equipe
        /// </summary>
        /// <returns></returns>
        public List<Equipe> ReadAll()
        {
            List<Equipe> equipes = new List<Equipe>();
            string[] linhas = File.ReadAllLines(PATH);
            foreach (var item in linhas)
            {
                string[] linha = item.Split(";");
                Equipe equipe = new Equipe();
                equipe.IdEquipe = Int32.Parse(linha[0]);
                equipe.Nome = linha[1];
                equipe.Imagem = linha[2];

                equipes.Add(equipe);
            }
            return equipes;
        }

        /// <summary>
        /// Altera uma linha na lista Equipe no CSV e reescreve
        /// </summary>
        /// <param name="e"></param>
        public void Update(Equipe e)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == e.IdEquipe.ToString());
            linhas.Add(PrepararLinha(e));
            RewriteCSV(PATH, linhas);
        }

        /// <summary>
        /// Deleta a linha na lista Equipe selecionada no CSV e a reescreve
        /// </summary>
        /// <param name="idEquipe"></param>
        public void Delete(int idEquipe)
        {
            List<string> linhas = ReadAllLinesCSV(PATH);
            linhas.RemoveAll(x => x.Split(";")[0] == idEquipe.ToString());

            RewriteCSV(PATH, linhas);
        }

    }
}