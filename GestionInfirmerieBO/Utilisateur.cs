using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInfirmerieBO
{
    public class Utilisateur
    {
        // Attributs
        private int numero_utilisateur;
        private string email_utilisateur;
        private string mot_de_passe_utilisateur;

        // Constructeur à 2 paramètres
        public Utilisateur(int numero, string email)
        {
            numero_utilisateur = numero;
            email_utilisateur = email;
        }

        // Constructeur à 2 paramètres
        public Utilisateur(string email, string motDePasse)
        {
            email_utilisateur = email;
            mot_de_passe_utilisateur = motDePasse;
        }

        // Propriétés avec getter et setter
        public int NumeroUtilisateur
        {
            get { return numero_utilisateur; }
            set { numero_utilisateur = value; }
        }

        public string EmailUtilisateur
        {
            get { return email_utilisateur; }
            set { email_utilisateur = value; }
        }

        public string MotDePasseUtilisateur
        {
            get { return mot_de_passe_utilisateur; }
            set { mot_de_passe_utilisateur = value; }
        }
    }
}
