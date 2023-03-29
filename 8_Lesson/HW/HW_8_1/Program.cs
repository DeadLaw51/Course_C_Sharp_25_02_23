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
    for(int i = 0; i < row; i++){
        for(int j = 0 ; j < column ; j++){
            for(int q = 0; q <column -1; q++){
                if(arr[i,q] < arr[i,q + 1] ){
                    int pere = arr[i,q + 1];
                    arr[i,q+1] = arr[i,q];
                    arr[i,q] = pere;
                }
            } 
        }
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