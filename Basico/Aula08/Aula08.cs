using System;
class Aula08{
    static void Main(){
        int v1, v2, soma;
        string nome;

        System.Console.WriteLine("Digite o seu nome: ");
        nome = Console.ReadLine();

        System.Console.Write("Valor 01: ");
        v1 = int.Parse(Console.ReadLine());

        System.Console.Write("Valor 02: ");
        v2 = int.Parse(Console.ReadLine());

        soma = v1 + v2;

        System.Console.WriteLine("Olá {0}, a soma entre {1} e {2} é igual a {3}",nome,v1,v2,soma);

        System.Console.WriteLine("Final do programa");
    }
}