int Schet(int num){
    int[] arr = new int[num];
    int rezult = 0;
    for(int i = 0;i < num; i++){
        int a = int.Parse(Console.ReadLine()!);
        arr[i] = a;
        if(arr[i] > 0 ){
                rezult++; 
        }
    } 
    return rezult;
}

int a = int.Parse(Console.ReadLine()!);
Console.WriteLine(" aaa= " + Schet(a));