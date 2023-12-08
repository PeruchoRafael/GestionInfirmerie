using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using GestionInfirmerieBO;
using GestionInfirmerieDAL;

namespace GestionInfirmerieBLL
{
    public class GestionInfirmerie
    {
        private static GestionInfirmerie uneGestionInfirmerie; // objet BLL

        // Accesseur en lecture
        public static GestionInfirmerie GetGestionInfirmerie()
        {
            if (uneGestionInfirmerie == null)
            {
                uneGestionInfirmerie = new GestionInfirmerie();
            }
            return uneGestionInfirmerie;
        }

        // Définit la chaîne de connexion grâce à la méthode SetchaineConnexion de la DAL
        public static void SetchaineConnexion(ConnectionStringSettings chset)
        {
            string chaine = chset.ConnectionString;
            ConnexionBD.GetConnexionBD().SetchaineConnexion(chaine);
        }

		#region GestionUtilisateur

		public static bool FindUtilisateur(Utilisateur ut)
        {
            return UtilisateurDAO.FindUtilisateur(ut);
        }

        // Méthode qui renvoi l’objet Utilisateur en l'ajoutant à la
        // BD avec la méthode AjoutUtilisateur de la DAL
        public static int CreerUtilisateur(Utilisateur ut)
        {
            return UtilisateurDAO.AjoutUtilisateur(ut);
        }

        // Méthode qui modifie un nouvel Utilisateur avec la méthode UpdateUtilisateur de la DAL
        public static int ModifierUtilisateur(Utilisateur ut)
        {
            return UtilisateurDAO.UpdateUtilisateur(ut);
        }

        // Méthode qui supprime un Utilisateur avec la méthode DeleteUtilisateur de la DAL
        public static int SupprimerUtilisateur(int id)
        {
            return UtilisateurDAO.DeleteUtilisateur(id);
        }

		#endregion

		#region GestionEleve

		public static List<Eleve> GetEleves()
        {
            return EleveDAO.GetEleves();
        }

        public static bool AjoutEleve(Eleve ut)
        {
            return EleveDAO.AjoutEleve(ut);
        }

        public static bool ModifEleve(Eleve ut)
        {
            return EleveDAO.ModifEleve(ut);
        }

        public static bool SupprEleve(Eleve ut)
        {
            return EleveDAO.SupprEleve(ut);
        }

		#endregion

		#region GestionClasse

		public static List<Classe> GetClasse()
        {
            return ClasseDAO.GetClasses();
        }

		#endregion

		#region GestionMedicament

		public static List<Medicament> GetMedicaments()
		{
			return MedicamentDAO.GetMedicament();
		}

		public static bool AjoutMedicament(Medicament ut)
		{
			return MedicamentDAO.AjoutMedicament(ut);
		}

		public static bool ModifMedicament(Medicament ut)
		{
			return MedicamentDAO.ModifMedicament(ut);
		}

		public static bool SupprMedicament(Medicament ut)
		{
			return MedicamentDAO.SupprMedicament(ut);
		}

        #endregion

        #region GestionVisite

        public static List<Visite> GetVisites()
        {
            return VisiteDAO.GetVisites();
        }

        public static bool AjoutVisite(Visite ut)
        {
            return VisiteDAO.AjoutVisite(ut);
        }

        public static bool ModifVisite(Visite ut)
        {
            return VisiteDAO.ModifVisite(ut);
        }

        #endregion
    }
}
