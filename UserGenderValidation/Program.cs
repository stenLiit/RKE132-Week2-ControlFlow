﻿// See https://aka.ms/new-console-template for more information


//rakendus küsib kasutajalt tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonna nime
//lähtudes kasu´taja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse (Console.ReadLine()); //loeb konsoolist maha andmeid string (sõne) formaadis

Console.WriteLine("PLease, enter your last name: ");

string userLastName = Console.ReadLine ();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");

}

else if (userGender == 'f') 
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}

else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}

