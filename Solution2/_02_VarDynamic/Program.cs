using System;

namespace _02_VarDynamic
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            object t1 = "";
            object t2 = 123456;
            //GENERICO MAS NÃO TEM COMO ACESSAR PROPRIEDADES ESPECIFICAS SEM FAZER CASTING
            
            var v1 = "";
            var v2 = 123456;
            //RECEBE APENAS O TIPO DO DADO COM O DADO
            //ERRO: var v3;
            //ERRO: v2 = ""; //atribuir a um var de um determinado tipo um valor diferente

            //RunTime em tempo de execução
            //TOTALMENTE ABERTO E DINAMICO PODENDO ACESSAR PROPRIEDADES QUE EXISTAM OU NÃO 
            dynamic d1 = new Usuario {Nome = "Maria"};
            Console.WriteLine(d1.Nome);
            
            

        }
    }
}