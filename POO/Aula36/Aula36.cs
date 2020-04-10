using System;

class  Veiculo{
    public int velAtual;
    private int velMax;
    protected bool ligado;
    public Veiculo(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }
    public bool getLigado(){
        return ligado;
    }
    public int getVelMax(){
        return velMax;
    }

}
class Carro:Veiculo{
    public string nome;
    public Carro(string nome, int vm):base(vm){
        this.nome=nome;
        ligado=true;
    }
}

class Aula36{
    static void Main(){
        Carro carro = new Carro("Rapidão", 120);

        System.Console.WriteLine("Nome......:{0}",carro.nome);
        System.Console.WriteLine("Vel.Maxima:{0}",carro.getVelMax());
        System.Console.WriteLine("Ligado....:{0}",carro.getLigado());
    }
}