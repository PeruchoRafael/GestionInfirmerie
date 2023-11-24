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
	public partial class AjoutEleve : Form
	{
		public AjoutEleve()
		{
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
			comboBoxClasse.DataSource = GestionInfirmerieBLL.GestionInfirmerie.GetClasse();
			comboBoxClasse.DisplayMember = "NomClasse";
			comboBoxClasse.ValueMember = "NumeroClasse";
		}

		private void btnAccueilEleve_Click(object sender, EventArgs e)
		{
			this.Hide();
			AccueilEleve accueilEleve = new AccueilEleve();
			accueilEleve.ShowDialog();
			this.Close();
		}

		private void btnListeEleve_Click(object sender, EventArgs e)
		{
			this.Hide();
			ListeEleve listeEleve = new ListeEleve();
			listeEleve.ShowDialog();
			this.Close();
		}

		private void btnAjoutVisite_Click(object sender, EventArgs e)
		{
			this.Hide();
			AjoutVisite ajoutVisite = new AjoutVisite();
			ajoutVisite.ShowDialog();
			this.Close();
		}

		private void btnListeVisite_Click(object sender, EventArgs e)
		{
			this.Hide();
			ListeVisite listeVisite = new ListeVisite();
			listeVisite.ShowDialog();
			this.Close();
		}

		private void btnAjoutMedicament_Click(object sender, EventArgs e)
		{
			this.Hide();
			AjoutMedicament ajoutMedicament = new AjoutMedicament();
			ajoutMedicament.ShowDialog();
			this.Close();
		}

		private void btnListeMedicament_Click(object sender, EventArgs e)
		{
			this.Hide();
			ListeMedicament listeMedicament = new ListeMedicament();
			listeMedicament.ShowDialog();
			this.Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void AjoutEleve_Load(object sender, EventArgs e)
		{

		}

		private void btnValider_Click(object sender, EventArgs e)
		{
			string nom = txtNom.Text;
			string prenom = txtPrenom.Text;
			DateTime dateNaissance = DateTime.Parse(txtDateNaissance.Text);
			string tiersTemps = txtTiersTemps.Text;
			string commentaire = txtSante.Text;
			int telEleve = int.Parse(txtTelEleve.Text);
			int telParentEleve = int.Parse(txtTelParent.Text);
			int numClasse = int.Parse(comboBoxClasse.Text);

			/*if (!int.TryParse(txtTelEleve.Text, out int telEleve) ||
			!int.TryParse(txtTelParent.Text, out int telParentEleve) ||
			!int.TryParse(comboBoxClasse.Text, out int classe))
			{
				MessageBox.Show("Veuillez renseignez des valeurs numériques pour les champs necéssaires");
			}
			else
			{
				int telEleve = int.Parse(txtTelEleve.Text);
			}*/

			Eleve nouvelEleve = new Eleve(nom, prenom, dateNaissance, telEleve, telParentEleve, tiersTemps, commentaire, numClasse);
			bool ajoutEleveVerif = GestionInfirmerieBLL.GestionInfirmerie.AjoutEleve(nouvelEleve);

			if (ajoutEleveVerif != true)
			{
				txtNom.Text = nouvelEleve.NomEleve;
				txtPrenom.Text = nouvelEleve.PrenomEleve;
				txtDateNaissance.Text = nouvelEleve.DateNaissanceEleve.ToString();
				txtTelEleve.Text = nouvelEleve.NumeroTelephoneEleve.ToString();
				txtTelParent.Text = nouvelEleve.NumeroTelephoneParentEleve.ToString();
				txtTiersTemps.Text = nouvelEleve.TiersTempsEleve;
				txtSante.Text = nouvelEleve.CommentaireSanteEleve;
				comboBoxClasse.Text = nouvelEleve.NumeroClasseEleve.ToString();

				MessageBox.Show("Eleve ajouté");
			}
			else
			{
				MessageBox.Show("Eleve non ajouté");
			}
		}

		private void txtClasse_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
