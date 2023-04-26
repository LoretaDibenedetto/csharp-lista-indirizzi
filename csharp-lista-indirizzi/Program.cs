// See https://aka.ms/new-console-template for more information

using csharpListaIndirizzi;
using System;
using System.Runtime.CompilerServices;


//lista di libri vuota
List<Address> listAddress = new List<Address>();
//apro file di testo
StreamReader file = File.OpenText("C:\\Users\\Elle\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\addresses.csv");

//conto le righe partendo da 0 
int countRow = 0;

//fintanto che il file non e' finito
while (!file.EndOfStream)
{
    //leggi la riga
    string line = file.ReadLine();

    //aumenta il contatore
    countRow++;

   // se il contatore delle righe lette e' maggiore di 0
    if (countRow > 1)
    {
            string[] arraySeparatedInfo = line.Split(',');
        //se l'array length e' diverso da 4 
        if (arraySeparatedInfo.Length != 6)
        {
            //stampa l'errore
            Console.WriteLine("La riga " + countRow + " non rispetta lo standard richiesto di 6 info per riga");
            //Address newAddress = new Address(arraySeparatedInfo[0], arraySeparatedInfo[1], arraySeparatedInfo[2], arraySeparatedInfo[3], arraySeparatedInfo[4], arraySeparatedInfo[5]);
            //listAddress.Add(newAddress);    
        }
        else
        {
            int zipParse = int.Parse(arraySeparatedInfo[5]);
            try
            {
                Address newAddress = new Address(arraySeparatedInfo[0], arraySeparatedInfo[1], arraySeparatedInfo[2], arraySeparatedInfo[3], arraySeparatedInfo[4], arraySeparatedInfo[5]);
                listAddress.Add(newAddress);    
            }catch(ArgumentException e)
            {
                Console.WriteLine("l'errore e': " + e.Message);
            }
        }
      }

   // Console.WriteLine(line);
    
}

foreach(Address totaddres in listAddress)
{
    Console.WriteLine(totaddres);
}