using System;
public class Program {
	public static void Main() {
        Console.WriteLine("Enter the length of the box: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the width of the box: ");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of the box: ");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("The volume of the box is: " + CalculateBoxVolume(length,width,height));

        Console.WriteLine("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int number3 = int.Parse(Console.ReadLine());
        Console.WriteLine("The average is: " + CalculateAverage(number1,number2,number3));
    }

    static int CalculateBoxVolume(int length, int width, int height){
        return length*width*height;
    }

    static int CalculateAverage(int number1, int number2, int number3){
        return (number1+number2+number3)/3;
    }
}