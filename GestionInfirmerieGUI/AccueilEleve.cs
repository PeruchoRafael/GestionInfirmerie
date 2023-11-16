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
	public partial class AccueilEleve : Form
	{
		public AccueilEleve()
		{
			InitializeComponent();
			this.WindowState = FormWindowState.Maximized;
		}

		private void button1_Click(object sender, EventArgs e)
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

		}

		private void btnListeVisite_Click(object sender, EventArgs e)
		{

		}

		private void btnAjoutMedoc_Click(object sender, EventArgs e)
		{

		}

		private void btnListeMedoc_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void AccueilEleve_Load(object sender, EventArgs e)
		{

		}


	}
}
