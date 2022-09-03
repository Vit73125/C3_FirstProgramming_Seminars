//===================================================================================
// # 1 Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
//===================================================================================

string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    Console.WriteLine("Максимльное число: " + (int)Math.Max(inputNumberA, inputNumberB));
    Console.WriteLine("Минимальное число: " + (int)Math.Min(inputNumberA, inputNumberB));
}