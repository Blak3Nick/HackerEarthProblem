using System;


public class Product
{
    public static void Main(string[] args)
    {
        var input = Console.ReadLine();
        int num = Int32.Parse(input);
        string input2 = Console.ReadLine();
        char[] params1 = {' '};
        int[] intArray = new int[num];

        string[] strArray= input2.Split(params1);
        for (int i =0; i<strArray.Length;i++)
        {
            intArray[i] = Int32.Parse(strArray[i]);
        }
        int product = 1;
        foreach(int b in intArray)
        {
            product = product * b;
        }
        Console.WriteLine(product);

    }
}