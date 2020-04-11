using System;
using System.Collections.Generic;
class Aula58{
    static void Main(){

        List<string> carros = new List<string>();
        List<string> carros2 = new List<string>();
        string[] carros3 = new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        carros2.AddRange(carros);
        //carros.Clear();

        if (carros.Contains("Gol")){
            System.Console.WriteLine("Esta na lista");
        }else{
            System.Console.WriteLine("Não esta na lista");
        }
        if (carros.Contains("Golf")){
            System.Console.WriteLine("Esta na lista");
        }else{
            System.Console.WriteLine("Não esta na lista");
        }

        System.Console.WriteLine("\nLista de carros");
        foreach (var carro in carros)
        {
            System.Console.WriteLine(carro);
        }
        carros2.Reverse();
        System.Console.WriteLine("\nLista de carros 2");
        foreach (var carro in carros2)
        {
            System.Console.WriteLine(carro);
        }

        carros.CopyTo(carros3, 2);

        System.Console.WriteLine("\nLista de carros 3");
        foreach (var carro in carros3)
        {
            System.Console.WriteLine("Carro: {0}",carro);
        }

        System.Console.WriteLine(carros.IndexOf("HRV"));

        carros.Insert(3, "Gol");
        carros.Remove("Argo");
        carros.Remove("HRV");
        carros.RemoveAt(0);
        System.Console.WriteLine("\nLista de carros");
        foreach (var carro in carros)
        {
            System.Console.WriteLine(carro);
        }

        System.Console.WriteLine(carros.Capacity);
        System.Console.WriteLine(carros.Count);

    }
}