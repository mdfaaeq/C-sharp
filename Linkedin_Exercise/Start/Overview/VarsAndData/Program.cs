// See https://aka.ms/new-console-template for more information

// Basic data types in C#
int i = 42;
float f = 3.14f;
decimal d = 2.71828m;
bool b = true;
char c = 'A';

// Defining a string
string s = "Hello, C#";

// Declare implicitly typed variables
var implicitInt = 10;
var implicitString = "This is a string";

// Declaring an array
int[] numbers = { 1, 2, 3, 4, 5 };
string[] names = { "Alice", "Bob", "Charlie" };
char[] letters = { 'A', 'B', 'C' };

// Printing the values using a formatted string
Console.WriteLine($"Integer: {i}, Float: {f}, Decimal: {d}, Boolean: {b}, Character: {c}");

Console.WriteLine($"String: {s}");
Console.WriteLine($"Implicitly typed integer: {implicitInt}, Implicitly typed string: {implicitString}");
Console.WriteLine($"Array of integers: {string.Join(", ", numbers)}");
Console.WriteLine($"Array of strings: {string.Join(", ", names)}");
Console.WriteLine($"Array of characters: {string.Join(", ", letters)}");

// "null" is a special value in C# that represents the absence of a value
object? nullValue = null;
Console.WriteLine($"Null value: {nullValue}");

// Implicit conversion between types
long longValue = i; // int to long

// Explicit conversion (casting) between types
double doubleValue = (double)f; // float to double
Console.WriteLine($"Long value from int: {longValue}");
Console.WriteLine($"Double value from float: {doubleValue}");