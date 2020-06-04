namespace Aula10_Sprint4_Polimorfismo_Pt2
{
    public class Ano : Relatorio
    {
        public override void MostrarRelatorio(){
            base.MostrarRelatorio();
            System.Console.WriteLine("Mostrando relatório por ano");
        }
    }
}