using System;
using System.Collections.Generic;
class Aula56{
    static void Main(){
        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Avia");
        transp.AddFirst("Navio");
        transp.AddFirst("Moto");

        transp.AddLast("Bicicleta");

        LinkedListNode<string>no;
        no=transp.FindLast("Navio");
        transp.AddAfter(no, "Patinete");
        transp.AddBefore(no, "Patins");

        //transp.Clear();

        transp.Remove("Navio");

        transp.RemoveFirst();
        transp.RemoveLast();

        if(transp.Find("Navio") == null){
            System.Console.WriteLine("Não encontrado");
        }else{
            System.Console.WriteLine("Elemento Encontrado");
        }

        foreach (var t in transp)
        {
            System.Console.WriteLine("Transp: {0}",t);
        }
    }
}