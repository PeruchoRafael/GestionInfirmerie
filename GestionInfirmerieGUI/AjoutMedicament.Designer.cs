namespace GestionInfirmerieGUI
{
	partial class AjoutMedicament
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnListeMebdicament = new System.Windows.Forms.Button();
			this.btnListeVisite = new System.Windows.Forms.Button();
			this.btnAjoutVisite = new System.Windows.Forms.Button();
			this.btnListeEleve = new System.Windows.Forms.Button();
			this.btnAjoutEleve = new System.Windows.Forms.Button();
			this.btnAccueilEleve = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lblNom = new System.Windows.Forms.Label();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.btnValider = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnListeMebdicament
			// 
			this.btnListeMebdicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnListeMebdicament.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListeMebdicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListeMebdicament.Location = new System.Drawing.Point(12, 287);
			this.btnListeMebdicament.Name = "btnListeMebdicament";
			this.btnListeMebdicament.Size = new System.Drawing.Size(200, 53);
			this.btnListeMebdicament.TabIndex = 23;
			this.btnListeMebdicament.Text = "Liste des médicaments";
			this.btnListeMebdicament.UseVisualStyleBackColor = false;
			this.btnListeMebdicament.Click += new System.EventHandler(this.btnListeMebdicament_Click);
			// 
			// btnListeVisite
			// 
			this.btnListeVisite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnListeVisite.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListeVisite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListeVisite.Location = new System.Drawing.Point(12, 231);
			this.btnListeVisite.Name = "btnListeVisite";
			this.btnListeVisite.Size = new System.Drawing.Size(200, 53);
			this.btnListeVisite.TabIndex = 22;
			this.btnListeVisite.Text = "Liste des visites";
			this.btnListeVisite.UseVisualStyleBackColor = false;
			this.btnListeVisite.Click += new System.EventHandler(this.btnListeVisite_Click);
			// 
			// btnAjoutVisite
			// 
			this.btnAjoutVisite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnAjoutVisite.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAjoutVisite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAjoutVisite.Location = new System.Drawing.Point(12, 175);
			this.btnAjoutVisite.Name = "btnAjoutVisite";
			this.btnAjoutVisite.Size = new System.Drawing.Size(200, 53);
			this.btnAjoutVisite.TabIndex = 21;
			this.btnAjoutVisite.Text = "Ajouter une visite";
			this.btnAjoutVisite.UseVisualStyleBackColor = false;
			this.btnAjoutVisite.Click += new System.EventHandler(this.btnAjoutVisite_Click);
			// 
			// btnListeEleve
			// 
			this.btnListeEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnListeEleve.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListeEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListeEleve.Location = new System.Drawing.Point(12, 119);
			this.btnListeEleve.Name = "btnListeEleve";
			this.btnListeEleve.Size = new System.Drawing.Size(200, 53);
			this.btnListeEleve.TabIndex = 20;
			this.btnListeEleve.Text = "Liste des élèves";
			this.btnListeEleve.UseVisualStyleBackColor = false;
			this.btnListeEleve.Click += new System.EventHandler(this.btnListeEleve_Click);
			// 
			// btnAjoutEleve
			// 
			this.btnAjoutEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnAjoutEleve.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAjoutEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAjoutEleve.Location = new System.Drawing.Point(12, 63);
			this.btnAjoutEleve.Name = "btnAjoutEleve";
			this.btnAjoutEleve.Size = new System.Drawing.Size(200, 53);
			this.btnAjoutEleve.TabIndex = 19;
			this.btnAjoutEleve.Text = "Ajouter un élève";
			this.btnAjoutEleve.UseVisualStyleBackColor = false;
			this.btnAjoutEleve.Click += new System.EventHandler(this.btnAjoutEleve_Click);
			// 
			// btnAccueilEleve
			// 
			this.btnAccueilEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnAccueilEleve.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAccueilEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccueilEleve.Location = new System.Drawing.Point(12, 7);
			this.btnAccueilEleve.Name = "btnAccueilEleve";
			this.btnAccueilEleve.Size = new System.Drawing.Size(200, 53);
			this.btnAccueilEleve.TabIndex = 18;
			this.btnAccueilEleve.Text = "Accueil élève";
			this.btnAccueilEleve.UseVisualStyleBackColor = false;
			this.btnAccueilEleve.Click += new System.EventHandler(this.btnAccueilEleve_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.lblNom);
			this.groupBox1.Controls.Add(this.txtNom);
			this.groupBox1.Controls.Add(this.btnValider);
			this.groupBox1.Location = new System.Drawing.Point(280, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(533, 300);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(63)))));
			this.button1.Location = new System.Drawing.Point(85, 168);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(350, 100);
			this.button1.TabIndex = 20;
			this.button1.Text = "Valider";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// lblNom
			// 
			this.lblNom.AutoSize = true;
			this.lblNom.Location = new System.Drawing.Point(50, 42);
			this.lblNom.Name = "lblNom";
			this.lblNom.Size = new System.Drawing.Size(45, 17);
			this.lblNom.TabIndex = 10;
			this.lblNom.Text = "Nom :";
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(239, 42);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(250, 22);
			this.txtNom.TabIndex = 18;
			// 
			// btnValider
			// 
			this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(63)))));
			this.btnValider.Location = new System.Drawing.Point(102, 618);
			this.btnValider.Name = "btnValider";
			this.btnValider.Size = new System.Drawing.Size(350, 100);
			this.btnValider.TabIndex = 19;
			this.btnValider.Text = "Valider";
			this.btnValider.UseVisualStyleBackColor = false;
			// 
			// AjoutMedicament
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.ClientSize = new System.Drawing.Size(986, 561);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnListeMebdicament);
			this.Controls.Add(this.btnListeVisite);
			this.Controls.Add(this.btnAjoutVisite);
			this.Controls.Add(this.btnListeEleve);
			this.Controls.Add(this.btnAjoutEleve);
			this.Controls.Add(this.btnAccueilEleve);
			this.Name = "AjoutMedicament";
			this.Text = "Ajouter un médicament";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnListeMebdicament;
		private System.Windows.Forms.Button btnListeVisite;
		private System.Windows.Forms.Button btnAjoutVisite;
		private System.Windows.Forms.Button btnListeEleve;
		private System.Windows.Forms.Button btnAjoutEleve;
		private System.Windows.Forms.Button btnAccueilEleve;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblNom;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.Button btnValider;
		private System.Windows.Forms.Button button1;
	}
}