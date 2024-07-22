using System;

class Aula11
{
    static void Main()
    {
        int n1 = 10;
        float n2 = n1;

        float n3 = 10.5f;
        int n4 = (int)n3; //type cast

        int vInt = 10;
        short vLong = (short)vInt;

        Console.WriteLine(n2);
        Console.WriteLine(n4);
        Console.WriteLine(vLong);
    }
}