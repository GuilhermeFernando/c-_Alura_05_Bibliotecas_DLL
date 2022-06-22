using System;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaContaCorrente lista = new ListaContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(874, 588710);
            /*lista.Adicionar(contaDoGui);
            lista.Adicionar(new ContaCorrente(874, 58871));
            lista.Adicionar(new ContaCorrente(874, 58872));
            lista.Adicionar(new ContaCorrente(874, 58873));
            lista.Adicionar(new ContaCorrente(874, 58874));
            lista.Adicionar(new ContaCorrente(874, 58875));
            lista.Adicionar(new ContaCorrente(874, 58876));
            lista.Adicionar(new ContaCorrente(874, 58877));
            lista.Adicionar(new ContaCorrente(874, 58878));
            lista.Adicionar(new ContaCorrente(874, 58879));*/

          for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista.GetItemNoIndice(i);
                Console.WriteLine($"Item na posição {i} = conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }

            lista.Remover(contaDoGui);

            Console.WriteLine("Após remover o item");


            Console.ReadLine();           
            
        }


        static void TestaContaArray()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 58874),
                new ContaCorrente(872, 5887112),
                new ContaCorrente(872, 58871452)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contas[indice].Numero}");
            }
            Console.ReadLine();
        }





        static void TestaArray()
        {
            int[] idades = new int[5];
            idades[0] = 4;
            idades[1] = 100;
            idades[2] = 45;
            idades[3] = 12;
            idades[4] = 22;

            int acumulador = 0;
            for (int indice = 0; indice <= 4; indice++)
            {
                int idade = idades[indice];
                Console.WriteLine($"Acessando o array idade no indice {indice}");
                Console.WriteLine($"Valor de idade [{indice}] = {idade}");
                acumulador += idade;
            }
            int media = acumulador / 5;
            Console.WriteLine($"Média de idades = {media}");
        }
    }
}
