using System;

namespace Aula31WatsAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda   = new Agenda();
            Contato amanda  = new Contato("Amanda", "(11) 95555-5555");
            Contato jessica = new Contato("Jéssica", "(11) 95555-5555");
            Contato maria   = new Contato("Maria", "(11) 95555-5555");
            Contato jonas   = new Contato("Jonas", "(11) 95555-5555");

            agenda.Cadastrar(amanda);
            agenda.Cadastrar(jessica);
            agenda.Cadastrar(maria);
            //agenda.Excluir(jonas);

            foreach(Contato item in agenda.Listar())
            {
                Console.WriteLine($"Nome: {item.Nome} - Tel: {item.Telefone}");
            }

            Mensagem txt = new Mensagem();
            txt.Destinatario = jonas;
            txt.Texto = "Boa tarde"+ jonas.Nome+"!";
            Console.WriteLine(txt.Enviar());

        }
    }
}
