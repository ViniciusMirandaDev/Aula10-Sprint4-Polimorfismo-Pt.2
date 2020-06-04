using System;

namespace Aula10_Sprint4_Polimorfismo_Pt2
{
    public class Relatorio
    {
        DateTime  data;
        
        public virtual void MostrarRelatorio(){
            System.Console.WriteLine("Mostrando o relatório geral");
        }
        

    }
}