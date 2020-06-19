using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular samsung = new Celular();
            samsung.modelo = "Samsung Galaxy10";
            samsung.cor = "Branco";

            Console.WriteLine("Deseja ligar seu celular?");
            samsung.ligado = Boolean.Parse(Console.ReadLine());

            if(samsung.ligado){

                while(samsung.ligado == true){
                    Console.WriteLine("O que deseja fazer? \n1- Ligar \n2- Enviar mensagem \n3- Desligar");
                    int resposta = Int32.Parse(Console.ReadLine());

                    switch(resposta)
                    {
                        case 1:
                        Console.WriteLine(samsung.FazerLigacao());
                        break;

                        case 2:
                        Console.WriteLine(samsung.EnviarMensagem());
                        break;

                        case 3:
                        Console.WriteLine(samsung.Desligar());
                        break;

                        case 4:
                        Console.WriteLine(samsung.Ligar());
                        break;
                    }
                }
            } else
            {
                Console.WriteLine("O celular está desligado!");
            }
        }
    }
}
