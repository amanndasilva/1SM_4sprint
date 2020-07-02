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
        
        public void Adicionar(Produto prod){
            string[] linha = new string [] { PrepararLinhaCSV(prod) };
            File.AppendAllLines(PATH, linha);
        }

        /// <summary>
        /// Lê o CSV
        /// </summary>
        /// <returns>Lista de produtos</returns>
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

                prod.Add(p);
            }

            prod = prod.OrderBy(z => z.Nome).ToList();

            return prod;
        }

        public List<Produto> Filtrar(string _nome){
            return Ler().FindAll(x => x.Nome == _nome);
        }

        public void Remover(string _termo){

            List<string> linhas = new List<string>();

            using(StreamReader arquivo = new StreamReader(PATH)){
                string linha;
                while((linha = arquivo.ReadLine())!= null)
                {
                    linhas.Add(linha);
                }
                //Remove as linhas com os argumentos antigos
                linhas.RemoveAll(z => z.Contains(_termo));
            }
            ReescreverCSV(linhas);
        }

        public void Alterar(Produto _produtoAlterado){
            //
            List<string> linhas = new List<string>();

            //
            using(StreamReader arquivo = new StreamReader(PATH)){
                string linha;
                while((linha = arquivo.ReadLine())!= null)
                {
                    linhas.Add(linha);
                }
            }
            // codigo=2;nome=Mondial;preco=550;
            linhas.RemoveAll(z=> z.Split(";")[0].Contains(_produtoAlterado.Codigo.ToString()));

            //Adicionams a linha alterada na lista de backup
            linhas.Add(PrepararLinhaCSV(_produtoAlterado));

            //Reescrevemos o csv do zero
            ReescreverCSV(linhas);
        }

        private void ReescreverCSV(List<string> lines){
            //Reescrevemos o csv do zero
            using(StreamWriter output = new StreamWriter(PATH))
            {
                foreach(string ln in lines)
                {
                    output.Write(ln+"\n");
                }
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

        //Prepara as linhas no csv
        private string PrepararLinhaCSV(Produto p){
            return $"codigo={p.Codigo};nome={p.Nome};preco={p.Preco}";
        }  
    }
}