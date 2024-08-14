using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        if (IsRotation(str1, str2))
            Console.WriteLine("The second string is a rotation of the first string.");
        else
            Console.WriteLine("The second string is not a rotation of the first string.");
    }
}