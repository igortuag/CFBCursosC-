using System;
class Aula15{
    static void Main(){
        int tempo = 0;
        char escolha;

        System.Console.WriteLine("Belo Horizonte/MG e Vitoria/ES");
        System.Console.WriteLine("Escolha o transporte: \n [a]Avião \n [c]Carro \n [o]Onibus");
        escolha = char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
            case 'A':
                tempo = 50;
                break;
            case 'c':
            case 'C':
                tempo = 480;
                break;
            case 'o':
            case 'O':
                tempo = 660;
                break;
            default:
                tempo = -1;
                break;            
        }

        if(tempo<0){
            System.Console.WriteLine("Opção escolhida invalida.");
            Main();
        }else{
            System.Console.WriteLine("Para o transporte escolhido, o tempo necessário será de {0} minutos.",tempo);
        }
    }
}