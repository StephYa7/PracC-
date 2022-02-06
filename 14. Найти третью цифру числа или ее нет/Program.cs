using static System.Console;

WriteLine("Введи любое число, и я напишу третью цифру в нём: ");

int n = int.Parse(ReadLine());

int t = 10;


if ( n / 100 < 1 ) {
    WriteLine("Тут нет трех цифр"); return;
}

 



 while(n / t > 9){
   
     t = t * 10 ;
 }
          WriteLine(( n % (t / 10)) / (t /100) );
   