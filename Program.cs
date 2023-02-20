char letter = 'A'; //65 01000001
double floatingNumber = 665.52;
int number = 65;
bool tOrFalse = false;

string name = "Mathew";

Console.WriteLine((char)number);

//string? inputFromTheKeyBoard = Console.ReadLine();

Console.Write("Please enter a number between 1 - 10! ");
int numberFromKeyboard = int.Parse(Console.ReadLine());

if(numberFromKeyboard < 1 || numberFromKeyboard > 10)
{
    System.Console.WriteLine("You didn't enter the number within the given range!");
    System.Console.WriteLine("Please try again!");
    Console.Write("Please enter a number between 1 - 10! ");
    numberFromKeyboard = int.Parse(Console.ReadLine());
}

System.Console.WriteLine($"You entered the following number: {numberFromKeyboard}!");

/*
if(inputFromTheKeyBoard != null && inputFromTheKeyBoard != "")
{
    System.Console.WriteLine(inputFromTheKeyBoard[0]);
}
else
{
    System.Console.WriteLine("We skipped over the if statement code and went to the else!");
}
*/

/* this is a loop that we will talk about in Week 7
foreach(char item in name)
{
    System.Console.WriteLine(item);
}
*/