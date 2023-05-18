// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"

using System.Runtime.Intrinsics.X86;

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); // "13" - otsib heapist, 13 - ilma jutumärkideta salvestatakse stacki, seega oleks vaja 13 salvestada arvuna => vaja salvestada "int" tüüpi muutuja sisse; Kuna Console.ReadLine tagastab ainult stringi, nii et vaja parse

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("You are too young to use Instagram.");
}

//kui Int32.Parse(Console.ReadLine()) asemel oleks lihtsalt Console.ReadLine(), siis võrdleks teksti numbriga