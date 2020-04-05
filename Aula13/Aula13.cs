using System;
class Aula13{
    static void Main(){
        string nome, resultado;
        int idade;

        System.Console.WriteLine("Qual seu nome?");
        nome = Console.ReadLine();
        System.Console.WriteLine("Quantos anos você tem?");
        idade = int.Parse(Console.ReadLine());
        
        if (idade < 12){
            resultado = "uma criança";
        }else if(idade < 21){
            resultado = "um adolescente";
        }else if(idade <30){
            resultado = "um jovem";
        }else if(idade <65){
            resultado = "um adulto";
        }else{
            resultado = "um idoso";
        }
        
            System.Console.WriteLine("Olá {0}, você tem {1} anos, então você é {2}",nome, idade, resultado);
    }
}