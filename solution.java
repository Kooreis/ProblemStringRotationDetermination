Here is a Java console application that solves the problem:

```java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter the first string:");
        String s1 = scanner.nextLine();
        System.out.println("Enter the second string:");
        String s2 = scanner.nextLine();
        scanner.close();

        if (isRotation(s1, s2)) {
            System.out.println("The second string is a rotation of the first string.");
        } else {
            System.out.println("The second string is not a rotation of the first string.");
        }
    }

    private static boolean isRotation(String s1, String s2) {
        if (s1.length() != s2.length()) {
            return false;
        }
        String concatenated = s1 + s1;
        return concatenated.contains(s2);
    }
}
```

This program first takes two strings as input from the user. It then checks if the second string is a rotation of the first string by concatenating the first string to itself and checking if the second string is a substring of the result. If the second string is a substring, it is a rotation of the first string.