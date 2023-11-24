using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInfirmerieBO
{
	public class Classe
	{
		private int numero_classe;
		private string nom_classe;

		public Classe(int numero, string nom) 
		{
			numero_classe = numero;
			nom_classe = nom;
		}

		public Classe(int numero)
		{
			numero_classe = numero;
		}

		public int NumeroClasse
		{
			get { return numero_classe; }
			set { numero_classe = value; }
		}

		public string NomClasse
		{
			get { return nom_classe; }
			set { nom_classe = value; }
		}
	}
}
