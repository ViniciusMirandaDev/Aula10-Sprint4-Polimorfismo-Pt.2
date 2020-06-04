namespace Aula10_Sprint4_Polimorfismo_Pt2
{
    public class Mensal : Relatorio
    {
        public override void MostrarRelatorio(){
            base.MostrarRelatorio();
            System.Console.WriteLine("Mostrando o relatório para o mês");
        }
    }
}