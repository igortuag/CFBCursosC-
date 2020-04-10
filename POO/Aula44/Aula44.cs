using System;

struct Carro{
    public string marca;
    public string modelo;
    public string cor;
    public Carro(string marca, string modelo, string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
    public void info(){
        System.Console.WriteLine("Marca.: {0}",this.marca);
        System.Console.WriteLine("Modelo.: {0}",this.modelo);
        System.Console.WriteLine("Cor.: {0}",this.cor);
    }
}
class Aula44{
    static void Main(){
        Carro c1 = new Carro("Honda", "HRV", "Prata");
        Carro c2 = new Carro("VW", "Golf", "Azul");
        c1.info();
        c2.info();
    }
}