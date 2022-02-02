using static System.Console;

WriteLine("Введи два числа, я проверю делится ли первое на второе, и если нет покажу остаток.");
Write("Введи первое число:");

int n = int.Parse(ReadLine());

Write("Введи второе число: ");

int t =int.Parse(ReadLine());

if ( n < t){
    WriteLine("Первое число должно быть больше второго");
}

else if (n % t == 0){

    WriteLine("Без остатка");
}

else if (n % t != 0)
{
    Write("Остаток = ");
    Write( n % t);
}



