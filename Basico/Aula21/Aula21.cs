using System;
class Aula21
{
    static void Main(){

        string senha="123", senhauser;
        int tentativas = 0;

        do
        {
            Console.Clear();
            System.Console.WriteLine("Digite a senha: ");
            senhauser=Console.ReadLine();
            tentativas++;
        } while (senha != senhauser);

        System.Console.WriteLine("Senha correta!\nTentativas:{0}",tentativas);
    }
}