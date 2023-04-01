// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);
int check = num1 % num2;
if (check == 0) Console.WriteLine($"Число {num2} кратно числу {num1}");
else Console.WriteLine($"Число {num2} не кратно числу {num1}, остаток равен {check}");
