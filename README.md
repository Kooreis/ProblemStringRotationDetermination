# Question: How do you determine if a string is a rotation of another string? C# Summary

The provided C# console application is designed to determine whether one string is a rotation of another string. The program prompts the user to input two strings. It then calls the function 'IsRotation' with these two strings as arguments. Inside the 'IsRotation' function, it first checks if the lengths of the two strings are equal. If they are not, the function immediately returns false, as unequal length strings cannot be rotations of each other. If the lengths are equal, the function concatenates the first string to itself, effectively creating a string that contains all possible rotations of the original string. It then checks if the second string is a substring of this concatenated string. If it is, the function returns true, indicating that the second string is a rotation of the first. If it is not, the function returns false. The result is then printed to the console.

---

# Python Differences

The Python version of the solution uses the same logic as the C# version to solve the problem. It first checks if the two strings are of the same length. If they are not, it returns False. If they are, it concatenates the second string to itself and checks if the first string is a substring of the result. If it is, then the first string is a rotation of the second.

The main differences between the two versions are due to the differences in syntax and built-in functions between Python and C#.

1. Python uses the `len()` function to get the length of a string, while C# uses the `Length` property.

2. Python uses the `in` keyword to check if a string is a substring of another string, while C# uses the `Contains()` method.

3. Python uses the `input()` function to get user input, while C# uses the `Console.ReadLine()` method.

4. Python uses the `print()` function to output to the console, while C# uses the `Console.WriteLine()` method.

5. Python uses the `def` keyword to define a function, while C# uses the `static` keyword to define a static method.

6. Python uses the `if __name__ == "__main__":` construct to ensure that the `main()` function is only called when the script is run directly, not when it is imported as a module. C# does not have an equivalent construct.

7. Python uses f-strings (formatted string literals) for string formatting, while C# uses string concatenation or the `String.Format()` method.

---

# Java Differences

The Java version of the solution uses the same logic as the C# version to solve the problem. Both versions first check if the two strings are of the same length. If they are not, one cannot be a rotation of the other. If they are the same length, the program concatenates the first string to itself and checks if the second string is a substring of the result. If it is, then the second string is a rotation of the first.

The main differences between the two versions are due to the differences in the languages themselves:

1. User Input: In the C# version, the Console.ReadLine() method is used to get user input, while in the Java version, a Scanner object is used to get user input.

2. String Concatenation: Both versions use the '+' operator for string concatenation. This is a common feature in many programming languages.

3. Checking for Substring: Both versions use the 'contains' method of the string class to check if one string is a substring of another. This method works the same way in both languages.

4. Method Declaration: In C#, the method is declared as 'static bool' while in Java it's declared as 'private static boolean'. This is due to the difference in how the two languages handle data types and method visibility.

5. Printing to Console: In C#, Console.WriteLine() is used to print to the console, while in Java, System.out.println() is used.

In summary, the two versions are very similar and use the same logic to solve the problem. The differences are mainly due to the syntax and features of the two languages.

---
