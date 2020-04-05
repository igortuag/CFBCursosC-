using System;
class Aula23{
    static void Main(){
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};

        Random random = new Random();
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i]=random.Next(50);
        }

        foreach (var numero in vetor1)
        {
            System.Console.WriteLine(numero);
        }

        //public static int BinarySearch(array, valor);
        System.Console.WriteLine("BinarySearch");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1, procurado);
        System.Console.WriteLine("O valor {0} está na posição {1}",procurado,pos);
        System.Console.WriteLine("----------------------------------------------");

        //public static void Copy(Ar_origem, Ar_destino, qtde_elementos);
        System.Console.WriteLine("Copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach (var n in vetor2)
        {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine("----------------------------------------------");

        //public void CopyTo(Ar_destino, a_partir_desta_pos)
        System.Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3, 0);
        foreach (int n in vetor3){
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine("----------------------------------------------");
        
        //public long GetLongLenght(dimensão)
        System.Console.WriteLine("GetLongLength");
        long qtdElementosVetor = vetor1.GetLength(0);
        System.Console.WriteLine("Quantidade de elemetos {0}", qtdElementosVetor);
        System.Console.WriteLine("----------------------------------------------");

        //public int GetLowerBound(dimensão)
        System.Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        System.Console.WriteLine("Menor Índice do vetor1: {0}", MenorIndiceVetor);
        System.Console.WriteLine("Menor Índice da Matriz: {0}", MenorIndiceMatriz_D1);
        System.Console.WriteLine("----------------------------------------------");

        //public int GetUpperBound(dimensão)
        System.Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1 = matriz.GetUpperBound(1);
        System.Console.WriteLine("Maior Índice do vetor1: {0}", MaiorIndiceVetor);
        System.Console.WriteLine("Maior Índice da Matriz: {0}", MaiorIndiceMatriz_D1);
        System.Console.WriteLine("----------------------------------------------");

        //public object GetValue(long índice);
        System.Console.WriteLine("GetValue");
        int valor0=Convert.ToInt32(vetor1.GetValue(3));
        int valor1=Convert.ToInt32(matriz.GetValue(1, 3));
        System.Console.WriteLine("Valor da posição 3 do vetor1: {0}",valor0);
        System.Console.WriteLine("----------------------------------------------");

        //public static int IndexOf(array, valor);
        System.Console.WriteLine("IndexOf");
        int indice1=Array.IndexOf(vetor1, 3);
        System.Console.WriteLine("Indice do primeiro valor 3:{0}", indice1);        
        System.Console.WriteLine("----------------------------------------------");

        //public static int LastIndexOf(array, valor);
        System.Console.WriteLine("LastIndexOf");
        int indice2=Array.LastIndexOf(vetor1, 3);
        System.Console.WriteLine("Indice do ultimo valor 3:{0}", indice1);        
        System.Console.WriteLine("----------------------------------------------");

        //public static void Reverse(arry);
        Array.Reverse(vetor1);
        foreach (var n in vetor1)
        {
            Console.WriteLine(n);
        }

        //public void SetValue(Object valor, long pos);
        vetor2.SetValue(99,0);
        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2.SetValue(0, i);
        }
        System.Console.WriteLine("Vetor 2");
        foreach (var n in vetor2)
        {
            System.Console.WriteLine(n);
        }

        //public static void Sort(Array);
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        System.Console.WriteLine("Vetor 1");
        foreach (var n in vetor1)
        {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine("\nVetor 2");
        foreach (var n in vetor2)
        {
            System.Console.WriteLine(n);
        }
        System.Console.WriteLine("\nVetor 3");
        foreach (var n in vetor3)
        {
            System.Console.WriteLine(n);
        }

    }
}