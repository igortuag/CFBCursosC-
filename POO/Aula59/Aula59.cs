using System;
using System.Collections.Generic;
class Aula59{
    static void Main(){

        // string[] vs = {"Carro", "Moto", "Navio", "Avião"};
        Queue<string> veiculos = new Queue<string>();

        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Avião");
        veiculos.Enqueue("Navio");

        string v = "Avião";
        if(veiculos.Contains(v)){
            System.Console.WriteLine("Veiculo " + v + " encontrado!");
        }else{
            System.Console.WriteLine("Veiculo não encontrado");
        }
        // veiculos.Clear();
        // System.Console.WriteLine("Primeiro veiculo " + veiculos.Dequeue());
        // System.Console.WriteLine("Primeiro veiculo " + veiculos.Dequeue());
        // System.Console.WriteLine("Primeiro veiculo " + veiculos.Peek());
        // System.Console.WriteLine("Primeiro veiculo " + veiculos.Dequeue());
        // System.Console.WriteLine("Tabmanho fila: " + veiculos.Count);

        foreach (var item in veiculos)
        {
            System.Console.WriteLine("Veiculo {0} saindo!", item);
        }
    }
}