/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// решение через Math.Pow

double numPow(double num1, double num2)
{
    double result = Math.Pow(num1, num2);
    return result;
}
System.Console.WriteLine("Введите число А ");
double userNum1 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число В ");
double userNum2 = double.Parse(Console.ReadLine());

double userResult = numPow(userNum1, userNum2);
System.Console.WriteLine($" Результат возведения числа А в степень числа В = {userResult}");
