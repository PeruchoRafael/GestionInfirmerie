using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using GestionInfirmerieBO;
using GestionInfirmerieBLL;

namespace GestionInfirmerieGUI
{
	public partial class ModifEleve : Form
	{
		private Eleve eleve;
		public ModifEleve(Eleve eleve)
		{
			InitializeComponent();
			this.eleve = eleve;
			InitializeFormFields();
		}

		private void InitializeFormFields()
		{
			string nom = eleve.NomEleve.ToString();
			string prenom = eleve.PrenomEleve.ToString();
			DateTime dateNaissance = eleve.DateNaissanceEleve;
			int numTelEleve = eleve.NumeroTelephoneEleve;
			int numTelParent = eleve.NumeroTelephoneParentEleve;
			string tiersTemps = eleve.TiersTempsEleve;
			string commentaire = eleve.CommentaireSanteEleve;
			int numClasse = eleve.NumeroClasseEleve;

			txtNom.Text = nom;
			txtPrenom.Text = prenom;
			txtDateNaissance.Text = dateNaissance.ToString();
			txtTelEleve.Text = numTelEleve.ToString();
			txtTelParent.Text = numTelParent.ToString();
			txtTiersTemps.Text = tiersTemps.ToString();
			txtSante.Text = commentaire;
			txtClasse.Text = numClasse.ToString();
		}

		private void ModifEleve_Load(object sender, EventArgs e)
		{

		}

		private void btnValider_Click(object sender, EventArgs e)
		{

		}

		private void btnAjoutMedoc_Click(object sender, EventArgs e)
		{
			this.Hide();
			AjoutMedicament ajoutMedicament = new AjoutMedicament();
			ajoutMedicament.ShowDialog();
			this.Close();
		}
	}
}
