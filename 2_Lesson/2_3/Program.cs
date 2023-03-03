void KratNum(int num ){
    if(num%7 == 0 &  num%23 == 0){
        Console.WriteLine("Yes");
    }
    else {
        Console.WriteLine("No");
    }
}

KratNum(new Random().Next(10,1000));