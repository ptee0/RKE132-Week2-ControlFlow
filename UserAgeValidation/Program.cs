// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi]" / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please select your gender (m/f):"); //CW 2xtab = Console writeline

char userGender = char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis, parsime pika sõne väikseks sümboliks char

Console.WriteLine("Please, enter your last name:"); //kasutajanimi peab olema enne if blocki, sest koodi loetakse ülalt alla ja local variable (userLastName) peab olema enne deklareeritud
string userLastName = Console.ReadLine();

if (userGender == 'm')// == tähendab võrdlemist, = ei tohi olla, sest see salvestab userGender sisse uue väärtuse; " " on stringidel, ' ' on charidel
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')// else if parem, sest kui kasutaja sisestab m kontrollib if ikkagi, kas kasutaja f, kuigi on teada, et kasutaja m
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
