using System;

namespace Aula10_Sprint4_Polimorfismo_Pt2
{
    public class Relatorio
    {
        public DateTime data { get; set; }
        
        public virtual void MostrarRelatorio(){
            System.Console.WriteLine("Mostrando o relatório geral");
        }


    }
}