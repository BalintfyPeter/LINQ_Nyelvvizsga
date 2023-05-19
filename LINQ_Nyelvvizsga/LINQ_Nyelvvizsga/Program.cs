using System.Linq;
using System.IO;
using System.Collections.Generic;


//Feladat 1 - Beolvasás
List<string> sikeres = new List<string>();
List<string> sikertelen = new List<string>();

StreamReader srSikeres = new StreamReader("sikeres.csv");
StreamReader srSikertelen = new StreamReader("sikertelen.csv");

string sorSikeres = srSikeres.ReadLine();
sikeres.Add(sorSikeres);

string sorSikertelen = srSikertelen.ReadLine();
sikeres.Add(sorSikertelen);

srSikeres.Close();
srSikertelen.Close();


//Feladat 2

//Feladat 3 - User Input
Console.WriteLine("Adjon meg egy évet 2009 és 2017 között:");
int input = Console.ReadLine();

while (input < 2009 && input > 2017)
{
    Console.WriteLine("Hibás bevitel! Adjon meg egy évet 2009 és 2017 között:");
    int input = Console.ReadLine();
}