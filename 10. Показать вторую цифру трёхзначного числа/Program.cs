using static System.Console;

Write("Hello!! Enter a number and I'll show you the last digit.: ");

int n = int.Parse(ReadLine());

int f = n % 10;

int c = n - f ;

WriteLine((c % 100)/10);


