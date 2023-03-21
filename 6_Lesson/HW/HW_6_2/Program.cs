void Toch(int b1,int k1,int b2, int k2){
    
    double x = -(b1 + b2 ) / (k1 + k2);
    double y = k1 * x + b1; 
    
    Console.WriteLine(x + " " + y);
}

int x1,y1,x2,y2;
x1 = int.Parse(Console.ReadLine()!);
y1 = int.Parse(Console.ReadLine()!);
x2 = int.Parse(Console.ReadLine()!);
y2 = int.Parse(Console.ReadLine()!);

Toch(x1,y1,x2,y2);