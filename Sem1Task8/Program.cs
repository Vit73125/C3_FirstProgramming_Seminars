//===================================================================================
// # 8 Напишите программу, которая на вход принимает число (N), а на
// выходе показывает все чётные числа от 1 до N.
//===================================================================================

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    int countNumber = 2;

    while (countNumber <= inputNumber)
    {
        Console.Write(countNumber + " ");
        countNumber += 2;
    }
}