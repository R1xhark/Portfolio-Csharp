using System;
using System.Collections.Generic;

namespace ToDoList
{
    // Definice třídy pro položku úkolu
    class PolozkaUkolu
    {
        public string Nazev { get; set; }
        public DateTime Datum { get; set; }
    }

    // Definice třídy pro seznam úkolů
    class SeznamUkolu
    {
        private List<PolozkaUkolu> ukoly = new List<PolozkaUkolu>();

        public void PridejUkol(PolozkaUkolu ukol)
        {
            ukoly.Add(ukol);
        }

        public void VypisUkoly()
        {
            if (ukoly.Count == 0)
            {
                Console.WriteLine("Seznam úkolů je prázdný.");
            }
            else
            {
                Console.WriteLine("Seznam úkolů:");
                foreach (PolozkaUkolu ukol in ukoly)
                {
                    Console.WriteLine($"Název: {ukol.Nazev}");
                    Console.WriteLine($"Datum: {ukol.Datum.ToString("dd.MM.yyyy")}");
                    Console.WriteLine("---");
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Vytvoření instance seznamu úkolů
            SeznamUkolu seznam = new SeznamUkolu();

            // Přidání úkolů do seznamu
            PolozkaUkolu ukol1 = new PolozkaUkolu { Nazev = "Nakoupit potrav
