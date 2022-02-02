using static System.Console;


 int n = new Random().Next(10, 100);

int a = n % 10;
int b = n / 10;

Write("Рандомное число от 10 до 99: ");

WriteLine( n );

if (a < b ) {
    
    Write("Наибольшая цифра из двух: ");
    Write(b);

}

if (a > b ) {

    Write("Наибольшая цифра из двух: ");
    WriteLine(a);
}
if (a == b) {
    Write(n);
    Write(" - Они равны");
}