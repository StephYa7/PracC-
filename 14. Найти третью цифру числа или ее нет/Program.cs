using static System.Console;

WriteLine("Введи любое число, и я напишу третью цифру в нём: ");

int n = int.Parse(ReadLine());

int t = 10;



WriteLine(Get3(n));


string Get3(int n)
{

if ( n / 100 < 1 ) {
    return("Тут нет трех цифр");
}

 



 while(n / t > 9){
   
     t = t * 10 ;
 }
          return $"{(( n % (t / 10)) / (t /100) )}";
}