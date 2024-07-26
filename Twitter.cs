using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Prompt the user to enter their message
        Console.WriteLine("Enter your message:");
        // Read the user's input and store it in the variable 'message'
        string message = Console.ReadLine();

        // Step 2 and 3: Validate the length of the message and output the appropriate response
        string result = ValidateMessage(message);
        // Print the result of the validation (either "Posted" or "Rejected")
        Console.WriteLine(result);
    }
    // Method to validate the length of the message
    public static string ValidateMessage(string message)
    {
        // If the message length is greater than 140 characters, return "Rejected"
        if (message.Length > 140)
        {
            return "Rejected";
        }
        else
        {
            // Otherwise, return "Posted"
            return "Posted";
        }
    }
}
// 2024/6/3_SenShoikot_Exercise 3.1