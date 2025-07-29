// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("What is your name? ");
// string? name = Console.ReadLine();
// Console.WriteLine($"Hello, {name}!");

// Declaring a few strings for excercise
string greeting = "Welcome to C# programming!";
Console.WriteLine(greeting);

string outstr;
string str1 = "This is the first string.";
string str2 = "This is the second string.";
string str3 = "This is the third string.";
string[] strs = { "John", "Doe", "Jane", "Smith" };

// Lnegth of a string
Console.WriteLine($"Length of str1: {str1.Length}");

// Accessing characters in a string
Console.WriteLine(str2[14]);

// Interate over a string
foreach (char c in str3)
{
    if (c == 'i')
    {
        Console.WriteLine("Found an 'i' in str3");
        break;
    }
}

// Concatnation of strings
outstr = string.Concat(strs);
Console.WriteLine($"Concatenated string: {outstr}");

// Joining strings with a separator
outstr = string.Join(",", strs);
Console.WriteLine($"Joined string: {outstr}");

outstr = string.Join("__", strs);
Console.WriteLine($"Joined string with '__': {outstr}");

// String comparison
int comparisonResult = string.Compare(str1, "This is the first string.");
Console.WriteLine($"Comparison result: {comparisonResult}");

// Equality check
bool isEqual = str2.Equals(str3);
Console.WriteLine(isEqual ? "str2 and str3 are equal." : "str2 and str3 are not equal.");

// String serach
Console.WriteLine(str1.IndexOf("r"));
Console.WriteLine(str1.IndexOf("first"));

Console.WriteLine(str1.LastIndexOf("s"));
Console.WriteLine(str1.LastIndexOf("first"));

// Replacing
outstr = str1.Replace("first", "initial");
Console.WriteLine($"Replaced string: {outstr}");
