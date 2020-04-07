using System;
class Aula31{
        static public class Jogador{
        static public int energia;
        static public bool vivo;
        static public string nome;
        static public void ini(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
        public static void info(){
            System.Console.WriteLine("---------------------------------------------------");
            System.Console.WriteLine("Nome jogador: {0}\nEnergia: {1}\nVivo: {2}",nome, energia,vivo);
        }
    }

    class Inimigo{
        static public bool alerta;
        public string nome;
        public Inimigo(string n){
            alerta = false;
            nome = n;
        }
        public void info(){
            System.Console.WriteLine("---------------------------------------------------");
            System.Console.WriteLine("Nome : {0}\nAlerta: {1}", nome, alerta);
        }
    }
    static void Main(){
        
        Jogador.ini("Bruno");

        Jogador.info();

        Inimigo i1 = new Inimigo("Doido");
        Inimigo i2 = new Inimigo("Maluco");
        Inimigo i3 = new Inimigo("Pirado");

        Inimigo.alerta = true;

        i1.info();
        i2.info();
        i3.info();
    }
}