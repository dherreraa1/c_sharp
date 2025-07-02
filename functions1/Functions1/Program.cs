using System;
public class Program {

   static double CalculateCircleArea(double radius){
        return Math.PI*radius*radius;
   } 
   static double CalculateTrapezoidArea(double a, double b, double height){
        return 0.5*height*(a+b);
   } 
   public static void Main() {

        Console.WriteLine("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = CalculateCircleArea(radius);
        Console.WriteLine("The area of the triangle is: " + area);

        Console.WriteLine("Enter side a of the trapezoid: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter side b of the trapezoid: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter height of the trapezoid: ");
        double height = Convert.ToDouble(Console.ReadLine());
        double area1 = CalculateTrapezoidArea(a,b,height);
        Console.WriteLine("The area of the trapezoid is: " + area1);

   }
}