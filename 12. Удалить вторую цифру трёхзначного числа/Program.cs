using static System.Console;

Write("Введи трехначное число и я удалю из него вторую цифру: ");

int n = int.Parse(ReadLine());

int f = n / 100;

int c = n % 10 ;

if ((n>1000) || (n<100))
{
    WriteLine("Это не трехзначное число. "); return;
}

WriteLine(f * 10 + c );


