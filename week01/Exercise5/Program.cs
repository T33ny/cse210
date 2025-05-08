using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favorite_num = PromptUserNumber();
        int squared_num = SquareNumber(favorite_num);
        DisplayResult(userName, squared_num);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name; 
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number(no decimals)? ");
        int num = int.Parse(Console.ReadLine());
        return num; 
    }
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }
    static void DisplayResult(string u_name, int u_num)
    {
        Console.WriteLine($"{u_name}, the square of your number is {u_num}");
    }
}