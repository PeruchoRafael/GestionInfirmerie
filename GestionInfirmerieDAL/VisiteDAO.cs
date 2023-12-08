using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInfirmerieBO;
using System.Data.SqlClient;

namespace GestionInfirmerieDAL
{
	public class VisiteDAO
	{
		private static VisiteDAO uneVisiteDAO;

		public static VisiteDAO GetuneVisiteDAO()
		{
			if (uneVisiteDAO == null)
			{
				uneVisiteDAO = new VisiteDAO();
			}
			return uneVisiteDAO;
		}

		public static List<Visite> GetVisites()
		{
			Visite uneVisite;

			// Connexion à la BD
			SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

			// Création d'une liste vide d'objets Visite
			List<Visite> lesVisites = new List<Visite>();

			SqlCommand cmd = new SqlCommand();
			cmd.Connection = maConnexion;
			cmd.CommandText = "SELECT * FROM Visite";
			SqlDataReader monReader = cmd.ExecuteReader();

			while (monReader.Read())
			{
				int numero = Int32.Parse(monReader["numero_visite"].ToString());
				DateTime date = DateTime.Parse(monReader["date_visite"].ToString());
				TimeSpan heureDebut = TimeSpan.Parse(monReader["heure_debut_visite"].ToString());
				TimeSpan heureFin = TimeSpan.Parse(monReader["heure_fin_visite"].ToString());
				string motif = monReader["motif_visite"].ToString();
				bool prevention = bool.Parse(monReader["prevention_parent"].ToString());
				bool rentre = bool.Parse(monReader["rentreChezlui"].ToString());
				bool vaHopital = bool.Parse(monReader["vaAlHopital"].ToString());
				int quantiteMedic = Int32.Parse(monReader["quantite_medic"].ToString());
				string commentaire = monReader["commentaire_visite"].ToString();
				int numeroEleve = Int32.Parse(monReader["numero_eleve"].ToString());
				int? numeroMedicament = null;
				if (!monReader.IsDBNull(monReader.GetOrdinal("numero_medicament")))
				{
					numeroMedicament = Int32.Parse(monReader["numero_medicament"].ToString());
				}

				uneVisite = new Visite(numero, date, heureDebut, heureFin, motif, prevention, rentre,
					vaHopital, quantiteMedic, commentaire, numeroEleve, numeroMedicament);
				lesVisites.Add(uneVisite);
			}
			// Fermeture de la connexion
			maConnexion.Close();

			return lesVisites;
		}

		public static bool AjoutVisite(Visite uneVisite)
		{
			bool visiteAjout = false;

			// Connexion à la BD
			SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
			SqlCommand cmd = new SqlCommand();

			cmd.Connection = maConnexion;
			cmd.CommandText = "INSERT INTO Visite (date_visite, heure_debut_visite, heure_fin_visite," +
				"motif_visite, prevention_parent, rentreChezlui, vaAlHopital, quantitie_medic," +
				"commentaire_visite, numero_eleve, numero_medicament" +
				"VALUES(@DateVisite, @HeureDebutVisite, @HeureFinVisite, @MotifVisite, " +
				"@PreventionParent, @RentreChezLui, @VaAlHopital, @QuantiteMedic, @CommentaireVisite" +
				"@NumeroEleve, @NumeroMedicament)";

			cmd.Parameters.AddWithValue("@DateVisite", uneVisite.DateVisite);
			cmd.Parameters.AddWithValue("@HeureDebutVisite", uneVisite.HeureDebutVisite);
			cmd.Parameters.AddWithValue("@HeureFinVisite", uneVisite.HeureFinVisite);
			cmd.Parameters.AddWithValue("@MotifVisite", uneVisite.MotifVisite);
			cmd.Parameters.AddWithValue("@PreventionParent", uneVisite.PreventionParent);
			cmd.Parameters.AddWithValue("@RentreChezLui", uneVisite.RentreChezLui);
			cmd.Parameters.AddWithValue("@VaAlHopital", uneVisite.VaAHopital);
			cmd.Parameters.AddWithValue("@QuantiteMedic", uneVisite.QuantiteMedic);
			cmd.Parameters.AddWithValue("@CommentaireVisite", uneVisite.CommentaireVisite);
			cmd.Parameters.AddWithValue("@NumeroEleve", uneVisite.NumeroEleve);
			cmd.Parameters.AddWithValue("@NumeroMedicament", uneVisite.NumeroMedicament);

			cmd.ExecuteNonQuery();

			// Fermeture de la connexion
			maConnexion.Close();

			return visiteAjout;
		}

		public static bool ModifVisite(Visite numVisite)
		{
			bool visiteModif = false;

			// Connexion à la BD
			SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
			SqlCommand cmd = new SqlCommand();
			cmd.Connection = maConnexion;
			cmd.CommandText = 
				"UPDATE Visite SET date_visite = @DateVisite, heure_debut_visite = @HeureDebutVisite, " +
				"heure_fin_visite = @HeureFinVisite, motif_visite = @MotifVisite, " +
				"prevention_parent = @PreventionParent, rentreChezlui = @RentreChezLui, " +
				"vaAlHopital = @VaAlHopital, quantite_medic = @QuantiteMedic," +
				"commentaire_visite = @CommentaireVisite, numero_eleve = @NumeroEleve," +
				"numero_medicament = @NumeroMedicament" +
				"WHERE numero_visite = @NumeroVisite";

			/*cmd.Parameters.AddWithValue("@DateVisite", uneVisite.DateVisite);
			cmd.Parameters.AddWithValue("@HeureDebutVisite", uneVisite.HeureDebutVisite);
			cmd.Parameters.AddWithValue("@HeureFinVisite", uneVisite.HeureFinVisite);
			cmd.Parameters.AddWithValue("@MotifVisite", uneVisite.MotifVisite);
			cmd.Parameters.AddWithValue("@PreventionParent", uneVisite.PreventionParent);
			cmd.Parameters.AddWithValue("@RentreChezLui", uneVisite.RentreChezLui);
			cmd.Parameters.AddWithValue("@VaAlHopital", uneVisite.VaAHopital);
			cmd.Parameters.AddWithValue("@QuantiteMedic", uneVisite.QuantiteMedic);
			cmd.Parameters.AddWithValue("@CommentaireVisite", uneVisite.CommentaireVisite);
			cmd.Parameters.AddWithValue("@NumeroEleve", uneVisite.NumeroEleve);
			cmd.Parameters.AddWithValue("@NumeroMedicament", uneVisite.NumeroMedicament);*/

			return visiteModif;
		}
	}
}