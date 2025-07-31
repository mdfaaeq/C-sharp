// See https://aka.ms/new-console-template for more information

using System.Text;

int jumpCount = 0; 
string[] jumpers = { "Alice", "Bob", "Charlie", "Diana" };

// Initialing a string builder
StringBuilder sb = new StringBuilder("Initial string. ", 200);

Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

// Appending strings
sb.Append("This is a string builder example. ");
sb.Append("It is used to build strings efficiently. ");

// Appendline
sb.AppendLine("It allows for efficient string manipulation.");

// Appending formatted strings
sb.AppendFormat("Jump count: {0}.", jumpCount);

// AppendJoin
sb.AppendJoin(", ", jumpers);

// Use of replace
sb.Replace("Alice", "Eve");

// Insert a string at a specific index
sb.Insert(0, "Welcome to the string builder example! ");

Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

Console.WriteLine(sb.ToString());
