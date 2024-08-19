// Задайте массив заполненный случайными трёхзначными 
// числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.

void Main()
{
    int sizeArray = ReadSizeArray("Задайте размер массива: ");
    // создадим защиту от "дурака"
    if(sizeArray < 1)
    {
        System.Console.WriteLine("Размер массива не может быть меньше 1");
        return;
    }
    int[] array = GenerateArray(sizeArray, 100, 999);
    PrintArray(array);
    System.Console.WriteLine(CountEvenNumbersInArray(array));

}
// вывод массива на экран
void PrintArray(int[] printArray)
{
    System.Console.WriteLine("[" + string.Join(", ", printArray) + "]");
}

// функция на подсчёт чётных чисел в массиве
int CountEvenNumbersInArray(int[] array)
{
    int count = 0;
    foreach(int number in array)
    {
        if(IsEvenNumber(number))
            count++;
    }
    return count;
}

// функция на поиск чётных чисел в массиве
bool IsEvenNumber(int number)
{
    if(number % 2 == 1)
        return false;
    return true;
}

// функция, чтобы задать размер массива
int ReadSizeArray(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
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



Main();