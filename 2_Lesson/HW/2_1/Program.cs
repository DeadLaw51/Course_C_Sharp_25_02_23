//напишите программу, которая выводит случайное 3-значное число и удаляет 2 цифро этого числа

void TakeNum(int num){
    Console.WriteLine(num);
    int sum = ((num / 100) * 10 ) + (num % 10);
    Console.WriteLine(sum);
}

TakeNum(new Random().Next(100,1000));