namespace Aula13Uber
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string login = "ana@hotmail.com";
        public string senha = "Brigitte04";
        public string Foto { get; set; }
        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }

        public bool Login(string login, string senha){
        if(this.login == login && this.senha == senha){

            TokenLogin = "hgfdsff4324s6gdhtyy576";
                return true;
            }

            return false;
        }

        public void Logout(){
            TokenLogin = "";
        }
    }
}