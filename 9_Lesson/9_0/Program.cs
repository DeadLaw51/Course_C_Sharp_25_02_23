
void Val(int n ){
    if(n == 0) return;
    Val(n-1);
    Console.Write(n + " ");
}
int num = int.Parse(Console.ReadLine()!);
Val(num);