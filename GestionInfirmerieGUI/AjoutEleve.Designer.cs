namespace GestionInfirmerieGUI
{
	partial class AjoutEleve
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
			this.btnValider = new System.Windows.Forms.Button();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.btnListeMedicament = new System.Windows.Forms.Button();
			this.btnAjoutMedicament = new System.Windows.Forms.Button();
			this.btnListeVisite = new System.Windows.Forms.Button();
			this.btnAjoutVisite = new System.Windows.Forms.Button();
			this.btnListeEleve = new System.Windows.Forms.Button();
			this.btnAccueilEleve = new System.Windows.Forms.Button();
			this.lblNom = new System.Windows.Forms.Label();
			this.txtPrenom = new System.Windows.Forms.TextBox();
			this.lblPrenom = new System.Windows.Forms.Label();
			this.lblClasse = new System.Windows.Forms.Label();
			this.comboBoxClasse = new System.Windows.Forms.ComboBox();
			this.txtSante = new System.Windows.Forms.TextBox();
			this.lblSante = new System.Windows.Forms.Label();
			this.txtDateNaissance = new System.Windows.Forms.TextBox();
			this.lblDateNaissance = new System.Windows.Forms.Label();
			this.txtTelEleve = new System.Windows.Forms.TextBox();
			this.lblTelEleve = new System.Windows.Forms.Label();
			this.txtTelParent = new System.Windows.Forms.TextBox();
			this.lblTelParent = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtTiersTemps = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
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
			this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(239, 42);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(250, 22);
			this.txtNom.TabIndex = 18;
			// 
			// btnListeMedicament
			// 
			this.btnListeMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnListeMedicament.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListeMedicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListeMedicament.Location = new System.Drawing.Point(12, 289);
			this.btnListeMedicament.Name = "btnListeMedicament";
			this.btnListeMedicament.Size = new System.Drawing.Size(200, 53);
			this.btnListeMedicament.TabIndex = 17;
			this.btnListeMedicament.Text = "Liste des médicaments";
			this.btnListeMedicament.UseVisualStyleBackColor = false;
			this.btnListeMedicament.Click += new System.EventHandler(this.btnListeMedicament_Click);
			// 
			// btnAjoutMedicament
			// 
			this.btnAjoutMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnAjoutMedicament.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAjoutMedicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAjoutMedicament.Location = new System.Drawing.Point(12, 233);
			this.btnAjoutMedicament.Name = "btnAjoutMedicament";
			this.btnAjoutMedicament.Size = new System.Drawing.Size(200, 53);
			this.btnAjoutMedicament.TabIndex = 16;
			this.btnAjoutMedicament.Text = "Ajouter un médicament";
			this.btnAjoutMedicament.UseVisualStyleBackColor = false;
			this.btnAjoutMedicament.Click += new System.EventHandler(this.btnAjoutMedicament_Click);
			// 
			// btnListeVisite
			// 
			this.btnListeVisite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnListeVisite.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListeVisite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListeVisite.Location = new System.Drawing.Point(12, 177);
			this.btnListeVisite.Name = "btnListeVisite";
			this.btnListeVisite.Size = new System.Drawing.Size(200, 53);
			this.btnListeVisite.TabIndex = 15;
			this.btnListeVisite.Text = "Liste des visites";
			this.btnListeVisite.UseVisualStyleBackColor = false;
			this.btnListeVisite.Click += new System.EventHandler(this.btnListeVisite_Click);
			// 
			// btnAjoutVisite
			// 
			this.btnAjoutVisite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnAjoutVisite.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAjoutVisite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAjoutVisite.Location = new System.Drawing.Point(12, 121);
			this.btnAjoutVisite.Name = "btnAjoutVisite";
			this.btnAjoutVisite.Size = new System.Drawing.Size(200, 53);
			this.btnAjoutVisite.TabIndex = 14;
			this.btnAjoutVisite.Text = "Ajouter une visite";
			this.btnAjoutVisite.UseVisualStyleBackColor = false;
			this.btnAjoutVisite.Click += new System.EventHandler(this.btnAjoutVisite_Click);
			// 
			// btnListeEleve
			// 
			this.btnListeEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnListeEleve.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListeEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListeEleve.Location = new System.Drawing.Point(12, 65);
			this.btnListeEleve.Name = "btnListeEleve";
			this.btnListeEleve.Size = new System.Drawing.Size(200, 53);
			this.btnListeEleve.TabIndex = 13;
			this.btnListeEleve.Text = "Liste des élèves";
			this.btnListeEleve.UseVisualStyleBackColor = false;
			this.btnListeEleve.Click += new System.EventHandler(this.btnListeEleve_Click);
			// 
			// btnAccueilEleve
			// 
			this.btnAccueilEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnAccueilEleve.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAccueilEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccueilEleve.Location = new System.Drawing.Point(12, 9);
			this.btnAccueilEleve.Name = "btnAccueilEleve";
			this.btnAccueilEleve.Size = new System.Drawing.Size(200, 53);
			this.btnAccueilEleve.TabIndex = 11;
			this.btnAccueilEleve.Text = "Accueil élève";
			this.btnAccueilEleve.UseVisualStyleBackColor = false;
			this.btnAccueilEleve.Click += new System.EventHandler(this.btnAccueilEleve_Click);
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
			// txtPrenom
			// 
			this.txtPrenom.Location = new System.Drawing.Point(239, 107);
			this.txtPrenom.Name = "txtPrenom";
			this.txtPrenom.Size = new System.Drawing.Size(250, 22);
			this.txtPrenom.TabIndex = 21;
			// 
			// lblPrenom
			// 
			this.lblPrenom.AutoSize = true;
			this.lblPrenom.Location = new System.Drawing.Point(50, 107);
			this.lblPrenom.Name = "lblPrenom";
			this.lblPrenom.Size = new System.Drawing.Size(65, 17);
			this.lblPrenom.TabIndex = 20;
			this.lblPrenom.Text = "Prénom :";
			this.lblPrenom.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblClasse
			// 
			this.lblClasse.AutoSize = true;
			this.lblClasse.Location = new System.Drawing.Point(50, 536);
			this.lblClasse.Name = "lblClasse";
			this.lblClasse.Size = new System.Drawing.Size(58, 17);
			this.lblClasse.TabIndex = 22;
			this.lblClasse.Text = "Classe :";
			// 
			// comboBoxClasse
			// 
			this.comboBoxClasse.FormattingEnabled = true;
			this.comboBoxClasse.Location = new System.Drawing.Point(239, 533);
			this.comboBoxClasse.Name = "comboBoxClasse";
			this.comboBoxClasse.Size = new System.Drawing.Size(250, 24);
			this.comboBoxClasse.TabIndex = 24;
			this.comboBoxClasse.SelectedIndexChanged += new System.EventHandler(this.txtClasse_SelectedIndexChanged);
			// 
			// txtSante
			// 
			this.txtSante.Location = new System.Drawing.Point(239, 464);
			this.txtSante.Name = "txtSante";
			this.txtSante.Size = new System.Drawing.Size(250, 22);
			this.txtSante.TabIndex = 28;
			// 
			// lblSante
			// 
			this.lblSante.AutoSize = true;
			this.lblSante.Location = new System.Drawing.Point(50, 464);
			this.lblSante.Name = "lblSante";
			this.lblSante.Size = new System.Drawing.Size(53, 17);
			this.lblSante.TabIndex = 27;
			this.lblSante.Text = "Santé :";
			// 
			// txtDateNaissance
			// 
			this.txtDateNaissance.Location = new System.Drawing.Point(239, 179);
			this.txtDateNaissance.Name = "txtDateNaissance";
			this.txtDateNaissance.Size = new System.Drawing.Size(250, 22);
			this.txtDateNaissance.TabIndex = 26;
			// 
			// lblDateNaissance
			// 
			this.lblDateNaissance.AutoSize = true;
			this.lblDateNaissance.Location = new System.Drawing.Point(50, 179);
			this.lblDateNaissance.Name = "lblDateNaissance";
			this.lblDateNaissance.Size = new System.Drawing.Size(134, 17);
			this.lblDateNaissance.TabIndex = 25;
			this.lblDateNaissance.Text = "Date de naissance :";
			// 
			// txtTelEleve
			// 
			this.txtTelEleve.Location = new System.Drawing.Point(239, 260);
			this.txtTelEleve.Name = "txtTelEleve";
			this.txtTelEleve.Size = new System.Drawing.Size(250, 22);
			this.txtTelEleve.TabIndex = 32;
			// 
			// lblTelEleve
			// 
			this.lblTelEleve.AutoSize = true;
			this.lblTelEleve.Location = new System.Drawing.Point(50, 260);
			this.lblTelEleve.Name = "lblTelEleve";
			this.lblTelEleve.Size = new System.Drawing.Size(122, 17);
			this.lblTelEleve.TabIndex = 31;
			this.lblTelEleve.Text = "Téléphone élève :";
			// 
			// txtTelParent
			// 
			this.txtTelParent.Location = new System.Drawing.Point(239, 334);
			this.txtTelParent.Name = "txtTelParent";
			this.txtTelParent.Size = new System.Drawing.Size(250, 22);
			this.txtTelParent.TabIndex = 30;
			// 
			// lblTelParent
			// 
			this.lblTelParent.AutoSize = true;
			this.lblTelParent.Location = new System.Drawing.Point(50, 334);
			this.lblTelParent.Name = "lblTelParent";
			this.lblTelParent.Size = new System.Drawing.Size(129, 17);
			this.lblTelParent.TabIndex = 29;
			this.lblTelParent.Text = "Téléphone parent :";
			this.lblTelParent.Click += new System.EventHandler(this.label2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
			this.groupBox1.Controls.Add(this.txtTiersTemps);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lblClasse);
			this.groupBox1.Controls.Add(this.txtTelEleve);
			this.groupBox1.Controls.Add(this.lblNom);
			this.groupBox1.Controls.Add(this.lblTelEleve);
			this.groupBox1.Controls.Add(this.txtNom);
			this.groupBox1.Controls.Add(this.txtTelParent);
			this.groupBox1.Controls.Add(this.btnValider);
			this.groupBox1.Controls.Add(this.lblTelParent);
			this.groupBox1.Controls.Add(this.lblPrenom);
			this.groupBox1.Controls.Add(this.txtSante);
			this.groupBox1.Controls.Add(this.txtPrenom);
			this.groupBox1.Controls.Add(this.comboBoxClasse);
			this.groupBox1.Controls.Add(this.lblSante);
			this.groupBox1.Controls.Add(this.txtDateNaissance);
			this.groupBox1.Controls.Add(this.lblDateNaissance);
			this.groupBox1.Location = new System.Drawing.Point(280, 29);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(533, 734);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// txtTiersTemps
			// 
			this.txtTiersTemps.Location = new System.Drawing.Point(239, 402);
			this.txtTiersTemps.Name = "txtTiersTemps";
			this.txtTiersTemps.Size = new System.Drawing.Size(250, 22);
			this.txtTiersTemps.TabIndex = 34;
			this.txtTiersTemps.Text = "oui ou non";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 402);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 17);
			this.label1.TabIndex = 33;
			this.label1.Text = "Tiers temps :";
			// 
			// AjoutEleve
			// 
			this.AcceptButton = this.btnValider;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.ClientSize = new System.Drawing.Size(857, 775);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnListeMedicament);
			this.Controls.Add(this.btnAjoutMedicament);
			this.Controls.Add(this.btnListeVisite);
			this.Controls.Add(this.btnAjoutVisite);
			this.Controls.Add(this.btnListeEleve);
			this.Controls.Add(this.btnAccueilEleve);
			this.Name = "AjoutEleve";
			this.Text = "Ajouter un élève";
			this.Load += new System.EventHandler(this.AjoutEleve_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnValider;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.Button btnListeMedicament;
		private System.Windows.Forms.Button btnAjoutMedicament;
		private System.Windows.Forms.Button btnListeVisite;
		private System.Windows.Forms.Button btnAjoutVisite;
		private System.Windows.Forms.Button btnListeEleve;
		private System.Windows.Forms.Button btnAccueilEleve;
		private System.Windows.Forms.Label lblNom;
		private System.Windows.Forms.TextBox txtPrenom;
		private System.Windows.Forms.Label lblPrenom;
		private System.Windows.Forms.Label lblClasse;
		private System.Windows.Forms.ComboBox comboBoxClasse;
		private System.Windows.Forms.TextBox txtSante;
		private System.Windows.Forms.Label lblSante;
		private System.Windows.Forms.TextBox txtDateNaissance;
		private System.Windows.Forms.Label lblDateNaissance;
		private System.Windows.Forms.TextBox txtTelEleve;
		private System.Windows.Forms.Label lblTelEleve;
		private System.Windows.Forms.TextBox txtTelParent;
		private System.Windows.Forms.Label lblTelParent;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTiersTemps;
	}
}