int[,] Cozd(int m , int n ){
    int[,] arr = new int[m,n];
    Random ran = new Random();
    for(int i = 0; i < m;i++){
        for(int j = 0 ; j < n ; j++){
            arr[i,j] = ran.Next(1,10);
        }
    }
    return arr;
}

void Print(int[,] arr){
     for(int i = 0; i < arr.GetLength(0);i++){
        for(int j = 0 ; j < arr.GetLength(1) ; j++){
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Proba(int[,] arr){
    
    for(int j = 0 ; j < arr.GetLength(1); j++){
        double sum = 0 , rez = 0 ;
        for(int i = 0 ; i < arr.GetLength(0); i++){
            sum += arr[i,j];
        }
        rez = sum / arr.GetLength(0);
        Console.Write(rez + " ");
    }
    
}

int stol,str;
Console.WriteLine("Введите количество строк");
stol = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
str = int.Parse(Console.ReadLine()!);

int[,] mass = Cozd(stol,str);
Print(mass);
Proba(mass);