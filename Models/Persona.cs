using System;
using System.Dynamic;
namespace bertozzi.mattia._5H.OopCsv.Models
{
    public class Persona
    {
        //Property della classe
        public int ID {get;set;}
        public string Nome {get;set;}
        public string Cognome {get;set;}
        public int Ore {get;set;}

        //override del metodo per Visualizzare in stringa
        public override string ToString()
        {
            return String.Format("{0,-5} | {1,-10} | {2,-10} | {3,-10}", $"{ID}", $"{Nome}", $"{Cognome}", $"{Ore}");
        }
    }
}