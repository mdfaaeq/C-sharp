using System;

namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Mohamed Fazal";
            string phoneNumber = "123-456-7890";

            // Replace hyphens with slashes in the phone number
            phoneNumber = phoneNumber.Replace("-", "/");
            Console.WriteLine("Modified Phone Number: " + phoneNumber);

            // Insert "Mr. " at the beginning of the full name
            string userName = fullName.Insert(0, "Mr. ");
            Console.WriteLine("User Name: " + userName);

            // Display the length of the full name
            Console.WriteLine("Length of Full Name: " + fullName.Length);

            // Extract the first name and last name using Substring
            string firstName = fullName.Substring(0, 7); // "Mohamed"
            string lastName = fullName.Substring(8,5);     // "Fazal" (start from index 8 to the end)

            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            
            Console.ReadKey();
        }
    }
}
