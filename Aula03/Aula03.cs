using System;

class Aula03
{
    static void Main()
    {
        int num1, num2, res;

        num1 = 10;
        num2 = 2;
        res = num1 * num2;

        Console.WriteLine("A multiplicação de " + num1 + " com " + num2 + " é igual a: " + res);

        byte n1 = 10; // entre 0 e 255
        int num = -10;
        char letra = 'c';
        float valor = 5.3f;
        string nome = "Felipe";

        var aux = nome;

        Console.WriteLine("Valor da variável: " + aux);
    }
}