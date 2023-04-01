int Val(int n , int m ){
    if(n < m) return 0;
    return Val(n - 1,m) + n;
}
Console.Write("OT: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("DO: ");
int mut = int.Parse(Console.ReadLine()!);
Console.Write(Val(mut,num));