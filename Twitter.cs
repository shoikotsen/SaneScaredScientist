using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 1: Accept the user's message
        Console.WriteLine("Enter your message:");
        string message = Console.ReadLine();

        // Step 2 and 3: Check the length of the message and output the appropriate message
        string result = ValidateMessage(message);
        Console.WriteLine(result);
    }

    public static string ValidateMessage(string message)
    {
        if (message.Length > 140)
        {
            return "Rejected";
        }
        else
        {
            return "Posted";
        }
    }
}
// 2024/6/3_SenShoikot_Exercise 3.1