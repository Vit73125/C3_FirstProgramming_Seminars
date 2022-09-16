//===================================================================================
// # 33 Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. 
//===================================================================================

int arrayLength = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите нижнюю границу заполнения массива: ");
int topBorder = ReadData("Введите верхнюю границу заполнения массива: ");

int[] inputArray = FillArray(arrayLength, downBorder, topBorder);
PrintArray(inputArray);

int elm = ReadData("Введите искомое значение: ");
PrintResult($"Значение {elm} в массиве " + (FindElem(inputArray, elm) ? "есть" : "нет"));
PrintResult($"Значение {elm} в массиве " + (FindElemIndex(inputArray, elm) >= 0 ? "есть" : "нет"));

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

// Универсальный метод генерации и заполнения массива
int[] FillArray(int num, int downBorder, int topBorder)
{
    // Генератор случайных чисел
    Random numSintezator = new Random();
    // Создаём массив
    int[] arr = new int[num];
    // Тест границ
    if (downBorder < topBorder)
    {
        // Заполняем массив
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = numSintezator.Next(downBorder, topBorder + 1);
        }
    }
    return arr;
}

// Поиск элемента Вариант 1: Да / Нет Цикл for
bool FindElem(int[] arr, int elm)
{
    bool res = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == elm)
        {
            res = true;
            break;
        }
    }
    return res;
}

// Поиск элемента Вариант 2: Номер элемента Цикл foreach
int FindElemIndex(int[] arr, int elm)
{
    bool res = false;
    int i = 0;
    foreach (int num in arr)
    {
        if (num == elm) return i;
        i++;
    }
    return -1;
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

// Вывод: результат на консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}