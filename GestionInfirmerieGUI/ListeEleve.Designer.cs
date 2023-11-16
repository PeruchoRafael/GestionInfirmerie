namespace GestionInfirmerieGUI
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
			this.gestionInfirmerieDataSet = new GestionInfirmerieGUI.GestionInfirmerieDataSet();
			this.eLEVETableAdapter = new GestionInfirmerieGUI.GestionInfirmerieDataSetTableAdapters.ELEVETableAdapter();
			this.btnListeMedoc = new System.Windows.Forms.Button();
			this.btnAjoutMedoc = new System.Windows.Forms.Button();
			this.btnListeVisite = new System.Windows.Forms.Button();
			this.btnAjoutVisite = new System.Windows.Forms.Button();
			this.btnAjoutEleve = new System.Windows.Forms.Button();
			this.btnAccueilEleve = new System.Windows.Forms.Button();
			this.numeroeleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prenomeleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateNaissanceeleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numeroTelephoneeleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numeroTelephoneParentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tiersempseleveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commentaireSanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numeroclasseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eLEVEBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gestionInfirmerieDataSet)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroeleveDataGridViewTextBoxColumn,
            this.nomeleveDataGridViewTextBoxColumn,
            this.prenomeleveDataGridViewTextBoxColumn,
            this.dateNaissanceeleveDataGridViewTextBoxColumn,
            this.numeroTelephoneeleveDataGridViewTextBoxColumn,
            this.numeroTelephoneParentDataGridViewTextBoxColumn,
            this.tiersempseleveDataGridViewTextBoxColumn,
            this.commentaireSanteDataGridViewTextBoxColumn,
            this.numeroclasseDataGridViewTextBoxColumn,
            this.Action});
			this.dataGridView1.DataSource = this.eLEVEBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(245, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1764, 891);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// eLEVEBindingSource
			// 
			this.eLEVEBindingSource.DataMember = "ELEVE";
			this.eLEVEBindingSource.DataSource = this.gestionInfirmerieDataSet;
			// 
			// gestionInfirmerieDataSet
			// 
			this.gestionInfirmerieDataSet.DataSetName = "GestionInfirmerieDataSet";
			this.gestionInfirmerieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// eLEVETableAdapter
			// 
			this.eLEVETableAdapter.ClearBeforeFill = true;
			// 
			// btnListeMedoc
			// 
			this.btnListeMedoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnListeMedoc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnListeMedoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnListeMedoc.Location = new System.Drawing.Point(12, 292);
			this.btnListeMedoc.Name = "btnListeMedoc";
			this.btnListeMedoc.Size = new System.Drawing.Size(200, 53);
			this.btnListeMedoc.TabIndex = 13;
			this.btnListeMedoc.Text = "Liste des médicaments";
			this.btnListeMedoc.UseVisualStyleBackColor = false;
			// 
			// btnAjoutMedoc
			// 
			this.btnAjoutMedoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
			this.btnAjoutMedoc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAjoutMedoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAjoutMedoc.Location = new System.Drawing.Point(12, 236);
			this.btnAjoutMedoc.Name = "btnAjoutMedoc";
			this.btnAjoutMedoc.Size = new System.Drawing.Size(200, 53);
			this.btnAjoutMedoc.TabIndex = 12;
			this.btnAjoutMedoc.Text = "Ajouter un médicament";
			this.btnAjoutMedoc.UseVisualStyleBackColor = false;
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
			// numeroeleveDataGridViewTextBoxColumn
			// 
			this.numeroeleveDataGridViewTextBoxColumn.DataPropertyName = "numero_eleve";
			this.numeroeleveDataGridViewTextBoxColumn.HeaderText = "numero_eleve";
			this.numeroeleveDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.numeroeleveDataGridViewTextBoxColumn.Name = "numeroeleveDataGridViewTextBoxColumn";
			this.numeroeleveDataGridViewTextBoxColumn.ReadOnly = true;
			this.numeroeleveDataGridViewTextBoxColumn.Width = 125;
			// 
			// nomeleveDataGridViewTextBoxColumn
			// 
			this.nomeleveDataGridViewTextBoxColumn.DataPropertyName = "nom_eleve";
			this.nomeleveDataGridViewTextBoxColumn.HeaderText = "nom_eleve";
			this.nomeleveDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.nomeleveDataGridViewTextBoxColumn.Name = "nomeleveDataGridViewTextBoxColumn";
			this.nomeleveDataGridViewTextBoxColumn.Width = 125;
			// 
			// prenomeleveDataGridViewTextBoxColumn
			// 
			this.prenomeleveDataGridViewTextBoxColumn.DataPropertyName = "prenom_eleve";
			this.prenomeleveDataGridViewTextBoxColumn.HeaderText = "prenom_eleve";
			this.prenomeleveDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.prenomeleveDataGridViewTextBoxColumn.Name = "prenomeleveDataGridViewTextBoxColumn";
			this.prenomeleveDataGridViewTextBoxColumn.Width = 125;
			// 
			// dateNaissanceeleveDataGridViewTextBoxColumn
			// 
			this.dateNaissanceeleveDataGridViewTextBoxColumn.DataPropertyName = "dateNaissance_eleve";
			this.dateNaissanceeleveDataGridViewTextBoxColumn.HeaderText = "dateNaissance_eleve";
			this.dateNaissanceeleveDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.dateNaissanceeleveDataGridViewTextBoxColumn.Name = "dateNaissanceeleveDataGridViewTextBoxColumn";
			this.dateNaissanceeleveDataGridViewTextBoxColumn.Width = 125;
			// 
			// numeroTelephoneeleveDataGridViewTextBoxColumn
			// 
			this.numeroTelephoneeleveDataGridViewTextBoxColumn.DataPropertyName = "numeroTelephone_eleve";
			this.numeroTelephoneeleveDataGridViewTextBoxColumn.HeaderText = "numeroTelephone_eleve";
			this.numeroTelephoneeleveDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.numeroTelephoneeleveDataGridViewTextBoxColumn.Name = "numeroTelephoneeleveDataGridViewTextBoxColumn";
			this.numeroTelephoneeleveDataGridViewTextBoxColumn.Width = 125;
			// 
			// numeroTelephoneParentDataGridViewTextBoxColumn
			// 
			this.numeroTelephoneParentDataGridViewTextBoxColumn.DataPropertyName = "numeroTelephoneParent";
			this.numeroTelephoneParentDataGridViewTextBoxColumn.HeaderText = "numeroTelephoneParent";
			this.numeroTelephoneParentDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.numeroTelephoneParentDataGridViewTextBoxColumn.Name = "numeroTelephoneParentDataGridViewTextBoxColumn";
			this.numeroTelephoneParentDataGridViewTextBoxColumn.Width = 125;
			// 
			// tiersempseleveDataGridViewTextBoxColumn
			// 
			this.tiersempseleveDataGridViewTextBoxColumn.DataPropertyName = "tiersemps_eleve";
			this.tiersempseleveDataGridViewTextBoxColumn.HeaderText = "tiersemps_eleve";
			this.tiersempseleveDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.tiersempseleveDataGridViewTextBoxColumn.Name = "tiersempseleveDataGridViewTextBoxColumn";
			this.tiersempseleveDataGridViewTextBoxColumn.Width = 125;
			// 
			// commentaireSanteDataGridViewTextBoxColumn
			// 
			this.commentaireSanteDataGridViewTextBoxColumn.DataPropertyName = "commentaireSante";
			this.commentaireSanteDataGridViewTextBoxColumn.HeaderText = "commentaireSante";
			this.commentaireSanteDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.commentaireSanteDataGridViewTextBoxColumn.Name = "commentaireSanteDataGridViewTextBoxColumn";
			this.commentaireSanteDataGridViewTextBoxColumn.Width = 125;
			// 
			// numeroclasseDataGridViewTextBoxColumn
			// 
			this.numeroclasseDataGridViewTextBoxColumn.DataPropertyName = "numero_classe";
			this.numeroclasseDataGridViewTextBoxColumn.HeaderText = "numero_classe";
			this.numeroclasseDataGridViewTextBoxColumn.MinimumWidth = 6;
			this.numeroclasseDataGridViewTextBoxColumn.Name = "numeroclasseDataGridViewTextBoxColumn";
			this.numeroclasseDataGridViewTextBoxColumn.Width = 125;
			// 
			// Action
			// 
			this.Action.DataPropertyName = "numero_eleve";
			this.Action.HeaderText = "Action";
			this.Action.MinimumWidth = 6;
			this.Action.Name = "Action";
			this.Action.ReadOnly = true;
			this.Action.Width = 125;
			// 
			// ListeEleve
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
			this.ClientSize = new System.Drawing.Size(1795, 753);
			this.Controls.Add(this.btnListeMedoc);
			this.Controls.Add(this.btnAjoutMedoc);
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
			((System.ComponentModel.ISupportInitialize)(this.gestionInfirmerieDataSet)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private GestionInfirmerieDataSet gestionInfirmerieDataSet;
		private System.Windows.Forms.BindingSource eLEVEBindingSource;
		private GestionInfirmerieDataSetTableAdapters.ELEVETableAdapter eLEVETableAdapter;
		private System.Windows.Forms.Button btnListeMedoc;
		private System.Windows.Forms.Button btnAjoutMedoc;
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
		private System.Windows.Forms.DataGridViewButtonColumn Action;
	}
}