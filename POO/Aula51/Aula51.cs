using System;
class Aula51{
    static void Main(string[] args){

        int res = 0;

        if(args.Length > 0){
            System.Console.WriteLine("Qtds de argumentos {0}", args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                System.Console.WriteLine("Argumento {0} : {1}",i, args[i]);
                res += Int32.Parse(args[i]);
            }
            System.Console.WriteLine("Soma: {0}",res);
        }else{
            System.Console.WriteLine("Não foram passados argumentos");
        }
    }
}