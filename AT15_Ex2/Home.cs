using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AT15_Ex2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        void Changer_Form(Form NewForm)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            NewForm.MdiParent = this;
            NewForm.Dock = DockStyle.Fill;
            NewForm.Show();
        }

        private void listeChauffeursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new ListeChauffeurs());
        }

        private void listeVoyagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new listeVoyages());

        }

        private void listeVoyagesChauffeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new voyages_par_chauffeur());

        }

        private void listeVoyagesVilleDépartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new voyages_par_ville_depart());

        }

        private void listeDesVoyagesÀVenirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changer_Form(new voyages_venir());

        }
    }
}
