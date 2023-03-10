//  Напишите метод, который задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


int GetIncomingData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int length)
{
    return new int[length];
}

void Print(int[] array)
{
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        if (index == size - 1)
        {
            Console.Write(array[index]);
        }
        else
        {
            Console.Write($"{array[index]},");
        }
        ++index;
    }
    Console.WriteLine();

}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

int length = GetIncomingData("Введите длину массива");
int[] arr = CreateArray(length);
FillArray(arr);
Print(arr);