namespace Aula13Uber {
    public class Motorista : Usuario
     {
         private string carro = "ford ka";
         private string placa = "DUds";
         /// <summary>
         /// Aceitar passageiro
         /// </summary>
         /// <returns>Aceitar o passageiro</returns>
         public string AceitarPassageiro(){
             return $"o nome do seu passageiro é:{Nome }";
         }
    }
}
