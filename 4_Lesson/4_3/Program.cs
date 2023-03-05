void ArrPro(int num){
    int[] arr = new int[num];
    for(int i = 0; i <= num; i++){
        arr[i] = new Random().Next(2);
        Console.Write(arr[i] + " ");
    } 

}
int A = int.Parse(Console.ReadLine()!);
ArrPro(A);