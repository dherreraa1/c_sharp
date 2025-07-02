// See https://aka.ms/new-console-template for more information

using System;
public class Program
{
    public static void Main() {
        
        int age;
        Console.WriteLine("Write passenger's age: ");
        age = int.Parse(Console.ReadLine());

        if(age < 12){
            Console.WriteLine("Half price ticket.");
        }else if(age >= 12 && age < 65){
            Console.WriteLine("Full price ticket.");
        }else{
            Console.WriteLine("Senior discount ticket.");
        }

        string mode;

        Console.WriteLine("Select travel mode: Bus, Train, or Flight.");
        mode = Console.ReadLine();

        switch(mode){
            case "Bus":
                Console.WriteLine("Booking a bus ticket");
                break;
            case "Train":
                Console.WriteLine("Booking a train ticket");
                break;
            case "Flight":
                Console.WriteLine("Booking a flight ticket");
                break;
            default:
                Console.WriteLine("Invalid selection. Please choose Bus, Train, or Flight.");
                break;
        }
    }
}