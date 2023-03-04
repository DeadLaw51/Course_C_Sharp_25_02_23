void Quarters(int x , int y){
    if(x ==0 || y == 0){
        Console.WriteLine("I");
    }
    if(x >0 && y > 0){
        Console.WriteLine("II");
    }
    if(x <0 && y > 0){
        Console.WriteLine("III");
    }
    if(x >0 && y < 0){
        Console.WriteLine("II");
    }
}

int num1 = int.Parse(Console.ReadLine()!);
int num2 = int.Parse(Console.ReadLine()!);
Quarters(num1,num2);
