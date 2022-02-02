Console.WriteLine("Сейчас я определю самое бьольшое число из 3х тобой написаных");

Console.Write ("Введи первое число: ");
string xc = Console.ReadLine();


int x = int.Parse(xc);


Console.Write ("Введи второе число: ");
string yc = Console.ReadLine();


int y = int.Parse(yc);


Console.Write ("Введи третее число: ");
string zc = Console.ReadLine();


int z = int.Parse(zc);

int max  ;

if (x < y ){

    max = y;
}

else {
 max = x ;
}

if (max < z){
    max = z;
}
 
Console.WriteLine("Самое большое число: ");
Console.WriteLine(max);