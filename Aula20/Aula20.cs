using System;
class Aula20{
    static void Main(){
        int[] num = new int[5];
        int i = 0;
        while (i<num.Length)
        {
            num[i] = 1;
            System.Console.Write(num[i] + ", ");
            i++;
        }
        System.Console.WriteLine("fim!");
    }
}