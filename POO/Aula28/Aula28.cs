using System;
class Aula28{
    public class Jogador{
        public int energia = 100;
        public bool vivo = true;

    }
    static void Main(){
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia = 50;

        System.Console.WriteLine("Energia do jogador 1: {0}",j1.energia);
        System.Console.WriteLine("Energia do jogador 2: {0}",j2.energia);
    }
}