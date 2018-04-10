# Programming Bootcamp - Variables, Conditionals, And Loops 1.0

Written by Drake Lambert 4/9/2018

## About

In this lesson we went over the following:

- Listing files and folders in Powershell
    ```powershell
    ls
    ```
- Making a folder
    ```powershell
    mkdir Lesson1
    ```
- Changing current directory/folder
    ```powershell
    cd Lesson1
    ```
- Changing current directory/folder
    ```powershell
    cd Lesson1
    ```
- Making a .Net Core Console App
    ```powershell
    dotnet new console
    ```
- Opening Visual Studio Code at the current directory
    ```powershell
    code .
    ```
- What the `Main` function looks like
    ```csharp
    using System;

    namespace Lesson1
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Your code here!
            }
        }
    }
    ```
- Writing to the console
    ```csharp
    Console.WriteLine(text);
    ```
- Declaring different types of variables
    ```csharp
    int number = 1;
    var text = "Goodbye, Load!";
    ```
- Using arrays of variables
    ```csharp
    var numbers = new int[3];
    numbers[0] = 12;
    ```
- Using conditional logic
    ```csharp
    var someCondition = true;
    if (someCondition)
    {
        Console.WriteLine(text);
    }
    ```
- Using many different loops
    ```csharp
    // Executes given statements while a condition is true.
    while (condition)
    {
        // ...
    }

    // Declares a variable and keeps looping while a condition is true. Increments the variable along the way.
    for (var i = 0; i < 10; i++)
    {
        // ...
    }

    // Loops over an array and reads each of its values.
    int[] numbers = { 1, 2, 3, 4 };
    foreach (var number in numbers)
    {
        Console.WriteLine(number);
    }
    ```

## Take Away This

You can combine loops, arrays, and conditionals to do some pretty crazy stuff! Take, for example, the following code. It loops over an array and prints a certain amount of line segments.

```csharp
int segmentLength = 3;
for (int i = 0; i < segmentLength; i++)
{
    Console.Write("+---");
}
Console.WriteLine("+");
```

This code prints the following to the console.

```text
+---+---+---+
```

## Chalenge

Write a program in C# that will print a stair case of variable height to the console.

It will be beneficial to use the new function I introduced above, `Console.Write();`. This function also writes strings to the console, but it does not move the cursor to the next line like `Console.WriteLine();`. This allows you to write multiple times on a single line.

I have written some starter code for you below.

```csharp
using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = 4;

            // You don't get much help. Write the rest here.
        }
    }
}
```

Your staircase should be the height specified by the `height` variable. You should be able to change the height and have the staircase still print properly.

Here is the expected output for a staircase of `var height = 3;`.

```text
+---+
|   |
+---+---+
|   |   |
+---+---+---+
|   |   |   |
+---+---+---+
```

As a bonus, take a look at what happens when `var height = 0;` or when it is a negative number. Can you make the stairs print upsidedown for negative heights? How can you make the code as simple as possible while still keeping it readable?

Good luck! As always, feel free to message me in the discord for any questions!

## On Your Own

Because we had so little time during our meeting, I think it would be worth it to learn some other basics online. In this way, we can tackle bigger challenges as a group.

I am linking the [Microsoft C# tutorial series](https://docs.microsoft.com/en-us/dotnet/csharp/quick-starts/index). I would like you to read the three folowing sections:

- Interpolated strings
- List collection
- Introduciton to classes

[https://docs.microsoft.com/en-us/dotnet/csharp/quick-starts/index](https://docs.microsoft.com/en-us/dotnet/csharp/quick-starts/index)

This might be a long read so feel free to only read one section per day.

If you are hungry for more after this reading, check out some more advanced [Microsoft tutorials here](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/index).

[https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/index](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/index)

## Author's Note

I had a lot of fun at the first lesson! We will be doing similar challenges like the staircase printer for only a week or two more. Then we will tackle solving real world problems.

Talk to you all soon!