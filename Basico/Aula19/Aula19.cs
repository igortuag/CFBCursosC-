using System;
class Aula19{
    static void Main(){
        int[] num = new int[5];

        for(int i = 1; i < num.Length; i++){
            num[i] = 0;
        }
        for (int i = 0; i < num.Length; i++)
        {
            System.Console.WriteLine("O valor de num na posição {0} é {1}",i,num[i]);
        }
        System.Console.WriteLine("fim!");
    }
}