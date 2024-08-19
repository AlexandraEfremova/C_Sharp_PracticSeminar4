// Напишите программу, которая перевернёт одномерный
// массив (первый элемент станет последним, второй 
// – предпоследним и т.д.)

void Main()
{
    int sizeArray = ReadSizeArray("Задайте размер массива: ");
    int[] array = GenerateArray(sizeArray, 1, 100);
    PrintArray(array);
    int[] revArray = ReverseArray(array, sizeArray);
    PrintArray(revArray);
}

// функция на разворот массива
int[] ReverseArray(int[] array, int size)
{
    int temp = 0;
    for(int i = 0; i <  size / 2; i++)
    {
        temp = array[i];
        array[i] = array[size - i - 1];
        array[size - i - 1] = temp;
    }
    return array;
}

// вывод массива на экран
void PrintArray(int[] printArray)
{
    System.Console.WriteLine("[" + string.Join(", ", printArray) + "]");
}

int[] GenerateArray(int size, int minRange, int maxRange)
{
    // задаём временный массив
    int[] tempArray = new int[size];
    // задаём переменную для того, чтобы сократить место оперативной памяти
    Random temp = new Random();
    for(int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = temp.Next(minRange, maxRange + 1);
    } 
    return tempArray;
}

// функция, чтобы задать размер массива
int ReadSizeArray(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}


Main();