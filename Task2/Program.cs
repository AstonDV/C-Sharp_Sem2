﻿// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

Console.Clear();

int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a3 = num % 10;

int newNum = (a1 * 10) + a3;

Console.WriteLine($"после удаления второй цифры числа {num} получаем число {newNum}");