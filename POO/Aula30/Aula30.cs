using System;
class Aula30{
    public class Jogador{
        public int energia;
        public bool vivo;
        public string nome;
        public Jogador()
        {
            energia=100;
            vivo=true;
            nome="Jogador";
        }
        public Jogador(string n)
        {
            energia = 100;
            vivo = true;
            nome = n;
        }
        public Jogador(string n, int e)
        {
            energia = e;
            vivo = true;
            nome = n;
        }
        public Jogador(string n, int e, bool v)
        {
            energia = e;
            vivo = v;
            nome = n;
        }
        public void info(){
            System.Console.WriteLine("---------------------------------------------------");
            System.Console.WriteLine("Nome jogador: {0}\nEnergia: {1}\nVivo: {2}",nome, energia,vivo);
        }
    }
    static void Main(){
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Pedro");
        Jogador j3 = new Jogador("Theo",100);
        Jogador j4 = new Jogador("Zigofredo",30,false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();

    }
}