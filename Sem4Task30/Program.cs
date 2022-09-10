//===================================================================================
// # 30 Напишите программу, которая выводит массив из 8 элементов,
// заполненных нулями и единицами в случайном порядке.
//===================================================================================

int arrLen = 8;
int[] arr = GenArray(arrLen);
PrintArray(arr);

int[] GenArray(int arrLen)
{
    int[] arr = new int[arrLen];
    Random rnd = new Random();
    for (int i = 0; i < arrLen; i++)
    {
        arr[i] = rnd.Next(0, 2);
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