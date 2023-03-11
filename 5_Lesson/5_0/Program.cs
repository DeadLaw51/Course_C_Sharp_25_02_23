void SumPosNeg(int[] arr){
    int pos=0,neg=0;

    for(int i =0; i < arr.Length;i++){
        if(arr[i] > 0)
            pos += arr[i];
        else 
            neg += arr[i];
    }
    Console.WriteLine(" pol = ");
}
