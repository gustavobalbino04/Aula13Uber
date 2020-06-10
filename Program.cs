using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
           Usuario user = new Usuario();
           

            System.Console.WriteLine("Digite seu login: ");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite sua senha: ");
            string senha = Console.ReadLine();

            user.Login(login, senha);

            if(user.TokenLogin != "" && user.TokenLogin != null){

                Console.WriteLine("Acesso liberado! Usuário logado");
                System.Console.WriteLine(user.TokenLogin);

                Console.WriteLine("digite o /1 passageiro/2 motorista  ");
                int resposta  =Int32.Parse(Console.ReadLine());
                if(resposta == 1){
                    Console.WriteLine("Para solicitar um motorista digite seu local atual ");
                    string LocalInicial = Console.ReadLine();

                    Console.WriteLine("digite seu destino final  ");
                    string LocalFinal = Console.ReadLine();

                    Console.WriteLine("seu motorista é Cleyton,ele já esta te esperando ");


                    Console.WriteLine("Sua viagem foi concluida : 1-Sim/2-Nao ");
                    int resposta2  =Int32.Parse(Console.ReadLine());
                    if(resposta2 == 1){
                        Console.WriteLine("digite sua forma de pagamento 1-cartao 2-dinheiro");
                        int resposta3  =Int32.Parse(Console.ReadLine());
                        
                        
                        Console.WriteLine("Obrigado por viajar com nós ");

                    }else{
                        Console.WriteLine("o Correu um erro no sistema,já estamos verificando");
                    }



                    
                    

                }else{
                    Console.WriteLine("Localizando passageiro.... ");
                    Motorista cleyton = new Motorista();
                    System.Console.WriteLine( cleyton.AceitarPassageiro() );
                    Console.WriteLine("Sua viagem foi concluida : 1-Sim/2-Nao ");
                    int resposta2  =Int32.Parse(Console.ReadLine());
                    if(resposta2 == 1){
                        Console.WriteLine("Voce ja recebeu o pagamento 1-sim 2-nao");
                        int resposta3  =Int32.Parse(Console.ReadLine());

                        if(resposta3 == 1){

                        Console.WriteLine("Obrigado por estar com nos  ");
                        }else{
                            Console.WriteLine("o Correu um erro no sistema,já estamos verificando");
                        }

                    }else{
                        Console.WriteLine("o Correu um erro no sistema,já estamos verificando");

                }

                }


            }else{
                Console.WriteLine("Usuario deslogado");
            }
        }
    }
}
