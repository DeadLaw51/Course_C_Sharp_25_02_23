void Fib(int num){
    int num1 = 0;
    int num2 = 1;
    for(int i = 0 ; i < num ; i++ ){
        Console.Write(num1 + " ");
        (num1 , num2) = (num2, num1 + num2);
    }
}

int vvod = int.Parse(Console.ReadLine()!);
Fib(vvod);