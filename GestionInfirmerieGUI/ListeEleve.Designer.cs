﻿namespace GestionInfirmerieGUI
{
	partial class ListeEleve
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.eLEVEBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnListeMedicament = new System.Windows.Forms.Button();
			this.btnAjoutMedicament = new System.Windows.Forms.Button();
			this.btnListeVisite = new System.Windows.Forms.Button();
			this.btnAjoutVisite = new System.Windows.Forms.Button();
			this.btnAjoutEleve = new System.Windows.Forms.Button();
			this.btnAccueilEleve = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.DataSource = this.eLEVEBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(226, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1600, 891);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// eLEVEBindingSource
			// 
			this.eLEVEBindingSource.DataMember = "ELEVE";
			// 
			// btnListeMedicament
			// 
			this.btnListeMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnListeMedicament.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListeMedicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListeMedicament.Location = new System.Drawing.Point(12, 292);
			this.btnListeMedicament.Name = "btnListeMedicament";
			this.btnListeMedicament.Size = new System.Drawing.Size(200, 53);
			this.btnListeMedicament.TabIndex = 13;
			this.btnListeMedicament.Text = "Liste des médicaments";
			this.btnListeMedicament.UseVisualStyleBackColor = false;
			this.btnListeMedicament.Click += new System.EventHandler(this.btnListeMedoc_Click);
			// 
			// btnAjoutMedicament
			// 
			this.btnAjoutMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnAjoutMedicament.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAjoutMedicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAjoutMedicament.Location = new System.Drawing.Point(12, 236);
			this.btnAjoutMedicament.Name = "btnAjoutMedicament";
			this.btnAjoutMedicament.Size = new System.Drawing.Size(200, 53);
			this.btnAjoutMedicament.TabIndex = 12;
			this.btnAjoutMedicament.Text = "Ajouter un médicament";
			this.btnAjoutMedicament.UseVisualStyleBackColor = false;
			this.btnAjoutMedicament.Click += new System.EventHandler(this.btnAjoutMedoc_Click);
			// 
			// btnListeVisite
			// 
			this.btnListeVisite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnListeVisite.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListeVisite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListeVisite.Location = new System.Drawing.Point(12, 180);
			this.btnListeVisite.Name = "btnListeVisite";
			this.btnListeVisite.Size = new System.Drawing.Size(200, 53);
			this.btnListeVisite.TabIndex = 11;
			this.btnListeVisite.Text = "Liste des visites";
			this.btnListeVisite.UseVisualStyleBackColor = false;
			this.btnListeVisite.Click += new System.EventHandler(this.btnListeVisite_Click);
			// 
			// btnAjoutVisite
			// 
			this.btnAjoutVisite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnAjoutVisite.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAjoutVisite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAjoutVisite.Location = new System.Drawing.Point(12, 124);
			this.btnAjoutVisite.Name = "btnAjoutVisite";
			this.btnAjoutVisite.Size = new System.Drawing.Size(200, 53);
			this.btnAjoutVisite.TabIndex = 10;
			this.btnAjoutVisite.Text = "Ajouter une visite";
			this.btnAjoutVisite.UseVisualStyleBackColor = false;
			this.btnAjoutVisite.Click += new System.EventHandler(this.btnAjoutVisite_Click);
			// 
			// btnAjoutEleve
			// 
			this.btnAjoutEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnAjoutEleve.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAjoutEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAjoutEleve.Location = new System.Drawing.Point(12, 68);
			this.btnAjoutEleve.Name = "btnAjoutEleve";
			this.btnAjoutEleve.Size = new System.Drawing.Size(200, 53);
			this.btnAjoutEleve.TabIndex = 9;
			this.btnAjoutEleve.Text = "Ajouter un élève";
			this.btnAjoutEleve.UseVisualStyleBackColor = false;
			this.btnAjoutEleve.Click += new System.EventHandler(this.btnAjoutEleve_Click);
			// 
			// btnAccueilEleve
			// 
			this.btnAccueilEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnAccueilEleve.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAccueilEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccueilEleve.Location = new System.Drawing.Point(12, 12);
			this.btnAccueilEleve.Name = "btnAccueilEleve";
			this.btnAccueilEleve.Size = new System.Drawing.Size(200, 53);
			this.btnAccueilEleve.TabIndex = 8;
			this.btnAccueilEleve.Text = "Accueil élève";
			this.btnAccueilEleve.UseVisualStyleBackColor = false;
			this.btnAccueilEleve.Click += new System.EventHandler(this.btnAccueilEleve_Click);
			// 
			// ListeEleve
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.ClientSize = new System.Drawing.Size(1795, 753);
			this.Controls.Add(this.btnListeMedicament);
			this.Controls.Add(this.btnAjoutMedicament);
			this.Controls.Add(this.btnListeVisite);
			this.Controls.Add(this.btnAjoutVisite);
			this.Controls.Add(this.btnAjoutEleve);
			this.Controls.Add(this.btnAccueilEleve);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ListeEleve";
			this.Text = "Liste des élèves";
			this.Load += new System.EventHandler(this.ListeEleve_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource eLEVEBindingSource;
		private System.Windows.Forms.Button btnListeMedicament;
		private System.Windows.Forms.Button btnAjoutMedicament;
		private System.Windows.Forms.Button btnListeVisite;
		private System.Windows.Forms.Button btnAjoutVisite;
		private System.Windows.Forms.Button btnAjoutEleve;
		private System.Windows.Forms.Button btnAccueilEleve;
		private System.Windows.Forms.DataGridViewTextBoxColumn numeroeleveDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeleveDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn prenomeleveDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceeleveDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelephoneeleveDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numeroTelephoneParentDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn tiersempseleveDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn commentaireSanteDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numeroclasseDataGridViewTextBoxColumn;
	}
}