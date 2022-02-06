using static System.Console;

Write("Введи трехзначное число и я покажу вторую цифру в нем: ");

int n = int.Parse(ReadLine());

int f = n % 10;

int c = n - f ;

if ((n>1000) || (n<100))
{
    WriteLine("Это не трехзначное число. "); return;
}

WriteLine((c % 100)/10);


