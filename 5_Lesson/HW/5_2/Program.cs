void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    Random rnd = new Random();
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
        arr[i] = (rnd.NextDouble() * (to - from)) + from;
    return arr;
}

void SumPosNeg(double[] arr, int max_numb)
{
    double  rezult =0 , min = max_numb , max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max ){
            max = arr[i];  
        }
        if(arr[i]< min ){
            min = arr[i];
        }
    }
    rezult = max - min;
    Console.WriteLine("max = " + max);
    Console.WriteLine("min = " + min);
    Console.WriteLine("Rezult = " + rezult);

}

Console.WriteLine("Задайте количество элементов массива");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте минимальное число массива");
int start = int.Parse(Console.ReadLine()!);
Console.WriteLine("Задайте максимальное число массива");
int stop = int.Parse(Console.ReadLine()!);

double[] mass = MassNums(num, start, stop);
Print(mass);
SumPosNeg(mass, stop);