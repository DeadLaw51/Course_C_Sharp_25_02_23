//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Print(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Cozd(int row,int column, int from, int to ){
    int[,] arr = new int[row,column];
    for (int i = 0; i < row; i++){
        for(int j = 0; j < column; j++){
            arr[i,j] = new Random().Next(from,to);
        }
    }
    return arr;
}

int Proba(int[,] arr , int i ){
    int sum = arr[i,0];
    for(int j = 0 ; j < arr.GetLength(1); j++){
        sum += arr[i,j];
    }
    return sum;
}


Console.Write("Введите количество строк: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int stol = int.Parse(Console.ReadLine()!);
Console.Write("Введите наименьшее значение массива: ");
int nach = int.Parse(Console.ReadLine()!);
Console.Write("Введите наибольшее значение массива: ");
int fin = int.Parse(Console.ReadLine()!);

int[,] mass = Cozd(str,stol,nach,fin);
Print(mass);
int min = 0;
int sum1 = Proba(mass,0);
for(int i = 0; i < mass.GetLength(0);i++){
    int sum2 = Proba(mass,i);
    if(sum1 >sum2){
        sum1 = sum2 ;
        min = i;
    }
}
Console.WriteLine(" min = " + min);