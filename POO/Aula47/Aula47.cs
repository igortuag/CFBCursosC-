using System;
class Aula47{
    class Calc{
        public int soma(params int[]n){
            int s = 0;
            for (int i = 0; i < n.Length; i++)
            {
                s += n[i];
            }
            return s;
        }
        public double soma(params double[]n){
            double s = 0;
            for (int i = 0; i < n.Length; i++)
            {
                s += n[i];
            }
            return s;
        }
    }
    static void Main(){
        int res1;
        double res2;
        Calc calc = new Calc();

        res1 = calc.soma(10, 4, 7, 5, 14);
        res2 = calc.soma(10.47, 5.14, 8.74, 78.3);

        System.Console.WriteLine(res1);
        System.Console.WriteLine(res2);

    }
}