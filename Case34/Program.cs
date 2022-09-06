// Задать массив, заполненный случайными положительными трехзначными числами. Написать программу, которая покажет количество четных чисел в массиве.

void FillArray(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
        index ++;
    }
}
void PrintArray(int[]coll)
{
    int count = coll.Length;
    int pos = 0;
    Console.Write("[ ");
    while (pos < count)
    {
        Console.Write(coll[pos] + " ");
        pos ++;
    }
    Console.Write(" ]");
}
Console.WriteLine("Введите количество элементов массива: ");
int a = int.Parse(Console.ReadLine());
int[]array = new int[a];
FillArray(array);
PrintArray(array);
int length = array.Length;
int j = 0;
int count = 0;
while (j < length)
{
    if (array[j]%2 == 0)
    {
        count = count + 1;
    }
    j ++;
}
Console.Write("->" + count);