int ProNum(int num){
    int kol =1;
    for(int i = 1 ; i <=num ; i++){
        kol = kol * i;
    }
    return kol;
}

int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(ProNum(A));
