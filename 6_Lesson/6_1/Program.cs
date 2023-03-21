void Trin(int a, int b, int c){
    if(a < b + c && b < a + c && c < a + b ){
        Console.WriteLine(" Yes");
    }
    else Console.WriteLine("Noooo");
}

int A,B,C;
A = int.Parse(Console.ReadLine()!);
B = int.Parse(Console.ReadLine()!);
C = int.Parse(Console.ReadLine()!);
Trin(A,B,C);