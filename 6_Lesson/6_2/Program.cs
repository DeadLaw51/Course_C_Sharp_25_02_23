// 2. Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

string Dvo(int num){
    string rez = "";
    while(num > 0){
        rez = num % 2+ rez;
        num /= 2;
    }
    return rez;
}

Console.WriteLine(Dvo(12));