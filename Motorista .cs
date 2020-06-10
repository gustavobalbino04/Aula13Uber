namespace Aula13Uber
{
    public class Motorista 
    {
        private string carro { get; set; }

        private string placa { get; set; }

        public string  AceitarPassageiro( string nome){
            return $"O nome do seu passageiro é :{nome}"
        }

        public string ReceberPaganto(string statusCorrida){

            if(statusCorrida == "Finalizada"){
                return "Pagamento efetuado";
            }

            return "Pagamento pendente pois a corrida não foi finalizada";
        }



    }
}