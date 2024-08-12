Here is a simple console application in C# that determines if one string is a rotation of another string.

```C#
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

    static bool IsRotation(string str1, string str2)
    {
        if (str1.Length != str2.Length)
            return false;

        string temp = str1 + str1;
        return temp.Contains(str2);
    }
}
```

This program works by first checking if the two strings are the same length. If they are not, then one cannot be a rotation of the other. If they are the same length, the program concatenates the first string to itself and checks if the second string is a substring of the result. If it is, then the second string is a rotation of the first.