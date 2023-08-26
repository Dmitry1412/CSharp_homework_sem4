/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

System.Console.WriteLine("Введите число ");
string userDate = Console.ReadLine();
int len = userDate.Length;
int userNum = int.Parse(userDate);
int SumOfNums(int num)
{
    int result = default;
    for (int i = 0; i < len; i++)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}

int numResult = SumOfNums(userNum);
System.Console.WriteLine(numResult);