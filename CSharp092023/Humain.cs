using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp092023
{
    public class Humain
    {
        public Humain(string nom, string prenom, DateTime birthDate, string hairColor)
        {
            Nom = nom;
            Prenom = prenom;
            BirthDate = birthDate;
            HairColor = hairColor;
        }


        //Attributs
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime BirthDate { get; set; }

        public string HairColor { get; set; }


        //Méthodes
        public int GetAge()
        {
            int currentYear = DateTime.Now.Year;
            int BirthYear = BirthDate.Year;

            return currentYear - BirthYear;
        }

        public bool canHavePermis(int minAge)
        {
            if(GetAge() >= minAge)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}