// See https://aka.ms/new-console-template for more information

int x = 10, y = 20;
string a = "Hello", b = "World";
Console.WriteLine("Operators in C#");
Console.WriteLine("Values used:");
Console.WriteLine($"x = {x}, y = {y}");
Console.WriteLine($"a = {a}, b = {b}");

// Basic math operators are + (addition), - (subtraction), * (multiplication), / (division), and % (modulus).
Console.WriteLine($"x + y = {x + y}"); // Addition
Console.WriteLine($"x - y = {x - y}"); // Subtraction
Console.WriteLine($"x * y = {x * y}"); // Multiplication
Console.WriteLine($"x / y = {x / y}"); // Division
Console.WriteLine($"x % y = {x % y}"); // Modulus
Console.WriteLine($"x++ = {x++}"); // Post-increment
Console.WriteLine($"++x = {++x}"); // Pre-increment
Console.WriteLine($"x-- = {x--}"); // Post-decrement
Console.WriteLine($"--x = {--x}"); // Pre-decrement
Console.WriteLine($"x == y: {x == y}"); // Equality
Console.WriteLine($"x != y: {x != y}"); // Inequality   
Console.WriteLine($"x > y: {x > y}"); // Greater than
Console.WriteLine($"x < y: {x < y}"); // Less than
Console.WriteLine($"x >= y: {x >= y}"); // Greater than or equal to
Console.WriteLine($"x <= y: {x <= y}"); // Less than or equal
// Logical operators are && (and), || (or), and ! (not).
Console.WriteLine($"x > 5 && y < 30: {x > 5 && y < 30}"); // Logical AND
Console.WriteLine($"x < 5 || y > 15: {x < 5 || y > 15}"); // Logical OR
Console.WriteLine($"!(x < 5): {!(x < 5)}"); // Logical NOT

// string concatenation using +
Console.WriteLine($"a + b = {a + b}"); // Concatenation
// string interpolation using $
Console.WriteLine($"a = {a}, b = {b}"); // Interpolation
