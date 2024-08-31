using System;

class Program
{
    static void Main()
    {
        // Define the string to be reversed
        string originalString = "Edson Camacho";
        
        // Reverse the string
        string reversedString = ReverseString(originalString);
        
        // Display the reversed string
        Console.WriteLine($"Original String: {originalString}");
        Console.WriteLine($"Reversed String: {reversedString}");
    }

    // Method to reverse the string
    static string ReverseString(string input)
    {
        // Initialize an empty char array to store the reversed characters
        char[] reversedArray = new char[input.Length];

        // Loop through the input string from the end to the beginning
        for (int i = 0; i < input.Length; i++)
        {
            reversedArray[i] = input[input.Length - 1 - i];
        }

        // Convert the char array to a string and return it
        return new string(reversedArray);
    }
}

