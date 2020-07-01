using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula27_28_29_30
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/produto.csv";

        public Produto(){
            //Cria pasta caso ñ exista
            string pasta = PATH.Split('/')[0];

            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            //Cria o arquivo caso ñ exista
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        
        public void Inserir(Produto prod){
            var linha = new string [] { prod.PrepararLinhaCSV(prod) };
            File.AppendAllLines(PATH, linha);
        }

        public List<Produto> Ler()
        {
            //Lista para guardar o retorno do método
            List<Produto> prod = new List<Produto>();
            
            //Serve para ler as linhas na pasta
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string linha in linhas)
            {
                //Quebra as linhas em
                string[] dado = linha.Split( ";" );

                Produto p = new Produto();
                p.Codigo = Int32.Parse( Separar(dado[0]) );
                p.Nome   = Separar(dado[1]);
                p.Preco  = float.Parse( Separar(dado[2]) );

                p.Inserir(p);
            }

            prod = prod.OrderBy(z => z.Nome).ToList();

            return prod;
        }

        public void Remover(string _termo){

            List<string> linhas = new List<string>();

            using(StreamReader arquivo = new StreamReader(PATH)){
                string linha;
                while((linha = arquivo.ReadLine())!= null)
                {
                    linhas.Add(linha);
                }
                linhas.RemoveAll(z => z.Contains(_termo));
            }

            using(StreamWriter output = new StreamWriter(PATH))
            {
                output.Write(String.Join(Environment.NewLine, linhas.ToArray()));
            }
        }

        /// <summary>
        /// Método que separa o símbolo de = da string csv
        /// </summary>
        /// <param name="dado">Coluna do csv separada</param>
        /// <returns>string somente com o valor da coluna</returns>

        public string Separar(string dado)
        {
            return dado.Split("=")[1];
        }

        private string PrepararLinhaCSV(Produto p){
            return $"codigo={p.Codigo};nome={p.Nome};preco={p.Preco}";
        }  
    }
}