using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInfirmerieBO;
using System.Data.SqlClient;

namespace GestionInfirmerieDAL
{
	public class EleveDAO
	{
		private static EleveDAO unEleveDAO;

		public static EleveDAO GetunEleveDAO()
		{
			if (unEleveDAO == null)
			{
				unEleveDAO = new EleveDAO();
			}
			return unEleveDAO;
		}

		public static List<Eleve> GetEleves()
		{
			Eleve unEleve;

			// Connexion à la BD
			SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

			// Création d'une liste vide d'objets Eleve
			List<Eleve> lesEleves = new List<Eleve>();

			SqlCommand cmd = new SqlCommand();
			cmd.Connection = maConnexion;
			cmd.CommandText = "SELECT * FROM Eleve";
			SqlDataReader monReader = cmd.ExecuteReader();

			// Remplissage de la liste
			while (monReader.Read())
			{
				int numero = Int32.Parse(monReader["numero_eleve"].ToString());
				string nom = monReader["nom_eleve"].ToString();
				string prenom = monReader["prenom_eleve"].ToString();
				DateTime dateNaissance = DateTime.Parse(monReader["dateNaissance_eleve"].ToString());
				int numTelEleve = Int32.Parse(monReader["numeroTelephone_eleve"].ToString());
				int numTelParent = Int32.Parse(monReader["numeroTelephoneParent"].ToString());
				string tiersTemps = monReader["tiersemps_eleve"].ToString();
				string commentaire = monReader["commentaireSante"].ToString();
				int numClasse = Int32.Parse(monReader["numero_classe"].ToString());

				unEleve = new Eleve(numero, nom, prenom, dateNaissance, numTelEleve, numTelParent, tiersTemps, commentaire, numClasse);
				lesEleves.Add(unEleve);
			}
			// Fermeture de la connexion
			maConnexion.Close();

			return lesEleves;
		}

		// Cette méthode insert un nouvel eleve passé en paramètre dans la BD
		public static bool AjoutEleve(Eleve unEleve)
		{
			bool eleveAjout = false;

			// Connexion à la BD
			SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
			SqlCommand cmd = new SqlCommand();

			cmd.Connection = maConnexion;
			cmd.CommandText = "INSERT INTO Eleve (nom_eleve, prenom_eleve, dateNaissance_eleve, numeroTelephone_eleve, " +
				"numeroTelephoneParent, tiersemps_eleve, commentaireSante, numero_classe) " +
				"VALUES(@NomEleve, @PrenomEleve, @DateNaissanceEleve, @NumeroTelephoneEleve, " +
				"@NumeroTelephoneParentEleve, @TiersTempsEleve, @CommentaireSanteEleve, @NumeroClasseEleve)";

			cmd.Parameters.AddWithValue("@NomEleve", unEleve.NomEleve);
			cmd.Parameters.AddWithValue("@PrenomEleve", unEleve.PrenomEleve);
			cmd.Parameters.AddWithValue("@DateNaissanceEleve", unEleve.DateNaissanceEleve);
			cmd.Parameters.AddWithValue("@NumeroTelephoneEleve", unEleve.NumeroTelephoneEleve);
			cmd.Parameters.AddWithValue("@NumeroTelephoneParentEleve", unEleve.NumeroTelephoneParentEleve);
			cmd.Parameters.AddWithValue("@TiersTempsEleve", unEleve.TiersTempsEleve);
			cmd.Parameters.AddWithValue("@CommentaireSanteEleve", unEleve.CommentaireSanteEleve);
			cmd.Parameters.AddWithValue("@NumeroClasseEleve", unEleve.NumeroClasseEleve);

			cmd.ExecuteNonQuery();

			// Fermeture de la connexion
			maConnexion.Close();

			return eleveAjout;
		}

		public static bool ModifEleve(Eleve numEleve)
		{
			bool eleveModif = false;

			// Connexion à la BD
			SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = maConnexion;
			cmd.CommandText = "UPDATE Eleve SET nom_eleve = @NomEleve, prenom_eleve = @PrenomEleve, " +
				"dateNaissance_eleve = @DateNaissanceEleve, numeroTelephone_eleve = @NumeroTelephoneEleve, " +
				"numeroTelephoneParent = @NumeroTelephoneParentEleve, tiersemps_eleve = @TiersTempsEleve, " +
				"commentaireSante = @CommentaireSanteEleve, numero_class = @NumeroClasseEleve WHERE numero_eleve = @NumeroEleve";

			/*cmd.Parameters.AddWithValue("@NomEleve", unEleve.NomEleve);
			cmd.Parameters.AddWithValue("@PrenomEleve", unEleve.PrenomEleve);
			cmd.Parameters.AddWithValue("@DateNaissanceEleve", unEleve.DateNaissanceEleve);
			cmd.Parameters.AddWithValue("@NumeroTelephoneEleve", unEleve.NumeroTelephoneEleve);
			cmd.Parameters.AddWithValue("@NumeroTelephoneParentEleve", unEleve.NumeroTelephoneParentEleve);
			cmd.Parameters.AddWithValue("@TiersTempsEleve", unEleve.TiersTempsEleve);
			cmd.Parameters.AddWithValue("@CommentaireSanteEleve", unEleve.CommentaireSanteEleve);
			cmd.Parameters.AddWithValue("@NumeroClasseEleve", unEleve.NumeroClasseEleve);*/

			return eleveModif;
		}

		public static bool SupprEleve(Eleve numEleve)
		{
			bool supprEleve = false;

			// Connexion à la BD
			SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
			SqlCommand cmd = new SqlCommand();

			cmd.Connection = maConnexion;
			cmd.CommandText = "DELETE FROM Eleve WHERE numero_eleve = @NumeroEleve";
			
			cmd.Parameters.AddWithValue("@NumeroEleve", numEleve.NumeroEleve);

			cmd.ExecuteNonQuery();

			return supprEleve;
		}
	}
}
