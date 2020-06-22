using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario u = new Usuario();
            System.Console.WriteLine("Digite seu login: ");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();

            u.Login(login, senha);

            if(u.TokenLogin != "" && u.TokenLogin != null){
                Console.WriteLine("Acesso liberado!");

            }else{
                System.Console.WriteLine("Acesso negado! Login ou senha incorretos.");
            }
        }
    }
}
