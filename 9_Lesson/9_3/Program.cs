int Val(int n,int s){
    if(s == 0) return 1;
    return Val(n , s-1) *n;
}
Console.Write("Num: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Stepen: ");
int rez = int.Parse(Console.ReadLine()!);
Console.WriteLine(Val(num,rez));
