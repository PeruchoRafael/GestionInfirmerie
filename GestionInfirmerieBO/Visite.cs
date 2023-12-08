using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInfirmerieBO
{
	public class Visite
	{
		private int numero_visite;
		private DateTime date_visite;
		private TimeSpan heure_debut_visite;
		private TimeSpan heure_fin_visite;
		private string motif_visite;
		private bool prevention_parent;
		private bool rentre_chez_lui;
		private bool va_a_hopital;
		private int quantite_medic;
		private string commentaire_visite;
		private int numero_eleve;
		private int numero_medicament;

        public Visite(int numero, DateTime date, TimeSpan heureDebut, TimeSpan heureFin, string motif,
            bool prevention, bool rentre, bool vaHopital, int quantite, string commentaire,
            int num_eleve, int? num_medicament)
        {
            numero_visite = numero;
            date_visite = date;
            heure_debut_visite = heureDebut;
            heure_fin_visite = heureFin;
            motif_visite = motif;
            prevention_parent = prevention;
            rentre_chez_lui = rentre;
            va_a_hopital = vaHopital;
            quantite_medic = quantite;
            commentaire_visite = commentaire;
            numero_eleve = num_eleve;
            numero_medicament = num_medicament.HasValue ? num_medicament.Value : 0;
        }


        public Visite(DateTime date, TimeSpan heureDebut, TimeSpan heureFin, string motif,
            bool prevention, bool rentre, bool vaHopital, int quantite, string commentaire,
            int num_eleve, int? num_medicament)
        {
            date_visite = date;
            heure_debut_visite = heureDebut;
            heure_fin_visite = heureFin;
            motif_visite = motif;
            prevention_parent = prevention;
            rentre_chez_lui = rentre;
            va_a_hopital = vaHopital;
            quantite_medic = quantite;
            commentaire_visite = commentaire;
            numero_eleve = num_eleve;
            numero_medicament = num_medicament.HasValue ? num_medicament.Value : 0;
        }

        public int NumeroVisite
        {
            get { return numero_visite; }
            set { numero_visite = value; }
        }

        public DateTime DateVisite
        {
            get { return date_visite; }
            set { date_visite = value; }
        }

        public TimeSpan HeureDebutVisite
        {
            get { return heure_debut_visite; }
            set { heure_debut_visite = value; }
        }

        public TimeSpan HeureFinVisite
        {
            get { return heure_fin_visite; }
            set { heure_fin_visite = value; }
        }

        public string MotifVisite
        {
            get { return motif_visite; }
            set { motif_visite = value; }
        }

        public bool PreventionParent
        {
            get { return prevention_parent; }
            set { prevention_parent = value; }
        }

        public bool RentreChezLui
        {
            get { return rentre_chez_lui; }
            set { rentre_chez_lui = value; }
        }

        public bool VaAHopital
        {
            get { return va_a_hopital; }
            set { va_a_hopital = value; }
        }

        public int QuantiteMedic
        {
            get { return quantite_medic; }
            set { quantite_medic = value; }
        }

        public string CommentaireVisite
        {
            get { return commentaire_visite; }
            set { commentaire_visite = value; }
        }

        public int NumeroEleve
        {
            get { return numero_eleve; }
            set { numero_eleve = value; }
        }

        public int NumeroMedicament
        {
            get { return numero_medicament; }
            set { numero_medicament = value; }
        }
    }
}
