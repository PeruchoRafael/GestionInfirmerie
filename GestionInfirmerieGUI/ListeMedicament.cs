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
	public partial class ListeMedicament : Form
	{
		public ListeMedicament()
		{
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
			// Blocage de la génération automatique des colonnes
			dataGridView1.AutoGenerateColumns = false;

			// Création d'une en-tête de colonne pour la colonne numero_eleve
			DataGridViewTextBoxColumn NumeroColumn = new DataGridViewTextBoxColumn();
			NumeroColumn.DataPropertyName = "NumeroMedicament";
			NumeroColumn.HeaderText = "id_medicament";
			dataGridView1.Columns.Add(NumeroColumn);

			// Création d'une en-tête de colonne pour la colonne nom_eleve
			DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();
			NomColumn.DataPropertyName = "NomMedicament";
			NomColumn.HeaderText = "Nom medicament";
			dataGridView1.Columns.Add(NomColumn);

			//bouton supprimer et modifier
			DataGridViewButtonColumn btnModifier = new DataGridViewButtonColumn();
			btnModifier.HeaderText = "Modifier";
			btnModifier.Text = "Modifier";
			btnModifier.UseColumnTextForButtonValue = true;
			dataGridView1.Columns.Add(btnModifier);

			DataGridViewButtonColumn btnSupprimer = new DataGridViewButtonColumn();
			btnSupprimer.HeaderText = "Supprimer";
			btnSupprimer.Text = "Supprimer";
			btnSupprimer.UseColumnTextForButtonValue = true;
			dataGridView1.Columns.Add(btnSupprimer);

			// Création d'un objet List d'Utilisateur à afficher dans le datagridview
			List<Medicament> lesMedicaments = new List<Medicament>();
			lesMedicaments = GestionInfirmerieBLL.GestionInfirmerie.GetMedicaments();
			dataGridView1.DataSource = lesMedicaments;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			lesMedicaments = GestionInfirmerieBLL.GestionInfirmerie.GetMedicaments();

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

        private void ListeMedicament_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'gestionInfirmerieDataSet.MEDICAMENT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
