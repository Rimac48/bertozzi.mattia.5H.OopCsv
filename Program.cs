using System.Reflection;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Dynamic;
using System.Net.Sockets;
using System.Threading;
using System.Xml.Linq;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.ComponentModel.Design.Serialization;
using System;
using bertozzi.mattia._5H.OopCsv.Models;
using System.Collections.Generic;

namespace bertozzi.mattia._5H.OopCsv
{
    class Program
    {
        static void Main(string[] args)
        {
            //lista di Persona
            List<Persona> Persone = new List<Persona>();

            //prendo il file e lo leggo
            StreamReader rd = new StreamReader("Models/in.csv");

            //legge la prima linea--> ID;Nome;Cognome;OreLezione
            string line = rd.ReadLine();

            while (!rd.EndOfStream)
            {
                //quindi questa legge dalla seconda linea in poi
                line = rd.ReadLine();
                string[] colonne = line.Split(';');

                //utilizzo del costruttore
                Persona p = new Persona
                {
                    ID = Convert.ToInt32(colonne[0]),
                    Nome = colonne[1],
                    Cognome = colonne[2],
                    Ore = Convert.ToInt32(colonne[3]),
                };

                //aggiunta dell'elemento  alla lista persone
                Persone.Add(p);
            }

            //ciclo che serve alla visualizzazione della lista
            foreach(Persona p in Persone)
            {
                Console.WriteLine(p);
            }
        }
    }
}
