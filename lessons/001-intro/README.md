# Create a .NET project

Create console application:
```bash
dotnet new console -o myApp
```

Build the project:
```bash
cd myApp
dotnet build
```

Run the project:
```bash
dotnet run
```

## C# vs C++

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


## References

1. https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code
2. https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line
