using System;
using System.ComponentModel;

class Calculator{

    static int number1;
    static int number2;

    static int Add(){
        return number1 + number2;
    }

    static void DisplayNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
    static void GreetUser(){
        Console.Write("Write your name, please: ");
        Console.WriteLine("Hello " + Console.ReadLine() + "!");
    }
    static void Main(){
        number1 = 4;
        number2 = 7;
        Console.WriteLine("The sum of {0} and {1} is {2}",number1,number2,Add());

        GreetUser();

        DisplayNumbers();
    }
}