using static System.Console;



WriteLine("Найдем ряд чисел от -N до N");

Write("Введите число N: ");

int n = int.Parse(ReadLine());

int t = -n ;

while (t <= n ){
    Write( t ); Write(" ");

    t ++;
}




