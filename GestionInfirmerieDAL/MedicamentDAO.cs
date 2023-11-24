using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInfirmerieBO;
using System.Data.SqlClient;

namespace GestionInfirmerieDAL
{
	public class MedicamentDAO
	{
		private static MedicamentDAO unMedicamentDAO;

		public static MedicamentDAO GetunMedicamentDAO()
		{
			if (unMedicamentDAO == null)
			{
				unMedicamentDAO = new MedicamentDAO();
			}
			return unMedicamentDAO;
		}

		public static List<Medicament> GetMedicament()
		{
			int numero;
			string nom;

			Medicament unMedicament;

			// Connexion à la BD
			SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

			// Création d'une liste vide d'objets Classe
			List<Medicament> lesMedicaments = new List<Medicament>();

			SqlCommand cmd = new SqlCommand();
			cmd.Connection = maConnexion;
			cmd.CommandText = " SELECT * FROM Medicament";
			SqlDataReader monReader = cmd.ExecuteReader();

			// Remplissage de la liste
			while (monReader.Read())
			{
				numero = Int32.Parse(monReader["numero_medicament"].ToString());
				if (monReader["nom_medicament"] == DBNull.Value)
				{
					nom = default(string);
				}
				else
				{
					nom = monReader["nom_medicament"].ToString();
				}
				unMedicament = new Medicament(numero, nom);
				lesMedicaments.Add(unMedicament);
			}
			// Fermeture de la connexion
			maConnexion.Close();

			return lesMedicaments;
		}

		public static bool AjoutMedicament(Medicament unMedicament)
		{
			bool medicamentAjout = false;

			// Connexion à la BD
			SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
			SqlCommand cmd = new SqlCommand();

			cmd.Connection = maConnexion;
			cmd.CommandText = "INSERT INTO Medicament (nom_medicament) VALUES (@NomMedicament)";

			cmd.Parameters.AddWithValue("@NomMedicament", unMedicament.NomMedicament);

			cmd.ExecuteNonQuery();

			maConnexion.Close();

			return medicamentAjout;
		}

		public static bool ModifMedicament(Medicament numMedicament)
		{
			bool medicamentModif = false;

			// Connexion à la BD
			SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
			SqlCommand cmd = new SqlCommand();

			cmd.Connection = maConnexion;
			cmd.CommandText = "UPDATE Medicament SET nom_medicament = @NomMedicament WHERE numero_medicament = @NumeroMedicament";

			//cmd.Parameters.AddWithValue("@NomMedicament", nouveauNom);

			cmd.ExecuteNonQuery();

			maConnexion.Close();

			return medicamentModif;
		}

		public static bool SupprMedicament(Medicament numMedicament)
		{
			bool medicamentSuppr = false;

			// Connexion à la BD
			SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
			SqlCommand cmd = new SqlCommand();

			cmd.Connection = maConnexion;
			cmd.CommandText = "DELETE FROM Medicament WHERE numero_medicament = @NumeroMedicament";

			cmd.Parameters.AddWithValue("@NumeroMedicament", numMedicament);

			cmd.ExecuteNonQuery();

			maConnexion.Close();

			return medicamentSuppr;
		}
	}
}
