/*
- When you declare a variable or constant in a program, you must either specify its type or use the var keyword to let the compiler infer the type.
*/

void func1()
{
    var limit = 3;
}


/* Type system in .NET

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types

* All types derive ultimately from a single base type, which is `System.Object`.
* Each type in the Common Type System (CTS) is defined as either a **value type** or a **reference type**.

* Built-in types:
    * Built-in value types
    * Built-in reference types:
        * `string`
* Custom types

/*


/* string
*/

void func2()
{
    string astring = "Hello, World!";
    Console.WriteLine(astring + " has length " + astring.Length);
}


/* arrays
*/

void func3()
{
    int[] numbers = {1, 2, 3, 4, 5};
    
    string[] strings = new string[3];
    strings[0] = "Hello";

    // 2D array
    int[,] matrix = new int[2, 3];
    matrix[0, 0] = 1;

    int[,] matrix2 = {
        {1, 2, 3}, 
        {4, 5, 6}
    };
}


/* Classes
*/



void func4()
{
    Person person = new Person("Alice");

    // getter and setter via property
    Console.WriteLine("Hello " + person.name);
    person.name = "Bob";
    Console.WriteLine("Hello " + person.name);
}



func1();

func2();

func3();

func4();
