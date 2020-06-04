using System;

namespace Aula10_Sprint4_Polimorfismo_Pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Opcao selecionar = new Opcao();

            

            System.Console.WriteLine("Deseja ver o relatório mensal ou anual? \n Digite 1 para mensal \n Digite 2 para anual ");
            
            selecionar.resposta=Console.ReadLine();
            selecionar.Selecionar();
            
            
        }
    }
}
