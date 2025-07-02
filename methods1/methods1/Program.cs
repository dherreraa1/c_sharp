using System;
public class Program {
	public static void Main() {
        DisplayWelcomeMessage();
        GreetUser("Mati");
        Console.WriteLine("Sum of 4 and 7 is: " + CalculateSum(4,7));
        Console.WriteLine("Is 9 positive? " + IsPositive(9));
        Console.WriteLine("Is -5 positive? " + IsPositive(-5));
        Console.WriteLine("Indicate your age: ");
        int age = int.Parse(Console.ReadLine());
        if(IsOldEnoughToDrive(age)){
            Console.WriteLine("You are old enough to drive.");
        }else{
            Console.WriteLine("You are not old enough to drive.");
        }
    }

   static void DisplayWelcomeMessage(){
        Console.WriteLine("Welcome to our Program!");
   } 
   static void GreetUser(string name){
        Console.WriteLine("Hello " + name);
   } 
   static int CalculateSum(int a, int b){
        return a+b;
   } 

   static bool IsPositive(int number){
        return number > 0;
   }

    static bool IsOldEnoughToDrive(int age){
        return age >= 18;
   }
}