using System;

namespace RelatoriosPOO
{
    public class Anual : Relatorio
    {
        public override void MostrarRelatorio(){
            base.MostrarRelatorio();
            Console.WriteLine("Mostrando relatório anual.");
        }
    }
}