using System;

namespace RelatoriosPOO
{
    public class Mensal : Relatorio
    {
        public override void MostrarRelatorio(){
            base.MostrarRelatorio();
            Console.WriteLine("Mostrando relatório por mês.");
        }
    }
}