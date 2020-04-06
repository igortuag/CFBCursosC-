using System;
class Aula26
{
    static void Main(){
        int num = 10;
        dobrar(ref num);
        System.Console.WriteLine(num);
    }

    static void dobrar(ref int valor){
        valor*=2;
    }
}