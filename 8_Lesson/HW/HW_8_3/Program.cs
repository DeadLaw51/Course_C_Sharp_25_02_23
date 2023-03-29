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

void Proba(int[,] arr1 , int[,] arr2, int[,] arrrez){
    for(int i = 0; i < arrrez.GetLength(0); i++){
        for(int j = 0; j < arrrez.GetLength(1); j++){
            int sum = 0;
            for(int q = 0 ; q < arrrez.GetLength(1); q++){
                sum += arr1[i,q] * arr2[q,j];
            }
            arrrez[i,j] = sum;
        }
    }
}


Console.Write("Введите количество строк 1 матрицы: ");
int str1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 1 матрицы: ");
int stol1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество строк 2 матрицы: ");
int str2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2 матрицы: ");
int stol2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите наименьшее значение массива: ");
int nach = int.Parse(Console.ReadLine()!);
Console.Write("Введите наибольшее значение массива: ");
int fin = int.Parse(Console.ReadLine()!);

int[,] mass1 = Cozd(str1,stol1,nach,fin);
Print(mass1);

int[,] mass2 = Cozd(str2,stol2,nach,fin);
Print(mass2);

int[,] massrez = new int[str1,stol2];
Proba(mass1,mass2,massrez);
Print(massrez);


