// See https://aka.ms/new-console-template for more information

int[] numbers = { 5, 8, 3, 4, 2 };
int sum = 0;

foreach (int number in numbers)
{
    sum += number; 
}

Console.WriteLine("The sum of the numbers in the array is: " + sum);