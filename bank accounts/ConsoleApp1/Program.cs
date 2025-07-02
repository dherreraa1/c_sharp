// See https://aka.ms/new-console-template for more information

using System;

public class Program {
   public static void Main() {
        // Step 1: Prompt the user for input
        Console.WriteLine("Select your type of bank account (Savings, Checking, Business):");
        string typeBankAccount = Console.ReadLine();
        typeBankAccount = typeBankAccount.ToLower();
        double interestRate = 0.0;
        double monthlyFee = 0.0;

        // Step 2: Use switch statement to select the type of bank account
        switch (typeBankAccount) {
            case "savings":
                interestRate = 0.02;
                Console.WriteLine("You are choosing the Savings Account");
                break;

            case "checking":
                monthlyFee = 10.0;
                Console.WriteLine("You are choosing the Checking Account");
                break;

            case "business":
                interestRate = 0.01;
                monthlyFee = 20.0;
                Console.WriteLine("You are choosing the Business Account Account");
                break;

            default:
                Console.WriteLine("Error");
                break;
        }

        Console.WriteLine("Monthly fee: $" + monthlyFee);
        Console.WriteLine("Interest rate: " + interestRate + "%");
    }
}