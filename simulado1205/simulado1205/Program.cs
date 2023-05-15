using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulado1205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Escreva um programa que implemente o jogo da forca. O programa deve gerar uma palavra aleatória
            //para ser adivinhada pelo jogador, e permitir que o jogador insira uma letra por vez para tentar
            //adivinhar a palavra. O programa deve exibir a palavra com os espaços em branco para as letras não adivinhadas. 
            //Obs: O codigo(program.cs) deve ser upado no github, e a resposta ser o link do repositório.Caso não consiga,
            //inserir o program.cs na entrega da atividade pelo classroom

            // NÃO CONSEGUI FAZER

            char[] forca = new char[5] { 'F', 'O', 'R','C','A'};
            char[] palavraJogador = new char[forca.Length];
            Console.WriteLine("**********************--JOGO DA FORCA--******************************");
            Console.WriteLine($"A palavra possui {forca.Length} letras");

            for(int i = 0; i < forca.Length; i++) 
            {
                while(i < forca.Length)
                {
                    Console.WriteLine("Digite uma letra:");
                    palavraJogador[i] = char.ToUpper(char.Parse(Console.ReadLine()));
                    if (palavraJogador[i] == forca[i])
                    {
                        Console.WriteLine("letra correta!");
                    }
                    else
                    {
                        Console.WriteLine("letra incorreta");
                        palavraJogador[i] = ' ';
                    }   
                    i++;
                }
                Console.WriteLine("\nJogo finalizado!\n");
                Console.Write("\nPalavra correta: ");
                for(i = 0; i < forca.Length; i++)
                {
                    Console.Write(" " + forca[i]);
                }

                Console.Write("\nPalavra digitada: ");
                for (i = 0; i < forca.Length; i++)
                {
                    Console.Write(" " + palavraJogador[i]);
                }

            }
            








            /*******************************************************************************************************/

            //2 - Crie um programa em C# que recebe uma string e verifica se ela é um palíndromo, ou seja,
            //se pode ser lida da mesma forma tanto da esquerda para a direita quanto da direita para a esquerda.
            //Desconsidere espaços em branco e letras maiúsculas ou minúsculas. Se a string for um palíndromo,
            //exiba a mensagem "A string X é um palíndromo"; caso contrário, exiba a mensagem "A string X não é um
            //palíndromo", em que X é a string recebida como entrada.

            /*bool palindrome = false;
            Console.WriteLine("Digite uma palavra: ");
            string stringRecebida = Console.ReadLine();
            char[] charRecebida = stringRecebida.ToCharArray();
            
            

            char[] stringInversa = new char[stringRecebida.Length];

            for(int i = 0;i < charRecebida.Length; i++)
            {
                stringInversa[((charRecebida.Length - 1)-i)] = charRecebida[i];
            }

            for (int i = 0; i < charRecebida.Length; i++)
            {
                if (stringInversa[i] != charRecebida[i])
                {
                    palindrome = false;
                    break;
                }
                else
                {
                    palindrome = true;
                }
            }
            if (palindrome)
            {
                Console.WriteLine($"A string {stringRecebida} é um palíndromo");
            }
            else
            {
                Console.WriteLine($"A string {stringRecebida} não é um palíndromo");
            }*/


            /*******************************************************************************************************/

            //3 - Ordenar uma lista de números sem utilizar os métodos da linguagem.
            //Crie um programa em C# que recebe uma lista de números inteiros e ordena essa lista em ordem crescente.
            //Exiba a lista ordenada na tela.

            /*List<int> listaDeNumeros = new List<int>();
            List<int> listaOrdenada = new List<int>();
            int minimo;

            Console.WriteLine("Digite uma sequencia de numeros:");
            char op;

            do
            {
                Console.WriteLine("A - Digitar o numero");
                Console.WriteLine("B - finalizar");
                op = char.ToUpper(char.Parse(Console.ReadLine()));

                if (op == 'A')
                {
                    Console.WriteLine("Digite o numero");
                    int numero = int.Parse(Console.ReadLine());
                    listaDeNumeros.Add(numero);
                }
                                

            } while (op != 'B');

            int tamanhoLista = listaDeNumeros.Count;
            
            for (int i = 0; i <= tamanhoLista; i++)
            {
                minimo = listaDeNumeros.Min();
                listaOrdenada.Add(minimo);
                listaOrdenada[i] = minimo;
                listaDeNumeros.Remove(minimo);

                Console.WriteLine("\n lista ordenada");
                foreach (int n in listaOrdenada)
                    {
                        Console.WriteLine(n);
                    }
            }*/


            Console.ReadKey();




        }
    }
}
