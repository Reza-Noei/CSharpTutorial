using System;
using TutorialNoei;

delegate void Print(string argument);

public static class Program
{

    public static void Main(string[] args)
    {
        ConstructorTest a = new ConstructorTest();
    }  


    public static void customPrint(string argument)
    {
        Console.WriteLine(argument);
    }

    public static void customPrint2(string argument)
    {
        Console.WriteLine(argument);
    }

}