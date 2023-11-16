namespace GestionInfirmerieGUI
{
	partial class AccueilEleve
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
			this.lblNom = new System.Windows.Forms.Label();
			this.btnAjoutEleve = new System.Windows.Forms.Button();
			this.btnListeEleve = new System.Windows.Forms.Button();
			this.btnAjoutVisite = new System.Windows.Forms.Button();
			this.btnListeVisite = new System.Windows.Forms.Button();
			this.btnAjoutMedoc = new System.Windows.Forms.Button();
			this.btnListeMedoc = new System.Windows.Forms.Button();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.btnValider = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNom
			// 
			this.lblNom.AutoSize = true;
			this.lblNom.Location = new System.Drawing.Point(278, 137);
			this.lblNom.Name = "lblNom";
			this.lblNom.Size = new System.Drawing.Size(109, 17);
			this.lblNom.TabIndex = 0;
			this.lblNom.Text = "Nom de l\'élève :";
			this.lblNom.Click += new System.EventHandler(this.label1_Click);
			// 
			// btnAjoutEleve
			// 
			this.btnAjoutEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnAjoutEleve.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAjoutEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAjoutEleve.Location = new System.Drawing.Point(12, 12);
			this.btnAjoutEleve.Name = "btnAjoutEleve";
			this.btnAjoutEleve.Size = new System.Drawing.Size(200, 53);
			this.btnAjoutEleve.TabIndex = 1;
			this.btnAjoutEleve.Text = "Ajouter un élève";
			this.btnAjoutEleve.UseVisualStyleBackColor = false;
			this.btnAjoutEleve.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnListeEleve
			// 
			this.btnListeEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnListeEleve.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListeEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListeEleve.Location = new System.Drawing.Point(12, 68);
			this.btnListeEleve.Name = "btnListeEleve";
			this.btnListeEleve.Size = new System.Drawing.Size(200, 53);
			this.btnListeEleve.TabIndex = 3;
			this.btnListeEleve.Text = "Liste des élèves";
			this.btnListeEleve.UseVisualStyleBackColor = false;
			this.btnListeEleve.Click += new System.EventHandler(this.btnListeEleve_Click);
			// 
			// btnAjoutVisite
			// 
			this.btnAjoutVisite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnAjoutVisite.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAjoutVisite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAjoutVisite.Location = new System.Drawing.Point(12, 124);
			this.btnAjoutVisite.Name = "btnAjoutVisite";
			this.btnAjoutVisite.Size = new System.Drawing.Size(200, 53);
			this.btnAjoutVisite.TabIndex = 4;
			this.btnAjoutVisite.Text = "Ajouter une visite";
			this.btnAjoutVisite.UseVisualStyleBackColor = false;
			this.btnAjoutVisite.Click += new System.EventHandler(this.btnAjoutVisite_Click);
			// 
			// btnListeVisite
			// 
			this.btnListeVisite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnListeVisite.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListeVisite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListeVisite.Location = new System.Drawing.Point(12, 180);
			this.btnListeVisite.Name = "btnListeVisite";
			this.btnListeVisite.Size = new System.Drawing.Size(200, 53);
			this.btnListeVisite.TabIndex = 5;
			this.btnListeVisite.Text = "Liste des visites";
			this.btnListeVisite.UseVisualStyleBackColor = false;
			this.btnListeVisite.Click += new System.EventHandler(this.btnListeVisite_Click);
			// 
			// btnAjoutMedoc
			// 
			this.btnAjoutMedoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnAjoutMedoc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAjoutMedoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAjoutMedoc.Location = new System.Drawing.Point(12, 236);
			this.btnAjoutMedoc.Name = "btnAjoutMedoc";
			this.btnAjoutMedoc.Size = new System.Drawing.Size(200, 53);
			this.btnAjoutMedoc.TabIndex = 6;
			this.btnAjoutMedoc.Text = "Ajouter un médicament";
			this.btnAjoutMedoc.UseVisualStyleBackColor = false;
			this.btnAjoutMedoc.Click += new System.EventHandler(this.btnAjoutMedoc_Click);
			// 
			// btnListeMedoc
			// 
			this.btnListeMedoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnListeMedoc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListeMedoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListeMedoc.Location = new System.Drawing.Point(12, 292);
			this.btnListeMedoc.Name = "btnListeMedoc";
			this.btnListeMedoc.Size = new System.Drawing.Size(200, 53);
			this.btnListeMedoc.TabIndex = 7;
			this.btnListeMedoc.Text = "Liste des médicaments";
			this.btnListeMedoc.UseVisualStyleBackColor = false;
			this.btnListeMedoc.Click += new System.EventHandler(this.btnListeMedoc_Click);
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(467, 137);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(250, 22);
			this.txtNom.TabIndex = 8;
			this.txtNom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btnValider
			// 
			this.btnValider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(63)))));
			this.btnValider.Location = new System.Drawing.Point(326, 297);
			this.btnValider.Name = "btnValider";
			this.btnValider.Size = new System.Drawing.Size(350, 100);
			this.btnValider.TabIndex = 9;
			this.btnValider.Text = "Valider";
			this.btnValider.UseVisualStyleBackColor = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(782, 76);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(240, 150);
			this.dataGridView1.TabIndex = 10;
			// 
			// AccueilEleve
			// 
			this.AcceptButton = this.btnValider;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.ClientSize = new System.Drawing.Size(1701, 498);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnValider);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.btnListeMedoc);
			this.Controls.Add(this.btnAjoutMedoc);
			this.Controls.Add(this.btnListeVisite);
			this.Controls.Add(this.btnAjoutVisite);
			this.Controls.Add(this.btnListeEleve);
			this.Controls.Add(this.btnAjoutEleve);
			this.Controls.Add(this.lblNom);
			this.Name = "AccueilEleve";
			this.Text = "Accueil élève";
			this.Load += new System.EventHandler(this.AccueilEleve_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNom;
		private System.Windows.Forms.Button btnAjoutEleve;
		private System.Windows.Forms.Button btnListeEleve;
		private System.Windows.Forms.Button btnAjoutVisite;
		private System.Windows.Forms.Button btnListeVisite;
		private System.Windows.Forms.Button btnAjoutMedoc;
		private System.Windows.Forms.Button btnListeMedoc;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.Button btnValider;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}