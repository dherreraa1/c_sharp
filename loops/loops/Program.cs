using System;
public class Program {
   public static void Main() {

        int[] scores = {85, 90, 78, 92, 88};
        int sum = 0;
        for(int i=0;i < scores.Length; i++){
            sum += scores[i];
        }
        Console.WriteLine("Score: " +  sum);

        int number = 5;
        int factorial = 1;
        while(number >=2){
            factorial *= number;
            number--;
        }
        Console.WriteLine("Factorial: " +  factorial);

        int[] studentScores = {45, 60, 72, 38, 55};
        for(int i=0; i < studentScores.Length; i++){
            if(studentScores[i] >= 50){
            Console.WriteLine(i + " Pass");   
            }else{
                Console.WriteLine(i + " Fail");
            }
        }

        string[] weekDays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
        for(int i=0; i < weekDays.Length; i++){
            switch(weekDays[i]){
                case "Monday":
                    Console.WriteLine("Team Meeting.");
                    break;
                case "Tuesday":
                    Console.WriteLine("Code Review.");
                    break;
                case "Wednesday":
                    Console.WriteLine("Development.");
                    break;
                case "Thursday":
                    Console.WriteLine("Testing.");
                    break;
                case "Friday":
                    Console.WriteLine( "Deployment.");
                    break;
            }
        }
   }
}