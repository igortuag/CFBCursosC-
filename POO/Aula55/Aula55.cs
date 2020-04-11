using System;
using System.Collections.Generic;
class Aula55{
    static void Main(){
        Dictionary <int, string> veiculos = new Dictionary <int, string>();

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");

        //veiculos.Clear();
        System.Console.WriteLine("Tamanho do Dictionary: {0}",veiculos.Count);

        veiculos.Remove(20);
        int chave = 20;
        if(veiculos.ContainsKey(chave)){
            System.Console.WriteLine("A chave {0} esta na coleção",chave);
        }else{
            System.Console.WriteLine("A chave {0} não esta na coleção",chave);
        }

        veiculos[15] = "Bicicleta";

        string valor = "Bicicleta";
        if(veiculos.ContainsValue("Navio")){
            System.Console.WriteLine("A valor {0} esta na coleção",valor);
        }else{
            System.Console.WriteLine("A valor {0} não esta na coleção",valor);
        }

        foreach (KeyValuePair<int, string> v in veiculos)
        {
            System.Console.WriteLine(v.Key);
        }

        Dictionary<int, string>.ValueCollection valores = veiculos.Values;

        foreach (string v in valores)
        {
            System.Console.WriteLine(v);
        }


    }
}