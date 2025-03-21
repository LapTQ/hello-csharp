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


/* C# vs C++

* In C#:
    * No need to explicitly include a `Main` method.
    * There's no header/source file separation. Everything is in .cs file.
    * Access modifiers must be mentioned explicitly for each member.
    * `sealed` in C# is equivalent to `final` in C++.
    * Explicit `interface` classes.
    * `Readonly` vs `const`:
        * `const` is a compile-time constant.
        * `readonly` is a runtime constant.
    * `Partial` classes and methods
    * Function pointers are called **delegates**.
    * `with` expression: create new object that are modified copies of existing objects.
    * lambda expressions `=>`.
    * Properties: `get` and `set` accessors, `value` is a keyword.
    * Function arguments:
        * `ref` (instead of `&` in C++), `in`, `out`.
        * No `const` arguments. Use `in` instead.
    * Extension methods: extend the functionality of existing types without modifying them or creating derived types.
    * `?`, for example:
        * ternary operator, same as in C++.
        * `int? anInt;`: nullable, same as `std::optional` in C++.
        * `var ret = someObject?.doSomething() ?? someFunction();`: null-conditional operator and null-coalescing operator. 
    * `!` null-forgiving operator.
    * `new` method.
    * **Generics**, sort of like templates in C++ ... but not quite:
        * No support for partial specialization.
        * Type parameters cannot itself be generic.
        * No support for non-type template parameters.
        * ... and more.
    * Concurrency: similar concepts but easier to use:
        * `await`/`async` patterns
        * Returning a `Task` object.
    * Classes are reference types.
    * The Garbage Collector (GC) manages memory (reference counting):
        * **Finalizers**: 
            * Similar to destructors, but not equivalent. 
            * Manages external resouces.
            * Cannot be called explicitly.
        * **Dispose**:
            * Not a destructor.
            * Manages unmanaged resources.
        
*/