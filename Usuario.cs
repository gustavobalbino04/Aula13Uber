namespace Aula13Uber
{
    public class Usuario
    {
        public string Nome = "guustavo"; 
        private string login = "gustavo@gmail.com";
        private string senha = "123456789";
        public string Foto { get; set; }
        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }
        
        /// <summary>
        /// login
        /// </summary>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <returns>logar</returns>
        public bool Login(string login, string senha){
            
            if(this.login == login && this.senha == senha){
                TokenLogin = "qweqweqweqweqwewqe1231231231231232";
                return true;
            }

            return false;
        }

        public void Logout(){
            TokenLogin = "";
        }
    }
}