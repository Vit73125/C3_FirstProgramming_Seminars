﻿//===================================================================================
// # 7 Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает последнюю цифру этого числа.
//===================================================================================

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if (inputNumber > 99 && inputNumber < 1000)
    {
        int lastDigit = inputNumber % 10;
        Console.WriteLine(lastDigit);
    }
}