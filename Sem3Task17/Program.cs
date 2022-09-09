//===================================================================================
// # 17 Напишите программу, которая по заданнЫм координатам (x и y)
// показывает номер четверти, в которой находится точка
//===================================================================================

int x = ReadData("Введите координату X: ");
int y = ReadData("Введите координату Y: ");

int res = QuarterTest(x, y);

PrintResult("Точка находится в четверти №: " + res);

// Ввод: любое число
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Определяет номер четверти
int QuarterTest(int x, int y) {
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;

    return 0;
}

// Вывод: результат на консоль
void PrintResult(string line) {
    Console.WriteLine(line);
}