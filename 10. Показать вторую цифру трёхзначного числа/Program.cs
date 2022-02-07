using static System.Console;

Write("Введи трехзначное число и я покажу вторую цифру в нем: ");

int n = int.Parse(ReadLine());



WriteLine(Get2(n));


string Get2(int n){


int f = n % 10;

int c = n - f ;
    if ((n>1000) || (n<100))
{
    return ("Это не трехзначное число. ");
}

return $"{c % 100/10}" ;
}
