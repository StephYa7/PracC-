using static System.Console;

Write("Введи трехначное число и я удалю из него вторую цифру: ");

int n = int.Parse(ReadLine());

int f = n / 100;

int c = n % 10 ;


WriteLine(Del2(n));


string Del2(int n){

if ((n>1000) || (n<100))
{
   return("Это не трехзначное число. ");
}

return $"{f * 10 + c }" ;
}

