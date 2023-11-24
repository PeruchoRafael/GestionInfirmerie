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
	public partial class ListeMedicament : Form
	{
		public ListeMedicament()
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
	}
}
