using System;
using System.Collections.Generic;

namespace Lista1Ex2.CompletarLista
{
    public class Completar
    {
        public static List<int> Fibonachi(int tamanho)
        {
            List<int> aux = new List<int>();

            aux.Add(1);
            aux.Add(1);

            for (int i = 2; i < tamanho; i++)
            {
                aux.Add(aux[i-2]+aux[i-1]);
            }
            return aux;
        }

        public static List<int> Sequencial(int tamanho)
        {
            List<int> aux = new List<int>();

            for (int i = 0; i < tamanho; i++)
            {
                aux.Add(i+1);
            }

            return aux;
        }
    }
}