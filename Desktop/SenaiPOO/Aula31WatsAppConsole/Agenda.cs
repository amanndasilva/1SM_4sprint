using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aula31WatsAppConsole
{
    public class Agenda : IAgenda
    {
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

        public List<Contato> Ler()
        {
            //Lista para guardar o retorno do método
            List<Contato> cont = new List<Contato>();
            
            //Serve para ler as linhas na pasta
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string linha in linhas)
            {
                string[] dado = linha.Split( ";" );

                Contato c = new Contato();
                c.Nome = Separar(dado[1]);
                c.Telefone = Int32.Parse( Separar(dado[0]) );

                cont.Add(c);
            }

            cont = cont.OrderBy(z => z.Nome).ToList();

            return cont;
        }

        public string Separar(string dado)
        {
            return dado.Split("=")[1];
        }

        private string PrepararLinhaCSV(Contato c){
            return $"nome={c.Nome};numero={c.Telefone}";
        }
    }
}