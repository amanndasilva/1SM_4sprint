using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula31WatsAppConsole
{
    public class Agenda : IAgenda
    {
        List<Contato> contatos = new List<Contato>();
        private const string PATH = "Database/agenda.csv";

        public Agenda(){
            // Cria pasta
            string pasta = PATH.Split('/')[0];

            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            // Cria o arquivo
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public void Cadastrar(Contato cont)
        {
            string[] linha = {PrepararLinhaCSV(cont)};
            File.AppendAllLines(PATH, linha);
        }

        public void Excluir(Contato contato)
        {
            
            List<string> linhas = new List<string>();

            using(StreamReader arquivo = new StreamReader(PATH))
            {
                string linha;
                while((linha = arquivo.ReadLine())!= null)
                {
                    linhas.Add(linha);
                }

                linhas.RemoveAll(x => x.Contains(contato.Nome));
            }
            ReescreverCSV(linhas);
        }

        public List<Contato> Listar()
        {
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string linha in linhas)
            {
                string[] dado = linha.Split( ";" );
                contatos.Add(new Contato(dado[0], dado[1]));
            }

            contatos = contatos.OrderBy(z => z.Nome).ToList();

            return contatos;
        }

        private string PrepararLinhaCSV(Contato c){
            return $"{c.Nome};{c.Telefone}";
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
    }
}