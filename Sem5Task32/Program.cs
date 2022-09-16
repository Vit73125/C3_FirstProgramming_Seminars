//===================================================================================
// # 32 Напишите программу замена элементов массива: положительные элементы замените
// на соответствующие отрицательные, и наоборот. 
//===================================================================================

int[] inputArray = FillArray(10, -5, 5);
PrintArray(inputArray);

int[] sumArray = InversArray(inputArray);

PrintArray(inputArray);

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

int[] InversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
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