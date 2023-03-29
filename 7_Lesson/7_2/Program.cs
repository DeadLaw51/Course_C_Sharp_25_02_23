void Cozd(int m , int n , int num){
    int[,] arr = new int[m,n];
    Random ran = new Random();
    for(int i = 0; i < m;i++){
        for(int j = 0 ; j < n ; j++){
            arr[i,j] = ran.Next(1,20);
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }

    foreach(int i in arr ){
        if (i == num ) {
            Console.WriteLine(" Yes");
            break;
        }
        else if (num > arr.Length  ){
            Console.WriteLine(" No");
        } 
    }
}

int stol,str,nu;
Console.WriteLine("Введите количество строк");
stol = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов");
str = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число для нахождения число");
nu = int.Parse(Console.ReadLine()!);


Cozd(stol,str,nu);

