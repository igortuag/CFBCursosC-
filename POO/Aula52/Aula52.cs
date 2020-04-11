using System;
class Aula52{
    static void Main(){

        int n1, n2, res;
        res = n1 = n2 = 0;

        n1 = 10;

        n2 = 0;

        try{    
            res = n1 / n2;
            System.Console.WriteLine("{0} / {1} = {2}",res,n1,n2);
        }catch(Exception e){
            System.Console.WriteLine("Erro, não foi possível dividir. {0}",e.Message);
            System.Console.WriteLine("Ex: {0}",e.GetType());
        }


    }
}