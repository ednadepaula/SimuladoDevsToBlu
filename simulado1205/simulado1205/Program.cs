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


            //3 - Ordenar uma lista de números sem utilizar os métodos da linguagem.
            //Crie um programa em C# que recebe uma lista de números inteiros e ordena essa lista em ordem crescente.
            //Exiba a lista ordenada na tela.

            List<int> listaDeNumeros = new List<int>();
            List<int> listaOrdenada = new List<int>();

            Console.WriteLine("Digite uma sequencia de numeros:");
            Console.WriteLine("A - Digite o numero");
            Console.WriteLine("B - finalizar");
            char op = char.Parse(Console.ReadLine());

            while (op != 'B')
            {
                Console.WriteLine("Digite o numero");
                int numero = int.Parse(Console.ReadLine());
                listaDeNumeros.Add(numero);
            }


            Console.ReadKey();




        }
    }
}
