void Toch(double b1,double k1,double b2, double k2){
    
    double x = -((b1 - b2 ) / (k1 - k2));
    double y = k1 * x + b1; 
    
    Console.WriteLine(x + " " + y);
}



double x1,y1,x2,y2;
x1 = double.Parse(Console.ReadLine()!);
y1 = double.Parse(Console.ReadLine()!);
x2 = double.Parse(Console.ReadLine()!);
y2 = double.Parse(Console.ReadLine()!);

Toch(x1,y1,x2,y2);