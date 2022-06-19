using System;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime dataFimPagamento = new DateTime(2022, 3, 1);
            DateTime dataCorrente = DateTime.Now;

            TimeSpan diferença = TimeSpan.FromMinutes(60);//dataFimPagamento - dataCorrente;
            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferença);
            Console.WriteLine(mensagem);
            Console.WriteLine(dataCorrente);
            Console.WriteLine(dataFimPagamento);
            Console.ReadLine();
        }    
    }
}
