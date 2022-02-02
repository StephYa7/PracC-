using static System.Console;



WriteLine("Сейчас я напишу тебе ряд четных чисел, до указанноготобой числа, и это не магия )");

Write("Введите число: ");

int n = int.Parse(ReadLine());

int t = 1 ;

while (t <= n ){

if( t % 2 == 0)

    Write( t ); Write(" ");

    t ++;
}


