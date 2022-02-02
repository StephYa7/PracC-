Console.WriteLine("Сейчас мы проверим является ли первое число квадратом второго");

Console.Write ("Введимте первое число: ");
string x = Console.ReadLine();

Console.Write ("Введите второе число: ");
string y = Console.ReadLine();

int xc = int.Parse(x);
int yc = int.Parse(y);

if (yc * yc == xc){

Console.Write("Да это его квадрат");
}

else {

Console.Write("Ну нет же" );    
}





