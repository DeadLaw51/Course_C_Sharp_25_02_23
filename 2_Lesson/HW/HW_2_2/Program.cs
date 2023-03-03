//напишите программу которая проверяет выходной день

void Prover(int num){
    if(num <= 5 & num > 0){
        Console.WriteLine("No");
    }
    else if(num >= 6 & num <= 7){
        Console.WriteLine("YES");
    }
    else if(num >= 8 ){
        Console.WriteLine("ERROOR");
    }
}
Prover(int.Parse(Console.ReadLine()!));