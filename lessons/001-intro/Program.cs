/* Top-level statements vs. Main method

Programs entry point can be defined in two ways:
* Main method.
* Top-level statements:
    * Only one file can have top-level statements. The program's entry point is the first line of program text in that file.
    * Top-level statements can also return values and access command-line arguments.
    * The args variable is never null but its Length is zero if no command-line arguments were provided.

*/
Console.WriteLine("Hello, World!");

if (args.Length > 0)
{
    foreach (var arg in args)
    {
        Console.WriteLine($"Argument={arg}");
    }
}
else
{
    Console.WriteLine("No arguments");
}

return 0;


