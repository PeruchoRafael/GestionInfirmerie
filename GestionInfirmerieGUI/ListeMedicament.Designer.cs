namespace GestionInfirmerieGUI
{
	partial class ListeMedicament
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
            this.btnAjoutMedicament = new System.Windows.Forms.Button();
            this.btnListeVisite = new System.Windows.Forms.Button();
            this.btnAjoutVisite = new System.Windows.Forms.Button();
            this.btnListeEleve = new System.Windows.Forms.Button();
            this.btnAjoutEleve = new System.Windows.Forms.Button();
            this.btnAccueilEleve = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mEDICAMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjoutMedicament
            // 
            this.btnAjoutMedicament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btnAjoutMedicament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjoutMedicament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutMedicament.Location = new System.Drawing.Point(12, 290);
            this.btnAjoutMedicament.Name = "btnAjoutMedicament";
            this.btnAjoutMedicament.Size = new System.Drawing.Size(200, 53);
            this.btnAjoutMedicament.TabIndex = 19;
            this.btnAjoutMedicament.Text = "Ajouter un médicament";
            this.btnAjoutMedicament.UseVisualStyleBackColor = false;
            this.btnAjoutMedicament.Click += new System.EventHandler(this.btnAjoutMedicament_Click);
            // 
            // btnListeVisite
            // 
            this.btnListeVisite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btnListeVisite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListeVisite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeVisite.Location = new System.Drawing.Point(12, 234);
            this.btnListeVisite.Name = "btnListeVisite";
            this.btnListeVisite.Size = new System.Drawing.Size(200, 53);
            this.btnListeVisite.TabIndex = 18;
            this.btnListeVisite.Text = "Liste des visites";
            this.btnListeVisite.UseVisualStyleBackColor = false;
            this.btnListeVisite.Click += new System.EventHandler(this.btnListeVisite_Click);
            // 
            // btnAjoutVisite
            // 
            this.btnAjoutVisite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btnAjoutVisite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjoutVisite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutVisite.Location = new System.Drawing.Point(12, 178);
            this.btnAjoutVisite.Name = "btnAjoutVisite";
            this.btnAjoutVisite.Size = new System.Drawing.Size(200, 53);
            this.btnAjoutVisite.TabIndex = 17;
            this.btnAjoutVisite.Text = "Ajouter une visite";
            this.btnAjoutVisite.UseVisualStyleBackColor = false;
            this.btnAjoutVisite.Click += new System.EventHandler(this.btnAjoutVisite_Click);
            // 
            // btnListeEleve
            // 
            this.btnListeEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btnListeEleve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListeEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListeEleve.Location = new System.Drawing.Point(12, 122);
            this.btnListeEleve.Name = "btnListeEleve";
            this.btnListeEleve.Size = new System.Drawing.Size(200, 53);
            this.btnListeEleve.TabIndex = 16;
            this.btnListeEleve.Text = "Liste des élèves";
            this.btnListeEleve.UseVisualStyleBackColor = false;
            this.btnListeEleve.Click += new System.EventHandler(this.btnListeEleve_Click);
            // 
            // btnAjoutEleve
            // 
            this.btnAjoutEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btnAjoutEleve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAjoutEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjoutEleve.Location = new System.Drawing.Point(12, 66);
            this.btnAjoutEleve.Name = "btnAjoutEleve";
            this.btnAjoutEleve.Size = new System.Drawing.Size(200, 53);
            this.btnAjoutEleve.TabIndex = 15;
            this.btnAjoutEleve.Text = "Ajouter un élève";
            this.btnAjoutEleve.UseVisualStyleBackColor = false;
            this.btnAjoutEleve.Click += new System.EventHandler(this.btnAjoutEleve_Click);
            // 
            // btnAccueilEleve
            // 
            this.btnAccueilEleve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btnAccueilEleve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccueilEleve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccueilEleve.Location = new System.Drawing.Point(12, 10);
            this.btnAccueilEleve.Name = "btnAccueilEleve";
            this.btnAccueilEleve.Size = new System.Drawing.Size(200, 53);
            this.btnAccueilEleve.TabIndex = 14;
            this.btnAccueilEleve.Text = "Accueil élève";
            this.btnAccueilEleve.UseVisualStyleBackColor = false;
            this.btnAccueilEleve.Click += new System.EventHandler(this.btnAccueilEleve_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.mEDICAMENTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(233, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(625, 413);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mEDICAMENTBindingSource
            // 
            this.mEDICAMENTBindingSource.DataMember = "MEDICAMENT";
            // 
            // ListeMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAjoutMedicament);
            this.Controls.Add(this.btnListeVisite);
            this.Controls.Add(this.btnAjoutVisite);
            this.Controls.Add(this.btnListeEleve);
            this.Controls.Add(this.btnAjoutEleve);
            this.Controls.Add(this.btnAccueilEleve);
            this.Name = "ListeMedicament";
            this.Text = "Liste des médicaments";
            this.Load += new System.EventHandler(this.ListeMedicament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mEDICAMENTBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAjoutMedicament;
		private System.Windows.Forms.Button btnListeVisite;
		private System.Windows.Forms.Button btnAjoutVisite;
		private System.Windows.Forms.Button btnListeEleve;
		private System.Windows.Forms.Button btnAjoutEleve;
		private System.Windows.Forms.Button btnAccueilEleve;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mEDICAMENTBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeromedicamentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nommedicamentDataGridViewTextBoxColumn;
    }
}