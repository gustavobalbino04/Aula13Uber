namespace Aula13Uber
{
    public class Passageiro
    { 
         /// <summary>
         /// procurar
         /// </summary>
         /// <returns>procurar motorista </returns>
         public string ProcurarMotorista(){
            return "Procurando motoristas disponíveis...";
        }
        /// <summary>
        /// pagar
        /// </summary>
        /// <param name="statusCorrida"></param>
        /// <returns> pagamento da corrida</returns>
        public string Pagar(string statusCorrida){

            if(statusCorrida == "Finalizada"){
                return "Pagamento efetuado";
            }

            return "Pagamento pendente pois a corrida não foi finalizada";
        }
    }
}