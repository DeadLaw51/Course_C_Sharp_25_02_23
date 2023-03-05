int SumNum(int num){
    int all_sum = 0;
    for(int i = 1 ; i <= num ; i++)
        all_sum +=1;

    return all_sum ;
}

int A = int.Parse(Console.ReadLine()!);
int rez = SumNum(A);

