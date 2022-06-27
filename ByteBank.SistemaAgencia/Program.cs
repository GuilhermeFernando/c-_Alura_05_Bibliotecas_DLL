using System;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();
           
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(11);
            listaDeIdades.Adicionar(41);
            listaDeIdades.Adicionar(22);
            listaDeIdades.Adicionar(55);
            listaDeIdades.AdicionarVarios(16, 15, 45);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }

        static void TestaListaDeContaCorrente()
        {

            ListaContaCorrente lista = new ListaContaCorrente();

            Object contaDoGui = new Object(874, 588710);
            lista.Adicionar(contaDoGui);
            lista.Adicionar(new Object(874, 58871));
            lista.Adicionar(new Object(874, 58872));

            Object[] contas = new Object[]
            {
                contaDoGui,
                new Object(874, 58871),
                new Object(874, 58872)

             };

            for (int i = 0; i < lista.Tamanho; i++)
            {
                Object itemAtual = lista.GetItemNoIndice(i);
                Console.WriteLine($"Item na posição {i} = conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }

            lista.Remover(contaDoGui);

            Console.WriteLine("Após remover o item");


            Console.ReadLine();

        }


        static void TestaContaArray()
        {
            Object[] contas = new Object[]
            {
                new Object(874, 58874),
                new Object(872, 5887112),
                new Object(872, 58871452)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                Object contaAtual = contas[indice];
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
