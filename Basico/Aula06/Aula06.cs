using System;
class Aula06{
    static void Main(){
        int n1, n2, n3;

        n1=10; n2=20; n3=30;

        Console.WriteLine(n1 + ", " + n2 + ", " + n3);

        System.Console.WriteLine("\nn1={0}, \nn2=\t{1}, \nn3=\t\t{2}",n1,n2,n3);

        //Exemplo 02

        double valorCompra = 5.50;
        double valorVenda;
        double lucro=0.1;
        string produto = "Pastel";

        valorVenda = valorCompra+(valorCompra*lucro);

        System.Console.WriteLine("Produto..............:{0,15}",produto);
        System.Console.WriteLine("Compra..............:{0,15:c}",valorCompra);
        System.Console.WriteLine("Lucro..............:{0,15:p}",lucro);
        System.Console.WriteLine("Valor de venda..............:{0,15:c}",valorVenda);
    }
}