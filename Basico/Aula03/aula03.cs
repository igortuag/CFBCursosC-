using System;
class Aula03{
    static void Main(){
        byte n1=10; // 0 a 255
        int num1 = 2; 
        int num2 = 3;
        int soma;
        char letra = 'c';
        float valor = 5.3f;
        soma = num1 + num2;
        System.Console.WriteLine(soma);
        String nome = "Igor";

        var aux=nome; // Operador var permite não especificar o tipo na declaração, irá ser determinado na hora da atribuição.
        System.Console.WriteLine("Olá " +aux);
    }
}