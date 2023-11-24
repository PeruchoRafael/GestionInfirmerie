using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionInfirmerieBO
{
	public class Medicament
	{
		private int numero_medicament;
		private string nom_medicament;

		public Medicament(int numero, string nom)
		{
			numero_medicament = numero;
			nom_medicament = nom;
		}

		public Medicament(int numero)
		{
			numero_medicament = numero;
		}

		public int NumeroMedicament
		{
			get { return numero_medicament; }
			set { numero_medicament = value; }
		}

		public string NomMedicament
		{
			get { return nom_medicament; }
			set { nom_medicament = value; }
		}
	}
}
