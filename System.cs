
using System;

class Program
{
    static void Main()
    {
        // Inteiros
        int idade = 18;
        long populacaoMundial = 8000000000;

        // Decimais
        float altura = 1.73f;
        double peso = 120.5;
        decimal saldoBancario = 15000.99m;

        // Booleanos
        bool programador = true;
        bool dormiuBem = false;

        // Texto
        string nome = "Eric";
        char inicial = 'E';

        // Impressão das variáveis
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
        Console.WriteLine("Altura: " + altura + "m");
        Console.WriteLine("Peso: " + peso + "kg");
        Console.WriteLine("Saldo: R$" + saldoBancario);
        Console.WriteLine("É programador? " + programador);
        Console.WriteLine("Dormiu bem hoje? " + dormiuBem);
        Console.WriteLine("Inicial do nome: " + inicial);
        Console.WriteLine("População mundial: " + populacaoMundial);
    }
}
