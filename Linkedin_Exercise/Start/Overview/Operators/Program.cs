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

// if-else statement to demonstrate conditional logic
if (x == 10) {
    Console.WriteLine("x is equal to 10");
} else {
    Console.WriteLine("x is not equal to 10");
}

// Ternary operator for conditional assignment
Console.WriteLine(x > 5 ? "x is greater than 5" : "x is not greater than 5");

// Switch case to demonstrate multiple conditions
switch (y) {
    case 10:
        Console.WriteLine("y is 10");
        break;
    case 20:
        Console.WriteLine("y is 20");
        break;
    default:
        Console.WriteLine("y is neither 10 nor 20");
        break;
}

// For loop to demonstrate iteration
for (int i = 0; i <= 10; i++) {
    Console.WriteLine($"i = {i}");
}

// foreach loop to iterate over an array
string[] greetings = { "Hello", "Hi", "Hey" };
foreach (string greeting in greetings) {
    Console.WriteLine(greeting);
}

// Counting characters in a string using a foreach loop
string sampleText = "This is a sample text for demonstrating operators.";
var charCount = 0;
foreach (char c in sampleText) {
    if (c == 'o') charCount++;
}
Console.WriteLine($"Number of 'o' characters: {charCount}");

// While loop to demonstrate a condition-based iteration
string? input = "";
while (input != "exit") {
    Console.Write("Type 'exit' to stop: ");
    input = Console.ReadLine();
    if (input != "exit") {
        Console.WriteLine($"You typed: {input}");
    }
}

// Do-while loop to ensure the loop runs at least once
do {
    Console.Write("Type 'exit' to stop: ");
    input = Console.ReadLine();
    if (input != "exit") {
        Console.WriteLine($"You typed: {input}");
    }
} while (input != "exit");

// Break and continue statements in loops
int[] numbers = { 12, 34, 27, 18, 9, 65, 53, 20, 5};
foreach (int number in numbers) {
    if (number >= 20 && number <= 30) {
        Console.WriteLine($"Skipping number {number} as it is between 20 and 30");
        continue; // Skip the rest of the loop for this iteration
    }
    if (number == 5) {
        Console.WriteLine("Breaking at number 5");
        break; // Exit the loop
    }
    Console.WriteLine($"Number: {number}");
}

// Exception handling using try-catch
Console.WriteLine("Demonstrating exception handling:");
while (true) {
    try {
        Console.Write("Enter the first number: ");
        int? firstInput = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int? secondInput = Convert.ToInt32(Console.ReadLine());
        int result = firstInput.Value / secondInput.Value;
        Console.WriteLine($"Result of division: {result}");
        break; // Exit the loop if successful
    } catch (DivideByZeroException) {
        Console.WriteLine("Cannot divide by zero. Please try again.");
    } catch (FormatException) {
        Console.WriteLine("Invalid input. Please enter valid integers.");
    } catch (Exception ex) {
        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
    }
}

