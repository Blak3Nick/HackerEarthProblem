using System;


public class Product
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var input2 = Console.ReadLine();
        string s = input2;
        Console.WriteLine(input);
        Console.WriteLine(input2);
        int[] intArray = new int[input.Length];
        foreach(int a in intArray)
        {Console.Write(a);}
        string[] myStringArr = s.Split(" ");
    }
}