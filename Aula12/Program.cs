using System;

class Aula12
{
    static void Main()
    {
        int n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        res = (n1 + n2 + n3 + n4) / 4;

        if (res >= 6)
        {
            Console.WriteLine("Nota: {0} - Aprovado", res);
        }
        else
        {
            Console.WriteLine("Nota: {0} - Reprovado", res);
        }
    }
}