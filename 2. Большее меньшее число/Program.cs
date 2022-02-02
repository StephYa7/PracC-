Console.WriteLine("Сейчас я помогу тебе определить какое же число больше: ");

Console.Write ("Введимте первое число: ");
string x = Console.ReadLine();

Console.Write ("Введите второе число: ");
string y = Console.ReadLine();

int xc = int.Parse(x);
int yc = int.Parse(y);

if (yc > xc ){

Console.Write("Второе конечно больше");
}

if (yc < xc ) {

Console.Write(" Очевидно что первое больше" );    
}

if (yc == xc ) {

Console.Write("  Они равны. Я хоть и робот, но меня не обманешь. " );

}


