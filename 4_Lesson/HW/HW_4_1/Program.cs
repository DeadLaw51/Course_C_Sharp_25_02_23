//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

void SumNum(int num){
    int znach = 0 , kol = 0;
    for(int i = 0; num > 0; i++){
        znach = num % 10;
        num /= 10;
        kol += znach; 
    }
    Console.WriteLine(kol);
}
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine()!);
SumNum(a);