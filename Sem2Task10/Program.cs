//===================================================================================
// # 10 Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.
//===================================================================================

int inputNumber = 0;
int result = 0;

ReadData();
CalculateData();
PrintData();

// Ввод: трёхзначное число
void ReadData()
{
    Console.Write("Введите трёхзначное число: ");
    string? inputLine = Console.ReadLine();
    if (inputLine != null) inputNumber = int.Parse(inputLine);

}

// Вычисление: вторая цифра
void CalculateData()
{
    result = (inputNumber / 10) % 10;
}

// Вывод: результат на консоль
void PrintData() {
    Console.WriteLine(result);
}