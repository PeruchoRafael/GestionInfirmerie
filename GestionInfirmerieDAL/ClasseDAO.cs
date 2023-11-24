using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionInfirmerieBO;
using System.Data.SqlClient;

namespace GestionInfirmerieDAL
{
	public class ClasseDAO
	{
		private static ClasseDAO uneClasseDAO;

		public static ClasseDAO GetuneClasseDAO()
		{
			if (uneClasseDAO == null)
			{
				uneClasseDAO = new ClasseDAO();
			}
			return uneClasseDAO;
		}

		public static List<Classe> GetClasses()
		{
			int numero;
			string nom;
			Classe uneClasse;

			// Connexion à la BD
			SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

			// Création d'une liste vide d'objets Classe
			List<Classe> lesClasses = new List<Classe>();

			SqlCommand cmd = new SqlCommand();
			cmd.Connection = maConnexion;
			cmd.CommandText = " SELECT * FROM Classe";
			SqlDataReader monReader = cmd.ExecuteReader();

			// Remplissage de la liste
			while (monReader.Read())
			{
				numero = Int32.Parse(monReader["numero_classe"].ToString());
				if (monReader["nom_classe"] == DBNull.Value)
				{
					nom = default(string);
				}
				else
				{
					nom = monReader["nom_classe"].ToString();
				}
				uneClasse = new Classe(numero, nom);
				lesClasses.Add(uneClasse);
			}
			// Fermeture de la connexion
			maConnexion.Close();

			return lesClasses;
		}
	}
}
