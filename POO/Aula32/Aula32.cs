using System;
class Aula32{
    class Calculo{

        public int v1;
        public int v2;

        public Calculo(int v1, int v2){
            this.v1=v1;
            this.v2=v2;
        }
        public int Somar(){
            return v1 + v2;
        }
        
    }
    static void Main(){
        
        Calculo calculo = new Calculo(10, 2);

        System.Console.WriteLine(calculo.Somar());

    }
}