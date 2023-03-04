void Koord(int nam){
    if(nam == 1){
        Console.WriteLine("x =(0 ... N) , y =(0 ... N)");
    }
    else if(nam == 2){
        Console.WriteLine("x =(0 ... -N) , y =(0 ... N)");
    }
    else if(nam == 3){
        Console.WriteLine("x =(0 ... -N) , y =(0 ... -N)");
    }
    else if(nam == 4){
        Console.WriteLine("x =(0 ... N) , y =(0 ... -N)");
    }
    else Console.WriteLine("ERROOOOR");
}
 int x = int.Parse(Console.ReadLine()!);
 Koord(x);
