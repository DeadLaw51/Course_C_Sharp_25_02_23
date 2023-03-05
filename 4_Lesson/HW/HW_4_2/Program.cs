//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void Arrow(){
    int[] arr = new int[8];
    for(int i = 0 ; i < 8; i++){
        arr[i] = new Random().Next(100);
        Console.Write(arr[i] + " ");
    }

    Console.WriteLine();

    for(int j = 0 ; j <8 ; j++){
        Console.Write(arr[j] + " ");
    }
}
Arrow();