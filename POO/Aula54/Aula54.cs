using System;
namespace Calc1{
    class Area{
        public static float Quad(float bas, float alt){
            if(bas == 0 || alt == 0){
                throw new Exception("Base ou altura não podem ser igual a 0");
            }
            return bas*alt;
        }
    }
}
namespace Calc2{
    class Area{
        public static float Quad(float bas, float alt){
            if(bas == 0 || alt == 0){
                throw new Exception("Base ou altura não podem ser igual a 0");
            }
            return bas*alt;
        }
    }
}
class Aula54{
    static void Main(){

        float area=0;

        try{    
            area = Calc1.Area.Quad(0,4f);
            System.Console.WriteLine("Area do rec.:{0}",area);
        }catch(Exception e){
            System.Console.WriteLine("ERROR: {0}",e.Message);
        }finally{
            System.Console.WriteLine("Fim do processo!");
        }


    }
}