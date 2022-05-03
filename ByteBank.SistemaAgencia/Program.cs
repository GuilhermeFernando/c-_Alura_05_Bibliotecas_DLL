using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 41236);
            Console.WriteLine(conta.Numero);
            Console.ReadLine();
        }
    }
}
