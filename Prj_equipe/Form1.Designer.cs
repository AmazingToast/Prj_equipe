namespace Prj_equipe
{
    partial class Projet
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
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_premier = new System.Windows.Forms.Button();
            this.btn_dernier = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_consulter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_lister = new System.Windows.Forms.Button();
            this.btn_sauvegarder = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_liste = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_suivant
            // 
            this.btn_suivant.Location = new System.Drawing.Point(134, 3);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(30, 23);
            this.btn_suivant.TabIndex = 0;
            this.btn_suivant.Text = ">";
            this.btn_suivant.UseVisualStyleBackColor = true;
            // 
            // btn_premier
            // 
            this.btn_premier.Location = new System.Drawing.Point(0, 3);
            this.btn_premier.Name = "btn_premier";
            this.btn_premier.Size = new System.Drawing.Size(30, 23);
            this.btn_premier.TabIndex = 1;
            this.btn_premier.Text = "<<";
            this.btn_premier.UseVisualStyleBackColor = true;
            // 
            // btn_dernier
            // 
            this.btn_dernier.Location = new System.Drawing.Point(170, 3);
            this.btn_dernier.Name = "btn_dernier";
            this.btn_dernier.Size = new System.Drawing.Size(30, 23);
            this.btn_dernier.TabIndex = 2;
            this.btn_dernier.Text = ">>";
            this.btn_dernier.UseVisualStyleBackColor = true;
            // 
            // btn_precedent
            // 
            this.btn_precedent.Location = new System.Drawing.Point(36, 3);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(30, 23);
            this.btn_precedent.TabIndex = 3;
            this.btn_precedent.Text = "<";
            this.btn_precedent.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_precedent);
            this.panel1.Controls.Add(this.btn_dernier);
            this.panel1.Controls.Add(this.btn_premier);
            this.panel1.Controls.Add(this.btn_suivant);
            this.panel1.Location = new System.Drawing.Point(475, 684);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 30);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 666);
            this.panel2.TabIndex = 5;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1154, 660);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(85, 3);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 6;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(3, 3);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 7;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(166, 3);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 8;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            // 
            // btn_consulter
            // 
            this.btn_consulter.Location = new System.Drawing.Point(247, 3);
            this.btn_consulter.Name = "btn_consulter";
            this.btn_consulter.Size = new System.Drawing.Size(75, 23);
            this.btn_consulter.TabIndex = 9;
            this.btn_consulter.Text = "Consulter";
            this.btn_consulter.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_lister);
            this.panel3.Controls.Add(this.btn_modifier);
            this.panel3.Controls.Add(this.btn_consulter);
            this.panel3.Controls.Add(this.btn_ajouter);
            this.panel3.Controls.Add(this.btn_supprimer);
            this.panel3.Location = new System.Drawing.Point(133, 716);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 29);
            this.panel3.TabIndex = 10;
            // 
            // btn_lister
            // 
            this.btn_lister.Location = new System.Drawing.Point(328, 3);
            this.btn_lister.Name = "btn_lister";
            this.btn_lister.Size = new System.Drawing.Size(75, 23);
            this.btn_lister.TabIndex = 10;
            this.btn_lister.Text = "Lister";
            this.btn_lister.UseVisualStyleBackColor = true;
            // 
            // btn_sauvegarder
            // 
            this.btn_sauvegarder.Location = new System.Drawing.Point(85, 3);
            this.btn_sauvegarder.Name = "btn_sauvegarder";
            this.btn_sauvegarder.Size = new System.Drawing.Size(75, 26);
            this.btn_sauvegarder.TabIndex = 11;
            this.btn_sauvegarder.Text = "Sauvegarder";
            this.btn_sauvegarder.UseVisualStyleBackColor = true;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(166, 3);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 26);
            this.btn_annuler.TabIndex = 12;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            // 
            // btn_liste
            // 
            this.btn_liste.Location = new System.Drawing.Point(4, 3);
            this.btn_liste.Name = "btn_liste";
            this.btn_liste.Size = new System.Drawing.Size(75, 26);
            this.btn_liste.TabIndex = 13;
            this.btn_liste.Text = "Liste";
            this.btn_liste.UseVisualStyleBackColor = true;
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(247, 3);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(75, 26);
            this.btn_quitter.TabIndex = 14;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_annuler);
            this.panel4.Controls.Add(this.btn_quitter);
            this.panel4.Controls.Add(this.btn_sauvegarder);
            this.panel4.Controls.Add(this.btn_liste);
            this.panel4.Location = new System.Drawing.Point(609, 716);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 34);
            this.panel4.TabIndex = 15;
            // 
            // Projet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Projet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projet";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_premier;
        private System.Windows.Forms.Button btn_dernier;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_consulter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_lister;
        private System.Windows.Forms.Button btn_sauvegarder;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_liste;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.Panel panel4;
    }
}

