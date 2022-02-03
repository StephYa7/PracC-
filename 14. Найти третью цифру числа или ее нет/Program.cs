using static System.Console;

WriteLine("Введи любое число, и я напишу третью цифру в ней: ");

int n = int.Parse(ReadLine());

int t = 1000


if ( n / 100 < 1){
    WriteLine("Тут нет третьего числа");
}

 else if (n < 1000){
     WriteLine( n % 10 );
 }




 //else if (n < 10000){
 //    WriteLine(( n % 10 - n % 1 ) / 1);
 //}
// Надо придумать формулу
