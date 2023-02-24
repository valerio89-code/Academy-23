

using CSVM;
using System;
using System.Diagnostics;
using System.Xml.Linq;
using ClassLibrary1;
using System.CodeDom;
using System.IO;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
In un file sono riportati i consumi (in kWh o in Wh) per la ricarica di auto elettriche distinte per utente (cognome, nome), 
            data (gg/mm/yyyy hh:mm:ss). Si ipotizzi che i dati del file siano relativi ad un mese.

Il tracciato è il seguente:
Cognome;Nome;Consumo;UnitàMisura;Data

Scrivere un programma che:
a) metodo per popolare il csv
1) carichi in una opportuna struttura dati in memoria i dati del file
2) dato il cognome e nome di un utente determini il consumo totale e il costo in €. 
            Il costo del kWh è letto come parametro in input (valore realistici sono 0,06243 €/kWh).
3) ripetere il punto 2) limitandolo ad un giorno della mese. Il giorno è un numero intero letto in input.
4) aggregare i dati per giorno, e trovare il consumo totale in kWh e il costo totale in €.         
             */
        }
    }   
}