using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

      

        private void txt_NomPrenom_TextChanged(object sender, EventArgs e)
        {
            if (txt_NomPrenom.Text != "" && txt_NoteTP.Text !="" && txt_NoteExamen.Text !="" && txt_NoteDS.Text !="")
            {
                btn_Calculer.Enabled = true;
            }
            else
            {
                btn_Calculer.Enabled = false;
            }
        }

        private void txt_Moyenne_Click(object sender, EventArgs e)
        {
          
           // txt_Moyenne.TextChanged = 
        }

        private void btn_Calculer_Click(object sender, EventArgs e)
        {
            float noteDs = float.Parse(txt_NoteDS.Text);
            float noteTp = float.Parse(txt_NoteTP.Text);
            float noteExaman = float.Parse(txt_NoteExamen.Text);
            Etudiant e1 = new Etudiant(txt_NomPrenom.Text, noteDs, noteTp, noteExaman);
            double moyenne = e1.calculMoy();
            txt_Moyenne.Text = moyenne.ToString();

            btn_Ajouter.Enabled = true;
           // txt_NomPrenom.Enabled = false;
           // txt_NoteDS.Enabled = false;
           // txt_NoteExamen.Enabled = false;
           // txt_NoteTP.Enabled = false;
            
        }

        private void txt_Moyenne_TextChanged(object sender, EventArgs e)
        {
            btn_Ajouter.Enabled = true;
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            lst_Moyenne.Items.Add(txt_NomPrenom.Text + "                                " + txt_Moyenne.Text);
            txt_NomPrenom.Text = "";
            txt_NoteDS.Text = "";
            txt_NoteExamen.Text = "";
            txt_NoteTP.Text = "";
            txt_Moyenne.Clear();
            btn_Ajouter.Enabled = false;

        }

        private void txt_NoteDS_TextChanged(object sender, EventArgs e)
        {
            if (txt_NomPrenom.Text != "" && txt_NoteTP.Text != "" && txt_NoteExamen.Text != "" && txt_NoteDS.Text != "")
            {
                btn_Calculer.Enabled = true;
            }
            else
            {
                btn_Calculer.Enabled = false;
            }
        }

        private void txt_NoteExamen_TextChanged(object sender, EventArgs e)
        {
            if (txt_NomPrenom.Text != "" && txt_NoteTP.Text != "" && txt_NoteExamen.Text != "" && txt_NoteDS.Text != "")
            {
                btn_Calculer.Enabled = true;
            }
            else
            {
                btn_Calculer.Enabled = false;
            }
        }

        private void txt_NoteTP_TextChanged(object sender, EventArgs e)
        {
            if (txt_NomPrenom.Text != "" && txt_NoteTP.Text != "" && txt_NoteExamen.Text != "" && txt_NoteDS.Text != "")
            {
                btn_Calculer.Enabled = true;
            }
            else
            {
                btn_Calculer.Enabled = false;
            }
        }

        private void lst_Moyenne_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Supprimer.Enabled = true;
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            lst_Moyenne.Items.Remove(lst_Moyenne.SelectedItem);
            btn_Supprimer.Enabled = false;
        }

        private void txt_NoteDS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
