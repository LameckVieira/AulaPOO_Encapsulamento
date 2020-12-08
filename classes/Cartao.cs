namespace classes
{
    public class Cartao
    {
        private string numero;
        public string Numero{
            get{ return Numero;}
            set{ numero = value;}
        private string bandeira = "MarterCard";

        public string Bandeira{
            get{ return bandeira;}
            
        }
        private string token = "qwertyui";

        public string Token{
            get{ return Token;}
            
        }
        private string cvv;

        public string Cvv{
            get{ return cvv;}
            set{ cvv = value;}
        }
        protected float limite = 5000;


        // declaração dos metodos

        public string RegistrarCompra( bool validado){

            return "";
        }

        private bool ValidarCompra(float saldo){
            
            return true;
        }

        protected string ValidarToken(string token){
            return "";
        }

    }
}