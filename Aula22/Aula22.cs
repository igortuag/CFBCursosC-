using System;
class Aula22{
    static void Main(){
        int [] num = new int[3]{11, 22, 33};
        int i = 0;

        foreach (var numero in num)
        {
            System.Console.WriteLine("O numero na posição {0} é {1}",i,numero);
            i++;
        }
    }
}