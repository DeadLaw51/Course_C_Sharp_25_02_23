
void Prov(int num){
    int znach1 = num / 10000;
    int znach2 = (num / 1000) % 10 ;
    int znach4 = (num / 10 ) %10 ;
    int znach5 = num % 10 ;
    if(znach1 == znach5 || znach2 == znach5){
        Console.WriteLine("Yes");
    }
    else Console.WriteLine("No");
}

Prov(14212);