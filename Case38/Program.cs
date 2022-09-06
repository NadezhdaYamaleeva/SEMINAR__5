// Задать массив вещественных чисел. Найти разницу между максимальным и минимальным элементами массива.
void FillArray(double[]collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index ++;
    }
}
void PrintArray(double[]coll)
{
    int count = coll.Length;
    int pos = 0;
    Console.Write("[ ");
    while (pos < count)
    {
        Console. Write(coll[pos] + " ");
        pos ++;
    }
    Console.Write(" ]");
}
Console.WriteLine("Введите количество элементов массива: ");
int a = int.Parse(Console.ReadLine());
double[]array = new double[a];
FillArray(array);
PrintArray(array);
double max = array[0];
int i = 0;
while (i < array.Length)
{
    if (max < array[i])
    {
        max = array[i];
    }
    i ++;
}
double min = array[0];
int ind = 0;
while (ind < array.Length)
{
    if (min > array[ind])
    {
        min = array[ind];
    }
    ind ++;
}
double div = max - min;
Console.Write("->" + div);
