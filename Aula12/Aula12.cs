using System;
class Aula12{
    static void Main(){
        string nome;
        int idade;

        System.Console.WriteLine("Qual seu nome?");
        nome = Console.ReadLine();
        System.Console.WriteLine("Quantos anos você tem?");
        idade = int.Parse(Console.ReadLine());
        
        if (idade <= 18){
            System.Console.WriteLine("Olá {0}, você tem {1} anos, então você é menor de idade",nome, idade);
        }else{
            System.Console.WriteLine("Olá {0}, você tem {1} anos, então você é maior de idade",nome, idade);
        }
    }
}