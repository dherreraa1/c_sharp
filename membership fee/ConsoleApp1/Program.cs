// See https://aka.ms/new-console-template for more information

using System;
public class Program {
   public static void Main() {
        // Step 1: Prompt the user for input
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Do you want a premium membership? (yes/no):");
        string membershipInput = Console.ReadLine();
        bool isPremium = membershipInput.ToLower() == "yes";

        // Step 2: Use advanced if-else statements
        if (age < 18) {
            if (isPremium) {
                 Console.WriteLine("The fee is $25 for a premium membership.");  
            } else {
                Console.WriteLine("The fee is $15 for a basic membership.");  
            }
        } else if (age >= 18 && age <= 60) {
            if (isPremium) {
                Console.WriteLine("The fee is $50 for a premium membership.");   
            } else {
                Console.WriteLine("The fee is $30 for a basic membership.");  
            }
        } else {
            if (isPremium) {
                Console.WriteLine("The fee is $35 for a premium membership.");  
            } else {
                Console.WriteLine("The fee is $20 for a basic membership.");  
            }
        }
    }
}