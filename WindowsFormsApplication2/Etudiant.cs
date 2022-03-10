using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Etudiant
    {
        string nomPrenom;
        float noteDs;
        float noteExaman;
        float noteTp;

        public Etudiant(string nomPrenom, float noteDs, float noteExaman, float noteTp)
        {
            this.nomPrenom = nomPrenom;
            this.noteDs = noteDs;
            this.noteExaman = noteExaman;
            this.noteTp = noteTp;
        }

        public double calculMoy()
        {
            double calculMoy=  (this.noteDs * 0.3) + (this.noteTp * 0.2) + (this.noteExaman * 0.5);
            return calculMoy;
        }



    }
}
