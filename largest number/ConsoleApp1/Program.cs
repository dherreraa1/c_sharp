// See https://aka.ms/new-console-template for more information
// Initialize an array of integers
int[] numbers = { 5, 8, 3, 4, 2 };
int largest = numbers[0];


// Loop through each number in the array
foreach (int number in numbers)
{
    // Check if the current number is greater than the largest
    if (number > largest)
    {
        largest = number;
    }
}


// Output the largest number
Console.WriteLine("The largest number is: " + largest);