// See https://aka.ms/new-console-template for more information

//Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi). //L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
using System;

string[] cibiPreferiti = {"pane","mozzarella","yogurt","pizza","cioccoalto"};
string ciboPreferito = "pizza";
string ciboMenoPreferito = "yogurt";

//Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
//La lunghezza della classifica

Console.WriteLine(cibiPreferiti[cibiPreferiti.Length -1]);

//Stampare l'array in stile classifica, partendo dalla funzione StampaArrayStringhe e aggiungendo la posizione in classifica del cibo stampato. Ad esempio: [1° "Pizza", 2° "Pasta", 3° ...] //Il vostro cibo top (prima posizione della classifica);
//Il vostro cibo preferito ma non troppo (ultima posizione della classifica)


void stampaArrayClassificando( string[] array)
{

    int indexPreferito = Array.IndexOf(array, ciboPreferito);
    string primoElementoPrima = array[0];

    array[0] = ciboPreferito;
    array[indexPreferito] = primoElementoPrima;

    int IndexMenoPreferito = Array.IndexOf(array, ciboMenoPreferito);
    string ultimoElementoPrima = array[array.Length - 1];


    array[array.Length - 1] = ciboMenoPreferito;
    array[IndexMenoPreferito] = ultimoElementoPrima;


    for (int i = 0; i < cibiPreferiti.Length; i++)
    {
        Console.WriteLine($" {i + 1}° \" {cibiPreferiti[i]} \" ");
    }
}

stampaArrayClassificando(cibiPreferiti);


