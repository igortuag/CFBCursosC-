using System;

class Base{
    public Base(){
        Console.WriteLine("Construtor da classe base");
    }

    virtual public void info(){}
}
class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada 1");
    }
    override public void info(){
        System.Console.WriteLine("Derivada1");
    }
}
class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da classe Derivada 2");
    }
    override public void info(){
        System.Console.WriteLine("Derivada2");
    }
}
class Aula38{
    static void Main(){
        Base Ref;
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();
        
        Ref=derivada2;

        Ref.info();

    }
}