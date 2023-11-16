using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInfirmerieGUI
{
	public partial class ListeEleve : Form
	{
		public ListeEleve()
		{
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
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

		private void ListeEleve_Load(object sender, EventArgs e)
		{
			// TODO: cette ligne de code charge les données dans la table 'gestionInfirmerieDataSet.ELEVE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
			this.eLEVETableAdapter.Fill(this.gestionInfirmerieDataSet.ELEVE);

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}


	}
}
