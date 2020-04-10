using System;
class Veiculo{
    public int velMax;
    private bool ligado;
    public int rodas;
    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }
    public string getLigado(){
        if(ligado){
            return "sim";
        }else{
            return "não";
        }
    }
}

class Carro : Veiculo {
    public string nome;
    public string cor;
    public Carro(string nome, string cor){
        desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class Aula34{
    static void Main(){
        Carro c1 = new Carro("Rapidão", "Vermelho");

        System.Console.WriteLine("Cor.......:{0}",c1.cor);
        System.Console.WriteLine("Nome:.....:{0}",c1.nome);
        System.Console.WriteLine("Rodas.....:{0}",c1.rodas);
        System.Console.WriteLine("Vel.Maxima:{0}",c1.velMax);
        System.Console.WriteLine("Ligado....:{0}",c1.getLigado());
    }
}