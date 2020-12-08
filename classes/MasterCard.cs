namespace classes
{
    public class Mastercard : Cartao
    {
        //atributos
        private int parcelas;

        //get e set
        public int Parcelas{
            get{ return parcelas;} // pagar dados
            set{ parcelas = value;} // inserir dados
        }

        //Método
        public string CompraComDesconto(){

            return "";
        }
        // public static VisualizarParcelas(string senha){

        // }

        
    }
}