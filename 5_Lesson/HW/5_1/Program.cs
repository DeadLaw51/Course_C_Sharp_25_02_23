void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to);
    return arr;
}

void SumPosNeg(int[] arr)
{
    int  rezult = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 > 0){
            rezult = rezult + arr[i];
        }
    }
    Console.WriteLine(rezult);

}

Console.WriteLine("Задайте количество элементов массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте минимальное число массива");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте максимальное число массива");
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
SumPosNeg(mass);
