using System;
class Aula10{
        enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado}
    static void Main(){

        DiasSemana ds = (DiasSemana)3;

        int dsInt = (int)DiasSemana.Sexta;

        for(int i=0; i < 7; i++){
            System.Console.WriteLine((DiasSemana)i);
        }

        System.Console.WriteLine(ds);
        System.Console.WriteLine(dsInt);

    }
}