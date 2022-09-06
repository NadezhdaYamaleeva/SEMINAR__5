// Задать одномерный массив, заполненный случайными числами. Найти сумму элементов, стоящих на нечетных позициях.
void FillArray(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-100, 100);
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
int b = 0;
int i = 1;
while (i < array.Length)
{
    b = b + array[i];
    i = i + 2;
}
Console.Write("->" + b);