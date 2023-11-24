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
	public partial class ModifEleve : Form
	{
		public ModifEleve()
		{
			InitializeComponent();
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
