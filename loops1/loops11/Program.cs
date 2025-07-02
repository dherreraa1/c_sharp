using System;
using System.ComponentModel;
public class Program {
   public static void Main() {

        int input;
        do{
            Console.WriteLine("Write an even number between 1 and 10: ");
            input = int.Parse(Console.ReadLine());
            if(input >=1 && input <=10 && input % 2 == 0){
                Console.WriteLine("Good!");
                break;
            } else {
                Console.WriteLine("Wrong, do it again!");
            }
        }while(true);

        int[] grades = {68, 75, 58, 92, 88};
        for(int i=0; i < grades.Length; i++){
            if(grades[i] >= 65){
                Console.WriteLine(i + " Pass");
            }else {
                Console.WriteLine(i + " Fail");
            }
        }

        string[] orderStatuses = {"Pending","Shipped","Delivered","Cancelled"};
        for(int i=0; i < orderStatuses.Length; i++){
            switch(orderStatuses[i]){
                case "Pending":
                    Console.WriteLine("Order pending");
                    break;
                case "Shipped":
                    Console.WriteLine("Order shipped");
                    break;
                case "Delivered":
                    Console.WriteLine("Order delivered");
                    break;
                case "Cancelled":
                    Console.WriteLine("Order cancelled");
                    break;
            }
        }

        for(int i=0; i < grades.Length; i++){
            switch(grades[i]){
                case int n when (n>=90):
                    Console.WriteLine(i + " A");
                    break;
                case int n when (n>=80 && n <= 89):
                    Console.WriteLine(i + " B");
                    break;
                case int n when (n>=70 && n <= 79):
                    Console.WriteLine(i + " C");
                    break;
                case int n when (n>=60 && n <= 69):
                    Console.WriteLine(i + " D");
                    break;
                case int n when (n < 60):
                    Console.WriteLine(i + " F");
                    break;
            }
        }

   }

}