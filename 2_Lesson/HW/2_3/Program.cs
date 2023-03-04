//напишите программу которая которая выводит 3 цифру заданного числа или сообщает, что 3 цифры нет.

void TakeNum(int num){
    Console.WriteLine(num);
    if(num < 100) Console.WriteLine("третьей цифры нет");
    else if(num >1000){
        do {
            num /= 10;
        }
        while ( num > 1000);
         int sum = num % 10;
         Console.WriteLine(sum);
    }
    else {
        int sum = num % 10;
         Console.WriteLine(sum);
    }  
}

TakeNum(new Random().Next(100,10000000));