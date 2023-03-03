int MaxNum(int num){
    int num1 = num % 10;
    int num2 = num / 10;
    if(num1 > num2){
        return num1;
    }
    else {
        return num2;
    }
}

int rez = MaxNum(new Random().Next(10,100));
Console.WriteLine(rez);