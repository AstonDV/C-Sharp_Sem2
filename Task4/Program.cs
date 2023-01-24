// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int check1 = num % 7;
int check2 = num % 23;
if (check1 == 0 && check2 == 0)
{
    Console.WriteLine($"Число {num} кратно одновременно числам 7 и 23");
}
else
{
    Console.WriteLine($"Число {num} не кратно одновременно числам 7 и 23");
}