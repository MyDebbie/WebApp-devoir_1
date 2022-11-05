using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



/// <summary>
/// @Author: Mydleyka Dimanche
/// </summary>
namespace WebApp_devoir_1
{
    public class Personne
    {
        private string _nom, _prenom1, _prenom2, _nationalite, _adresseRue, _ville, _pays, _telephone, _datecree;
        private int _age;
        private DateTime dateTime = DateTime.Now;


        /// <summary>
        /// Fist Constructor
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom1"></param>
        /// <param name="prenom2"></param>
        /// <param name="age"></param>


        public Personne(string nom, string prenom1, string prenom2, int age)
        {
            this.Nom = nom;
            this.Prenom1 = prenom1;
            this.Prenom2 = prenom2;
            this.Age = age;

        }

        /// <summary>
        /// Second Constructor
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom1"></param>
        /// <param name="prenom2"></param>
        /// <param name="age"></param>
        /// <param name="nationalite"></param>
        /// <param name="adresseRue"></param>
        /// <param name="ville"></param>
        /// <param name="pays"></param>
        /// <param name="telephone"></param>
        /// <param name="datecree"></param>

        public Personne(string nom, string prenom1, string prenom2, int age, string telephone, string adresseRue, string ville, string pays, string nationalite, string datecree)
        {
            this.Nom = nom;
            this.Prenom1 = prenom1;
            this.Prenom2 = prenom2;
            this.Age = age;
            this.Telephone = telephone;
            this.AdresseRue = adresseRue;
            this.Ville = ville;
            this.Pays = pays;
            this.Nationalite = nationalite;
            this.Datecree = datecree;

        }

        public string Nom
        {
            get => _nom;
            set { _nom = Title(value.Trim()); }
        }

        public string Prenom1
        {
            get => _prenom1;
            set { _prenom1 = Title(value.Trim()); }
        }

        public string Prenom2
        {
            get => _prenom2;
            set { _prenom2 = Title(value.Trim()); }
        }


        public string Nationalite
        {
            get => _nationalite;
            set { _nationalite = value.Trim(); }
        }

        public string AdresseRue
        {
            get => _adresseRue;
            set { _adresseRue = value.Trim(); }
        }
        public string Ville
        {
            get => _ville;
            set { _ville = value.Trim(); }
        }
        public string Pays
        {
            get => _pays;
            set { _pays = value.Trim(); }
        }
        public string Telephone
        {
            get => _telephone;
            set { _telephone = value.Trim(); }
        }
        public string Datecree
        {
            get => _datecree;
            set { _datecree = (dateTime.ToString("d")); }
        }

        public int Age
        {
            get => _age;
            set
            {
                if ((value >= 0) && (value <= 150))
                {
                    _age = value;
                }
                else
                {
                    _age = -1;
                }
            }
        }

        public override string ToString()
        {
            return Prenom1 + " " + Prenom2 + " " + Nom;

        }

        /// <summary>
        /// Method to convert fisrt letter of a string to Upper
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>

        public string Title(string t)
        {
            string b = "";
            b = char.ToUpper(t[0]) + t.Substring(1);
            return b;
        }

    }

}
