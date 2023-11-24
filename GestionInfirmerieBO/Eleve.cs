using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInfirmerieBO
{
	public class Eleve
	{
		private int numero_eleve;
		private string nom_eleve;
		private string prenom_eleve;
		private DateTime date_naissance_eleve;
		private int numero_telephone_eleve;
		private int numero_telephone_parent_eleve;
		private string tiers_temps_eleve;
		private string commentaire_sante_eleve;
		private int numero_class_eleve;

		public Eleve(string nom, string prenom, DateTime dateNaissance, int numTelEleve, int numTelParent, string tiersTemps, string commentaireSante, int numClasse)
		{
			nom_eleve = nom;
			prenom_eleve = prenom;
			date_naissance_eleve = dateNaissance;
			numero_telephone_eleve = numTelEleve;
			numero_telephone_parent_eleve = numTelParent;
			tiers_temps_eleve = tiersTemps;
			commentaire_sante_eleve = commentaireSante;
			numero_class_eleve = numClasse;
		}

		public Eleve(int numero, string nom, string prenom, DateTime dateNaissance, int numTelEleve, int numTelParent, string tiersTemps, string commentaireSante, int numClasse)
		{
			numero_eleve = numero;
			nom_eleve = nom;
			prenom_eleve = prenom;
			date_naissance_eleve = dateNaissance;
			numero_telephone_eleve = numTelEleve;
			numero_telephone_parent_eleve = numTelParent;
			tiers_temps_eleve = tiersTemps;
			commentaire_sante_eleve = commentaireSante;
			numero_class_eleve = numClasse;
		}

		public Eleve(int numero)
		{
			numero_eleve = numero;
		}

		public int NumeroEleve
		{
			get { return numero_eleve; }
			set { numero_eleve = value; }
		}

		public string NomEleve
		{
			get { return nom_eleve; }
			set { nom_eleve = value; }
		}

		public string PrenomEleve
		{
			get { return prenom_eleve; }
			set { prenom_eleve = value; }
		}

		public DateTime DateNaissanceEleve
		{
			get { return date_naissance_eleve; }
			set { date_naissance_eleve = value; }
		}

		public int NumeroTelephoneEleve
		{
			get { return numero_telephone_eleve; }
			set { numero_telephone_eleve = value; }
		}

		public int NumeroTelephoneParentEleve
		{
			get { return numero_telephone_parent_eleve; }
			set { numero_telephone_parent_eleve = value; }
		}

		public string TiersTempsEleve
		{
			get { return tiers_temps_eleve; }
			set { tiers_temps_eleve = value; }
		}

		public string CommentaireSanteEleve
		{
			get { return commentaire_sante_eleve; }
			set { commentaire_sante_eleve = value; }
		}

		public int NumeroClasseEleve
		{
			get { return numero_class_eleve; }
			set { numero_class_eleve = value; }
		}
	}
}
