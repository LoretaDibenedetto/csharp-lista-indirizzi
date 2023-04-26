// See https://aka.ms/new-console-template for more information

using csharpListaIndirizzi;
using System;
using System.Runtime.CompilerServices;


//lista di libri vuota
List<Address> listAddress = new List<Address>();


//prova a...
try { 

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

        //se l'array length e' diverso da 6 

       if (arraySeparatedInfo.Length != 6)
        {
            //stampa l'errore
            Console.WriteLine("La riga " + countRow + " non rispetta lo standard richiesto di 6 info per riga");
           
              
        }//altrimenti
       else if (arraySeparatedInfo.Length > 0)
        {
           // int zipParse = int.Parse(arraySeparatedInfo[5]);
           //prova a
            try
            {   
                //creare oggetto
                Address newAddress = new Address(arraySeparatedInfo[0], arraySeparatedInfo[1], arraySeparatedInfo[2], arraySeparatedInfo[3], arraySeparatedInfo[4], arraySeparatedInfo[5]);
               
                //agg oggetto alla lista
                listAddress.Add(newAddress);    

             
            }catch(ArgumentException e)
            {
                Console.WriteLine("errore nella riga n*" + countRow);
                Console.WriteLine("l'errore e': " + e.Message);
            }
        }
      }

   // Console.WriteLine(line);
    
}//se qualcosa va storto
}catch (Exception ex ) 

{ 
    Console.WriteLine(ex.Message); 
}

foreach(Address totaddres in listAddress)
{
    Console.WriteLine(totaddres);
}