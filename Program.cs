//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

System.Console.WriteLine("Imput number of 5 length");
string? number = Console.ReadLine();

if (number!.Length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        System.Console.WriteLine("yes");
    }
    else
    {
        System.Console.WriteLine("No");
    }
}
else
{
    System.Console.WriteLine("wrong");
}