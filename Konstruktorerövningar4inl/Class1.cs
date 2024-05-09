using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktorerövning3inl
{
    class Person
    {
        private string förnamn;
        private string efternamn;
        private string fullnamn;
        private DateTime födelsedatum;
        private float längd;
        private float vikt;

        public Person(string F, string E, int födelseår, int födelsemånad, int födelsedag, float höjd, float brädd)
        {
            förnamn = F;
            efternamn = E;
            längd = höjd;
            vikt = brädd;
            födelsedatum = new DateTime(födelseår, födelsemånad, födelsedag);
            fullnamn = förnamn + " " + efternamn;
        }
        public string getFullnamn() { return fullnamn; }

        public bool isMyndig()
        {
            DateTime eiten = DateTime.Today.AddYears(-18);
            if (födelsedatum.CompareTo(eiten) <= 0)
            {
                return true;
            }

            return false;
        }

        public float getBMI()
        {
            return vikt / (längd * längd);
        }
    }
}