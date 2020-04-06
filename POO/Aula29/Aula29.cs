using System;
class Aula29{
    public class Jogador{
        public int energia;
        public bool vivo;
        public string nome;
        public Jogador(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
        ~Jogador(){
            System.Console.WriteLine("Jogador {0} foi destruido",nome);
        }

    }
    static void Main(){
        Jogador j1 = new Jogador("João");
        Jogador j2 = new Jogador("Pedro");

        System.Console.WriteLine("Qual o nome do jogador 1?");
        j1.nome = Console.ReadLine();

        System.Console.WriteLine("Energia do jogador {0}: {1}",j1.nome,j1.energia);
        System.Console.WriteLine("Energia do jogador {0}: {1}",j2.nome,j2.energia);
    }
}