void Kvad(int num){
    for(int i = 1 ; i <=num; i++){
        Console.Write(Math.Pow(i,3)  +" ,");
    }

}

int x = int.Parse(Console.ReadLine()!);
Kvad(x);
