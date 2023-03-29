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

void Proba(int[,] arr ){
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    if(row == column){
        for(int i = 0 ; i < row ; i++){
            for(int j = 0 ; j < i ; j++){
                (arr[i,j] ,arr[j,i] ) = (arr[j,i] ,arr[i,j] );
            }
        }
    }
    else {
        Console.WriteLine(" Noooo");
        return;
    }
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
Proba(mass);
Print(mass);
