void Cozd(int m , int n){
    double[,] arr = new double[m,n];
    Random rn = new Random();
    double rnd= rn.NextDouble();
    for(int i = 0; i < m;i++){
        for(int j = 0 ; j < n ; j++){
            arr[i,j] = (9 * rnd) + 1;
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int stol,str;
stol = int.Parse(Console.ReadLine()!);
str = int.Parse(Console.ReadLine()!);

Cozd(stol,str);