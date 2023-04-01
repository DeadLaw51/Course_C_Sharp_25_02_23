int Val(int n){
    if(n == 0) return 0;
    return Val(n / 10)+ n % 10;
}
Console.Write("Num: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(Val(num));