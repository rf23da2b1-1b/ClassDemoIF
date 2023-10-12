// See https://aka.ms/new-console-template for more information
using System;

//Console.WriteLine("Hello, World!");

//int pris = 20;

//if (pris > 30)
//{
//    if (pris < 60)
//    {
//        Console.WriteLine("pris mellem 30 og 60");
//    }
//    Console.WriteLine("Ja prisen er større end 60");
//    //Console.WriteLine("Endnu en linje");
//}
//else
//{
//    Console.WriteLine("Nej prisen er under eller lig med 30");
//}

//Console.WriteLine("dette er endnu en linje");


//Console.Clear();
//Console.WriteLine("Menu");
//Console.WriteLine("1: Opret");
//Console.WriteLine("2: Slet");
//Console.WriteLine("3: Hent");
//Console.WriteLine("Indtast valg: ");

//String valg = Console.ReadLine();

///*
// * Læs valg med if
// */
////if (valg == "1")
////{
////    Console.WriteLine("Du har valgt nummer 1");
////}
////else
////if (valg == "2")
////{
////    Console.WriteLine("Du har valgt nummer 2");
////}
////else
////if (valg == "3")
////{
////    Console.WriteLine("Du har valgt nummer 3");
////}
////else
////{
////    Console.WriteLine($"Du har valgt {valg} med det er ikke understøttet");
////}

///*
// * Læs valg med switch
// */
//switch (valg)
//{
//    case "1": Console.WriteLine("Du har valgt nummer 1"); break;
//    case "2": Console.WriteLine("Du har valgt nummer 2"); break;
//    case "3": Console.WriteLine("Du har valgt nummer 3"); break;

//    default: Console.WriteLine($"Du har valgt {valg} med det er ikke understøttet"); break;
//}


/*
 * Noget om i++
 */

int tal = 56;
tal++;
Console.WriteLine(  tal );

int tal2 = 56;
tal2 = tal2 + 1;
Console.WriteLine(tal2);

Console.WriteLine(  tal++ );
Console.WriteLine( tal );

Console.WriteLine( ++tal2 );


/*
 * FOR LOOPS
 */
// gennemløber et fast antal gange fx 5 gange

//for (Initialisering; betingelse; ændring)
// { ... kode ... }

// udskriver tallene fra 1 til 10
for (int i = 0; i < 10; i = i + 1)
{
    Console.WriteLine(  "Tal: " + i);
}

// udskriver fra 30 til 1
for (int i = 30; i > 0; i--)
{
    Console.WriteLine(i);
}


// OBS uendelig løkke - tæller aldrig op
//for ( int i=0; i < 10; /* tom */ )
//{
//    Console.WriteLine(i);
//}




/*
 * WHILE LOOPs
 */

// initialisering
// while ( betingelse )
// {
//     ... kode ..
//    ændring
// }


// Hvis udskrive 1 til 10 -- Reelt benyt for-loop

int ix = 0;  // init
while ( ix < 10)  // bretingelse
{
    Console.WriteLine(ix);

    ix++; // ændring
}

// ikke ved hvornår løkken slutter
string indTxt = "NotSlut";
while ( indTxt.ToLower() != "slut")
{
    Console.WriteLine(indTxt);

    Console.Write("Indtast linje Stop menes løkken stopper : ");
    indTxt = Console.ReadLine();  

}