//===================================================================================
// # 29 Напишите программу, которая выводит массив из 8 элементов,
// заполненных числами в заданном диапозоне.
//===================================================================================

int arrLen = 8;
int arrMin = ReadData("Введите наименьшее значение: ");
int arrMax = ReadData("Введите наибольшее значение: ");

int[] arr = GenArray(arrLen, arrMin, arrMax);
PrintArray(arr);

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

int[] GenArray(int arrLen, int arrMin, int arrMax)
{
    int[] arr = new int[arrLen];
    Random rnd = new Random();
    for (int i = 0; i < arrLen; i++)
    {
        arr[i] = rnd.Next(arrMin, arrMax + 1);
    }
    return arr;
}


// Вывод: результат на консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}