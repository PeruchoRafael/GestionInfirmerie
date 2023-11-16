namespace GestionInfirmerieGUI
{
    partial class GestionInfirmerie
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtIdentifiant = new System.Windows.Forms.TextBox();
			this.txtMdp = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.txtMdp);
			this.panel1.Controls.Add(this.txtIdentifiant);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(119, 21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(552, 398);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(66, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Identifiant :";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(66, 158);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mot de passe :";
			// 
			// txtIdentifiant
			// 
			this.txtIdentifiant.Location = new System.Drawing.Point(227, 63);
			this.txtIdentifiant.Name = "txtIdentifiant";
			this.txtIdentifiant.Size = new System.Drawing.Size(250, 22);
			this.txtIdentifiant.TabIndex = 2;
			this.txtIdentifiant.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// txtMdp
			// 
			this.txtMdp.Location = new System.Drawing.Point(227, 158);
			this.txtMdp.Name = "txtMdp";
			this.txtMdp.Size = new System.Drawing.Size(250, 22);
			this.txtMdp.TabIndex = 3;
			this.txtMdp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(201)))), ((int)(((byte)(63)))));
			this.button1.Location = new System.Drawing.Point(114, 272);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(350, 100);
			this.button1.TabIndex = 4;
			this.button1.Text = "Valider";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// GestionInfirmerie
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 441);
			this.Controls.Add(this.panel1);
			this.Name = "GestionInfirmerie";
			this.Text = "Connexion";
			this.Load += new System.EventHandler(this.GestionInfirmerie_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtMdp;
		private System.Windows.Forms.TextBox txtIdentifiant;
	}
}

