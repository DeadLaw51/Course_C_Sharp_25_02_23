void Val(int n , int m ){
    if(n < m) return;
    Val(n - 1,m);
    if( n %2 ==0 ){
    Console.Write(n + " ");}
}
Console.Write("OT: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("DO: ");
int mut = int.Parse(Console.ReadLine()!);
Val(mut,num);
