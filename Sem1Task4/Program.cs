//===================================================================================
// # 4 Напишите программу, которая принимает на вход три числа и выдаёт
// максимальное из этих чисел.
//===================================================================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();
if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);

    Console.WriteLine("Максимльное число: " + (int)Math.Max(inputNumberA, (int)Math.Max(inputNumberB, inputNumberC)));
}