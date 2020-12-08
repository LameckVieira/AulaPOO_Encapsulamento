using System;
using classes;

namespace AulaPOO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Mastercard m = new Mastercard();
            
            m.Parcelas = 12;
            m.Bandeira = "visa";

            Console.WriteLine(m.Bandeira);
        }
    }
}
