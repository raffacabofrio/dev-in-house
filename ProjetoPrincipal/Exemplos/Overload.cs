using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Overload
{
    public void Exemplos()
    {
        Console.WriteLine(Calculadora.Plus(2, 2));
        Console.WriteLine(Calculadora.Plus(2, 2, 2));
        Console.WriteLine(Calculadora.Plus(2, 2, 2, 2));
    }
}

public class Calculadora
{
    public static int Plus(int number1, int number2)
    {
        return Plus(number1, number2, 0);
    }

    public static int Plus(int number1, int number2, int number3)
    {
        return Plus(number1, number2, number3, 0);
    }

    public static int Plus(int number1, int number2, int number3, int number4)
    {
        return number1 + number2 + number3 + number4;
    }
}

