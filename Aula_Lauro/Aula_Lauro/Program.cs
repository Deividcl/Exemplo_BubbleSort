using System;
namespace Aula_Lauro
{
    class Program
    {
        static void bubbleSort(int[] num, int length)
        {
            int comp = 0;
            /*Irá percorrer o vetor, comparando cada elemento do vetor com o elemento 
             * imediatamente seguinte (arr[j] = arr[j + 1];) 
             * O numero maximo de execuções do trecho do algoritmo, p/ que o vetor fique ordenado é de N - 1, onde N é o numero de vezes.*/

            // i determina o número de etapas para a ordenação 
            for (int i = 0; i < length - 1; i++)
            {
                // j determina o numero de comparações, e os indices a serem pesquisados para a comparação. 
                for (int j = 0; j < length - (i + 1); j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        comp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = comp;
                    }
                }
            }
        }
            static void Main(string[] args)
        {
                int[] numbers = { 45, 81, 29, 66, 03, 52, 51, 55, 74 };
                Console.WriteLine("Exemplo Bubble Sort");
                bubbleSort(numbers, numbers.Length);
                for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);
                Console.ReadLine();        
        }
    }
}
