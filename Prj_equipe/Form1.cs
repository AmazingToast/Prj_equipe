using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_equipe
{
    public partial class Projet : Form
    {
        public Projet()
        {
            InitializeComponent();
            btn_ajouter.Enabled = false;
            btn_annuler.Enabled = false;
            btn_consulter.Enabled = false;
            btn_dernier.Enabled = false;
            btn_liste.Enabled = false;
            btn_lister.Enabled = false;
            btn_modifier.Enabled = false;
            btn_precedent.Enabled = false;
            btn_premier.Enabled = false;
            btn_quitter.Enabled = false;
            btn_sauvegarder.Enabled = false;
            btn_suivant.Enabled = false;
            btn_supprimer.Enabled = false;
        }
    }
}
