//напишите программу, которая принимает на вход 3-значное число и на выход показывает 2 цифру этого числа

void TakeNum(int num){
    Console.WriteLine(num);
    int sum = (num / 10) % 10;
    Console.WriteLine(sum);
}

TakeNum(new Random().Next(100,1000));