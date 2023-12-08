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
	public partial class ListeEleve : Form
	{
		public static List<GestionInfirmerieBO.Eleve> global_eleves;
		public ListeEleve()
		{
			InitializeComponent();

			this.WindowState = FormWindowState.Maximized;
			GestionInfirmerieBLL.GestionInfirmerie.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
			
			// Blocage de la génération automatique des colonnes
			dataGridView1.AutoGenerateColumns = false;

			// Création d'une en-tête de colonne pour la colonne numero_eleve
			DataGridViewTextBoxColumn NumeroColumn = new DataGridViewTextBoxColumn();
			NumeroColumn.Name = "NumeroEleve";
			NumeroColumn.DataPropertyName = "NumeroEleve";
			NumeroColumn.HeaderText = "Identifiant";
			dataGridView1.Columns.Add(NumeroColumn);

			// Création d'une en-tête de colonne pour la colonne nom_eleve
			DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();
			NomColumn.DataPropertyName = "NomEleve";
			NomColumn.HeaderText = "Nom";
			dataGridView1.Columns.Add(NomColumn);

			// Création d'une en-tête de colonne pour la colonne prenom_eleve
			DataGridViewTextBoxColumn PrenomColumn = new DataGridViewTextBoxColumn();
			PrenomColumn.DataPropertyName = "PrenomEleve";
			PrenomColumn.HeaderText = "Prénom";
			dataGridView1.Columns.Add(PrenomColumn);

			// Création d'une en-tête de colonne pour la colonne dateNaissance_eleve
			DataGridViewTextBoxColumn DateNaissanceColumn = new DataGridViewTextBoxColumn();
			DateNaissanceColumn.DataPropertyName = "DateNaissanceEleve";
			DateNaissanceColumn.HeaderText = "Date de naissance";
			dataGridView1.Columns.Add(DateNaissanceColumn);

			// Création d'une en-tête de colonne pour la colonne numeroTelephone_eleve
			DataGridViewTextBoxColumn NumeroTelEleveColumn = new DataGridViewTextBoxColumn();
			NumeroTelEleveColumn.DataPropertyName = "NumeroTelephoneEleve";
			NumeroTelEleveColumn.HeaderText = "Numéro de Téléphone élève";
			dataGridView1.Columns.Add(NumeroTelEleveColumn);

			// Création d'une en-tête de colonne pour la colonne numeroTelephoneParent_eleve
			DataGridViewTextBoxColumn NumeroTelParentColumn = new DataGridViewTextBoxColumn();
			NumeroTelParentColumn.DataPropertyName = "NumeroTelephoneParentEleve";
			NumeroTelParentColumn.HeaderText = "Numéro de Téléphone Parent";
			dataGridView1.Columns.Add(NumeroTelParentColumn);


			// Création d'une en-tête de colonne pour la colonne tiersemps_eleve
			DataGridViewTextBoxColumn TiersTempsColumn = new DataGridViewTextBoxColumn();
			TiersTempsColumn.DataPropertyName = "TiersTempsEleve";
			TiersTempsColumn.HeaderText = "Tiers temps";
			dataGridView1.Columns.Add(TiersTempsColumn);


			// Création d'une en-tête de colonne pour la colonne commentaireSante
			DataGridViewTextBoxColumn CommentaireColumn = new DataGridViewTextBoxColumn();
			CommentaireColumn.DataPropertyName = "CommentaireSanteEleve";
			CommentaireColumn.HeaderText = "Commentaire";
			dataGridView1.Columns.Add(CommentaireColumn);

			// Création d'une en-tête de colonne pour la colonne numero_classe
			DataGridViewTextBoxColumn NumeroClasseColumn = new DataGridViewTextBoxColumn();
			NumeroClasseColumn.DataPropertyName = "NumeroClasseEleve";
			NumeroClasseColumn.HeaderText = "Identifiant classe";
			dataGridView1.Columns.Add(NumeroClasseColumn);

			//bouton supprimer et modifier
			DataGridViewButtonColumn btnModifier = new DataGridViewButtonColumn();
			btnModifier.Name = "btnModifier";
			btnModifier.HeaderText = "Modifier";
			btnModifier.Text = "Modifier";
			btnModifier.UseColumnTextForButtonValue = true;
			dataGridView1.Columns.Add(btnModifier);

			DataGridViewButtonColumn btnSupprimer = new DataGridViewButtonColumn();
			btnSupprimer.Name = "btnSupprimer";
			btnSupprimer.HeaderText = "Supprimer";
			btnSupprimer.Text = "Supprimer";
			btnSupprimer.UseColumnTextForButtonValue = true;
			dataGridView1.Columns.Add(btnSupprimer);

			// Création d'un objet List d'Utilisateur à afficher dans le datagridview
			List<Eleve> lesEleves = new List<Eleve>();
			lesEleves = GestionInfirmerieBLL.GestionInfirmerie.GetEleves();

			/*dataGridView1.Rows.Add(lesEleves.Count);
			for (int i = 0; i < lesEleves.Count; i++)
			{
				dataGridView1[0, i].Value = lesEleves[i].NumeroEleve;
				dataGridView1[1, i].Value = lesEleves[i].NomEleve;
				dataGridView1[2, i].Value = lesEleves[i].PrenomEleve;
				dataGridView1[3, i].Value = lesEleves[i].DateNaissanceEleve;
				dataGridView1[4, i].Value = lesEleves[i].NumeroTelephoneEleve;
				dataGridView1[5, i].Value = lesEleves[i].NumeroTelephoneParentEleve;
				dataGridView1[6, i].Value = lesEleves[i].TiersTempsEleve;
				dataGridView1[7, i].Value = lesEleves[i].CommentaireSanteEleve;
				dataGridView1[8, i].Value = lesEleves[i].NumeroClasseEleve;
				dataGridView1[9, i].Tag = lesEleves[i].Id; Supprimer
				dataGridView1[10, i].Tag = lesEleves[i].Id; Modifier
			}*/
			dataGridView1.DataSource = lesEleves;

			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			dataGridView1.CellClick += dataGridView1_CellContentClick;

			dataGridView1.DataSource = lesEleves;

			dataGridView1.Refresh();
		}

		private void btnAccueilEleve_Click(object sender, EventArgs e)
		{
			this.Hide();
			AccueilEleve accueilEleve = new AccueilEleve();
			accueilEleve.ShowDialog();
			this.Close();
		}

		private void btnAjoutEleve_Click(object sender, EventArgs e)
		{
			this.Hide();
			AjoutEleve ajoutEleve = new AjoutEleve();
			ajoutEleve.ShowDialog();
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

		private void btnAjoutMedoc_Click(object sender, EventArgs e)
		{
			this.Hide();
			AjoutMedicament ajoutMedicament = new AjoutMedicament();
			ajoutMedicament.ShowDialog();
			this.Close();
		}

		private void btnListeMedoc_Click(object sender, EventArgs e)
		{
			this.Hide();
			ListeMedicament listeMedicament = new ListeMedicament();
			listeMedicament.ShowDialog();
			this.Close();
		}

		private void ListeEleve_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

				int columnIndex = e.ColumnIndex;

				if (columnIndex == dataGridView1.Columns["btnModifier"].Index)
				{
					int id = Convert.ToInt32(selectedRow.Cells["NumeroEleve"].Value);
					Eleve eleve = new Eleve(id);
					GestionInfirmerieBLL.GestionInfirmerie.ModifEleve(eleve);

					this.Hide();
					ModifEleve modifEleve = new ModifEleve(eleve);
					modifEleve.ShowDialog();
					this.Close();
				}
				else if (columnIndex == dataGridView1.Columns["btnSupprimer"].Index)
				{
					int id = Convert.ToInt32(selectedRow.Cells["NumeroEleve"].Value);
					Eleve eleve = new Eleve(id);
					GestionInfirmerieBLL.GestionInfirmerie.SupprEleve(eleve);
					MessageBox.Show("suppression");
				}
			}
		}
	}
}
