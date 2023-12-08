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
	public partial class ListeVisite : Form
	{
		public static List<GestionInfirmerieBO.Visite> global_visites;
		public ListeVisite()
		{
			InitializeComponent();

			this.WindowState = FormWindowState.Maximized;
			GestionInfirmerieBLL.GestionInfirmerie.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);

			// Blocage de la génération automatique des colonnes
			dataGridView1.AutoGenerateColumns = false;

			// Création d'une en-tête de colonne pour la colonne numero_visite
			DataGridViewTextBoxColumn NumeroColumn = new DataGridViewTextBoxColumn();
			NumeroColumn.DataPropertyName = "NumeroVisite";
			NumeroColumn.HeaderText = "Identifiant";
			dataGridView1.Columns.Add(NumeroColumn);

			// Création d'une en-tête de colonne pour la colonne date_visite
			DataGridViewTextBoxColumn DateColum = new DataGridViewTextBoxColumn();
			NumeroColumn.DataPropertyName = "DateVisite";
			NumeroColumn.HeaderText = "Identifiant";
			dataGridView1.Columns.Add(DateColum);

			// Création d'une en-tête de colonne pour la colonne heure_debut_visite
			DataGridViewTextBoxColumn HeureDebutColumn = new DataGridViewTextBoxColumn();
			NumeroColumn.DataPropertyName = "HeureDebutVisite";
			NumeroColumn.HeaderText = "Heure début";
			dataGridView1.Columns.Add(HeureDebutColumn);

			// Création d'une en-tête de colonne pour la colonne heure_fin_visite
			DataGridViewTextBoxColumn HeureFinColumn = new DataGridViewTextBoxColumn();
			NumeroColumn.DataPropertyName = "HeureFinVisite";
			NumeroColumn.HeaderText = "Heure fin";
			dataGridView1.Columns.Add(HeureFinColumn);

			// Création d'une en-tête de colonne pour la colonne motif_visite
			DataGridViewTextBoxColumn MotifColumn = new DataGridViewTextBoxColumn();
			NumeroColumn.DataPropertyName = "MotifVisite";
			NumeroColumn.HeaderText = "Motif de visite";
			dataGridView1.Columns.Add(MotifColumn);

			// Création d'une en-tête de colonne pour la colonne prevention_parent
			DataGridViewTextBoxColumn PreventionColumn = new DataGridViewTextBoxColumn();
			NumeroColumn.DataPropertyName = "PréventionVisite";
			NumeroColumn.HeaderText = "Prévention des parents ?";
			dataGridView1.Columns.Add(PreventionColumn);

			// Création d'une en-tête de colonne pour la colonne rentreChezLui
			DataGridViewTextBoxColumn RentreColumn = new DataGridViewTextBoxColumn();
			NumeroColumn.DataPropertyName = "RentreChezLuiVisite";
			NumeroColumn.HeaderText = "Rentre chez lui ?";
			dataGridView1.Columns.Add(RentreColumn);

			// Création d'une en-tête de colonne pour la colonne vaAlHopital
			DataGridViewTextBoxColumn VaAlHopitalColumn = new DataGridViewTextBoxColumn();
			NumeroColumn.DataPropertyName = "VaAlHopitalVisite";
			NumeroColumn.HeaderText = "Va à l'hopital ?";
			dataGridView1.Columns.Add(VaAlHopitalColumn);

			// Création d'une en-tête de colonne pour la colonne quantité_medic
			DataGridViewTextBoxColumn QuantiteMedicColumn = new DataGridViewTextBoxColumn();
			NumeroColumn.DataPropertyName = "QuantiteMedicVisite";
			NumeroColumn.HeaderText = "Quantité médicament";
			dataGridView1.Columns.Add(QuantiteMedicColumn);

			// Création d'une en-tête de colonne pour la colonne commentaire_visite
			DataGridViewTextBoxColumn CommentaireColumn = new DataGridViewTextBoxColumn();
			NumeroColumn.DataPropertyName = "CommentaireVisite";
			NumeroColumn.HeaderText = "Commentaire";
			dataGridView1.Columns.Add(CommentaireColumn);

			// Création d'une en-tête de colonne pour la colonne numero_eleve
			DataGridViewTextBoxColumn NumeroEleveColumn = new DataGridViewTextBoxColumn();
			NumeroColumn.DataPropertyName = "NumeroEleve";
			NumeroColumn.HeaderText = "Numero élève";
			dataGridView1.Columns.Add(NumeroEleveColumn);

			// Création d'une en-tête de colonne pour la colonne numero_medicament
			DataGridViewTextBoxColumn NumeroMedicColumn = new DataGridViewTextBoxColumn();
			NumeroColumn.DataPropertyName = "NumeroMedic";
			NumeroColumn.HeaderText = "Numéro médicament";
			dataGridView1.Columns.Add(NumeroMedicColumn);

			//bouton modifier
			DataGridViewButtonColumn btnModifier = new DataGridViewButtonColumn();
			btnModifier.HeaderText = "Modifier";
			btnModifier.Text = "Modifier";
			btnModifier.UseColumnTextForButtonValue = true;
			dataGridView1.Columns.Add(btnModifier);

			// Création d'un objet List d'Utilisateur à afficher dans le datagridview
			List<Visite> lesVisites = new List<Visite>();
			lesVisites = GestionInfirmerieBLL.GestionInfirmerie.GetVisites();

			dataGridView1.DataSource = lesVisites;

			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			dataGridView1.CellClick += dataGridView1_CellContentClick;

			dataGridView1.DataSource = lesVisites;

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

		private void ListeVisite_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
