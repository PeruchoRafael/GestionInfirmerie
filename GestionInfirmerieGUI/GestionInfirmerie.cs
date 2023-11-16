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
    public partial class GestionInfirmerie : Form
    {
        public GestionInfirmerie()
        {
            InitializeComponent();
            GestionInfirmerieBLL.GestionInfirmerie.SetchaineConnexion(ConfigurationManager.ConnectionStrings["GestionInfirmerie"]);
			this.WindowState = FormWindowState.Maximized;
        }

		private void GestionInfirmerie_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string email = txtIdentifiant.Text;
			string mdp = txtMdp.Text;
			Utilisateur utilisateur = new Utilisateur(email, mdp);
			bool utilisateurVerif = GestionInfirmerieBLL.GestionInfirmerie.FindUtilisateur(utilisateur);

			if (utilisateurVerif != false)
			{
				txtIdentifiant.Text = utilisateur.EmailUtilisateur;
				txtMdp.Text = utilisateur.MotDePasseUtilisateur;
				this.Hide();
				AccueilEleve accueilEleve = new AccueilEleve();
				accueilEleve.ShowDialog();
				this.Close();
			}
			else
			{
				MessageBox.Show("Utilisateur non trouvé");
			}
		}
	}
}
