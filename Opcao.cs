namespace Aula10_Sprint4_Polimorfismo_Pt2
{
    public class Opcao : Relatorio 
    {
        public string resposta { get; set; }
        Relatorio relatorio = new Relatorio();
        Mensal relatorioMes = new Mensal();
        Ano relatorioAno = new Ano();
        public void Selecionar(){

            switch(resposta){
                case "1":

                relatorioMes.MostrarRelatorio();
                break;

                case "2":

                relatorioAno.MostrarRelatorio();
                break;

            }


        }
    }
}