/* массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76 */

int[] InitArray(int length)
{
    int[] resultArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = rnd.Next(1, 100);
    }
    return resultArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}

int GetNumber(string message)
{
   Console.WriteLine(message);
   int result = int.Parse(Console.ReadLine());
   return result;
}

int GetMin(int[] array)
{
    int minValue = array[0];  
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < minValue)
        {
            minValue = array[i];
        }
    }
    return minValue;
}

int GetMax(int[] array)
{
    int maxValue = array[0];  
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] > maxValue)
        {
            maxValue = array[i];
        }
    }
    return maxValue;
}

int length = GetNumber("Введите размер массива:");
int[] arr = InitArray(length);
PrintArray(arr);
int max = GetMax(arr);
int min = GetMin(arr);
int result = max - min;
Console.WriteLine($"Разница между макс и мин: {result}");