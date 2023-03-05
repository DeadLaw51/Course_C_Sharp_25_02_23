//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void KvadNum(int num, int step){
    int rezult = 1;
    for(int i = 0; i < step ; i++ ){
        rezult *= num;
    }
    Console.WriteLine("Результат = " + rezult);
}
Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень в которую хотите ввести число  " + a);
int b = int.Parse(Console.ReadLine()!);
KvadNum(a,b);