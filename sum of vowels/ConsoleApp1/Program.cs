// See https://aka.ms/new-console-template for more information
string word = "wonderful";
int sum = 0;

foreach (char letter in word.ToLower())
{
    if(letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u'){
        sum++;
    } 
}

Console.WriteLine("The amount of vowels is: " + sum);