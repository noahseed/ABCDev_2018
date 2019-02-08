namespace MonSuperBouton
{
    partial class FrmBoutons
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
            this.components = new System.ComponentModel.Container();
            this.btnSuperBouton = new System.Windows.Forms.Button();
            this.btnCible = new System.Windows.Forms.Button();
            this.timerCible = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSuperBouton
            // 
            this.btnSuperBouton.Location = new System.Drawing.Point(13, 13);
            this.btnSuperBouton.Name = "btnSuperBouton";
            this.btnSuperBouton.Size = new System.Drawing.Size(260, 80);
            this.btnSuperBouton.TabIndex = 0;
            this.btnSuperBouton.Text = "Mon Super Bouton";
            this.btnSuperBouton.UseVisualStyleBackColor = true;
            this.btnSuperBouton.Click += new System.EventHandler(this.btnSuperBouton_Click);
            // 
            // btnCible
            // 
            this.btnCible.Location = new System.Drawing.Point(13, 99);
            this.btnCible.Name = "btnCible";
            this.btnCible.Size = new System.Drawing.Size(260, 80);
            this.btnCible.TabIndex = 1;
            this.btnCible.Text = "button1";
            this.btnCible.UseVisualStyleBackColor = true;
            this.btnCible.Visible = false;
            // 
            // timerCible
            // 
            this.timerCible.Interval = 1000;
            this.timerCible.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmBoutons
            // 
            this.ClientSize = new System.Drawing.Size(806, 413);
            this.Controls.Add(this.btnCible);
            this.Controls.Add(this.btnSuperBouton);
            this.Name = "FrmBoutons";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSuperBouton;
        private System.Windows.Forms.Button btnCible;
        private System.Windows.Forms.Timer timerCible;


    }
}

