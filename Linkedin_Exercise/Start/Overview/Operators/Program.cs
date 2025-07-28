/// See https://aka.ms/new-console-template for more information
/// This program demonstrates different types of operators in C#
int x = 10, y = 20;
string a = "Hello", b = "World";

Console.WriteLine("Operators in C#");
Console.WriteLine("Values used:");
Console.WriteLine($"x = {x}, y = {y}");
Console.WriteLine($"a = {a}, b = {b}");

/// Basic math operators
/// + (addition), - (subtraction), * (multiplication), / (division), % (modulus)
Console.WriteLine($"x + y = {x + y}"); // Addition
Console.WriteLine($"x - y = {x - y}"); // Subtraction
Console.WriteLine($"x * y = {x * y}"); // Multiplication
Console.WriteLine($"x / y = {x / y}"); // Division
Console.WriteLine($"x % y = {x % y}"); // Modulus

/// Increment and decrement operators
Console.WriteLine($"x++ = {x++}"); // Post-increment: prints x, then increments
Console.WriteLine($"++x = {++x}"); // Pre-increment: increments first, then prints
Console.WriteLine($"x-- = {x--}"); // Post-decrement
Console.WriteLine($"--x = {--x}"); // Pre-decrement

/// Comparison operators
/// == (equal), != (not equal), >, <, >=, <=
Console.WriteLine($"x == y: {x == y}"); // Equality
Console.WriteLine($"x != y: {x != y}"); // Inequality
Console.WriteLine($"x > y: {x > y}"); // Greater than
Console.WriteLine($"x < y: {x < y}"); // Less than
Console.WriteLine($"x >= y: {x >= y}"); // Greater than or equal to
Console.WriteLine($"x <= y: {x <= y}"); // Less than or equal to

/// Logical operators
/// && (and), || (or), ! (not)
Console.WriteLine($"x > 5 && y < 30: {x > 5 && y < 30}"); // Logical AND
Console.WriteLine($"x < 5 || y > 15: {x < 5 || y > 15}"); // Logical OR
Console.WriteLine($"!(x < 5): {!(x < 5)}"); // Logical NOT

/// String concatenation using +
Console.WriteLine($"a + b = {a + b}"); // Concatenates "Hello" + "World"
