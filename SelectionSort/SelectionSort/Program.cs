using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array de inteiros 
            int[] select = { 5, 9, 3, 2, 7, 8 };
            //Organizar array
            for (int i = 0; i < select.Length; i++)
            {
                int menorElemento = select[i];
                int menorIndice = i;
                for (int j = i + 1; j <select.Length; j++)
                { 
                    if (menorElemento > select[j])
                    {
                        menorElemento = select[j];
                        menorIndice = j;
                    }
                }

                int resultado = select[i];
                select[i] = menorElemento;
                select[menorIndice] = resultado;
            }
            Console.WriteLine("\t\t\t Organizado");
            foreach(int i in select)
            {
                Console.Write("\t" + i + " ");
            }
            Console.ReadKey();
        }
    }
}
