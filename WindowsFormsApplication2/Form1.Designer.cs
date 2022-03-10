namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.txt_NomPrenom = new System.Windows.Forms.TextBox();
            this.txt_NoteDS = new System.Windows.Forms.TextBox();
            this.txt_NoteTP = new System.Windows.Forms.TextBox();
            this.txt_NoteExamen = new System.Windows.Forms.TextBox();
            this.txt_Moyenne = new System.Windows.Forms.TextBox();
            this.lst_Moyenne = new System.Windows.Forms.ListBox();
            this.btn_Calculer = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_NomPrenom
            // 
            this.txt_NomPrenom.Location = new System.Drawing.Point(118, 34);
            this.txt_NomPrenom.Name = "txt_NomPrenom";
            this.txt_NomPrenom.Size = new System.Drawing.Size(100, 20);
            this.txt_NomPrenom.TabIndex = 0;
            this.txt_NomPrenom.TextChanged += new System.EventHandler(this.txt_NomPrenom_TextChanged);
            // 
            // txt_NoteDS
            // 
            this.txt_NoteDS.Location = new System.Drawing.Point(118, 82);
            this.txt_NoteDS.Name = "txt_NoteDS";
            this.txt_NoteDS.Size = new System.Drawing.Size(100, 20);
            this.txt_NoteDS.TabIndex = 1;
            this.txt_NoteDS.TextChanged += new System.EventHandler(this.txt_NoteDS_TextChanged);
            this.txt_NoteDS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NoteDS_KeyPress);
            // 
            // txt_NoteTP
            // 
            this.txt_NoteTP.Location = new System.Drawing.Point(118, 172);
            this.txt_NoteTP.Name = "txt_NoteTP";
            this.txt_NoteTP.Size = new System.Drawing.Size(100, 20);
            this.txt_NoteTP.TabIndex = 2;
            this.txt_NoteTP.TextChanged += new System.EventHandler(this.txt_NoteTP_TextChanged);
            // 
            // txt_NoteExamen
            // 
            this.txt_NoteExamen.Location = new System.Drawing.Point(118, 128);
            this.txt_NoteExamen.Name = "txt_NoteExamen";
            this.txt_NoteExamen.Size = new System.Drawing.Size(100, 20);
            this.txt_NoteExamen.TabIndex = 3;
            this.txt_NoteExamen.TextChanged += new System.EventHandler(this.txt_NoteExamen_TextChanged);
            // 
            // txt_Moyenne
            // 
            this.txt_Moyenne.Enabled = false;
            this.txt_Moyenne.Location = new System.Drawing.Point(118, 211);
            this.txt_Moyenne.Name = "txt_Moyenne";
            this.txt_Moyenne.Size = new System.Drawing.Size(100, 20);
            this.txt_Moyenne.TabIndex = 4;
            this.txt_Moyenne.Click += new System.EventHandler(this.txt_Moyenne_Click);
            this.txt_Moyenne.TextChanged += new System.EventHandler(this.txt_Moyenne_TextChanged);
            // 
            // lst_Moyenne
            // 
            this.lst_Moyenne.FormattingEnabled = true;
            this.lst_Moyenne.Location = new System.Drawing.Point(328, 37);
            this.lst_Moyenne.Name = "lst_Moyenne";
            this.lst_Moyenne.Size = new System.Drawing.Size(366, 173);
            this.lst_Moyenne.TabIndex = 5;
            this.lst_Moyenne.SelectedIndexChanged += new System.EventHandler(this.lst_Moyenne_SelectedIndexChanged);
            // 
            // btn_Calculer
            // 
            this.btn_Calculer.Enabled = false;
            this.btn_Calculer.Location = new System.Drawing.Point(118, 274);
            this.btn_Calculer.Name = "btn_Calculer";
            this.btn_Calculer.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculer.TabIndex = 6;
            this.btn_Calculer.Text = "Calculer";
            this.btn_Calculer.UseVisualStyleBackColor = true;
            this.btn_Calculer.Click += new System.EventHandler(this.btn_Calculer_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Enabled = false;
            this.btn_Ajouter.Location = new System.Drawing.Point(294, 274);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 7;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Enabled = false;
            this.btn_Supprimer.Location = new System.Drawing.Point(465, 274);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_Supprimer.TabIndex = 8;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom et Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Note Examan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Note DS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Note TP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Moyenne";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 339);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_Calculer);
            this.Controls.Add(this.lst_Moyenne);
            this.Controls.Add(this.txt_Moyenne);
            this.Controls.Add(this.txt_NoteExamen);
            this.Controls.Add(this.txt_NoteTP);
            this.Controls.Add(this.txt_NoteDS);
            this.Controls.Add(this.txt_NomPrenom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NomPrenom;
        private System.Windows.Forms.TextBox txt_NoteDS;
        private System.Windows.Forms.TextBox txt_NoteTP;
        private System.Windows.Forms.TextBox txt_NoteExamen;
        private System.Windows.Forms.TextBox txt_Moyenne;
        private System.Windows.Forms.ListBox lst_Moyenne;
        private System.Windows.Forms.Button btn_Calculer;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

