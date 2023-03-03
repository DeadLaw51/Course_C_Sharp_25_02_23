
void KratNum(int num1 , int num2){
    if(num1%num2 == 0){
        Console.WriteLine("Кратно ");
    }
    else {
        Console.WriteLine($"не кратно, остаток {num1%num2}");
    }
}

KratNum(16,4);