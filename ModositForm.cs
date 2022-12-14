using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Felhasznalo_keppel
{
    public partial class ModositForm : Form
    {
        public ModositForm()
        {
            InitializeComponent();
        }

        private void ModositButton_Click(object sender, EventArgs e)
        {

            if (Program.adat.Modosit(int.Parse(AzonText.Text), NevText.Text, (DateTime)DateTime.Value, Profilkep.ToString()))
            {



            }

            Close();
        }

        private void ModositForm_Load(object sender, EventArgs e)
        {

            Program.modositform.AzonText.Text = MainGUI.Text0;
            Program.modositform.NevText.Text = MainGUI.Text1;
            Program.modositform.DateTime.Value = MainGUI.Text2;
            Program.modositform.Profilkep.Text = MainGUI.Text3;

        }

        private void Kepgomb_Click(object sender, EventArgs e)
        {

            FileOpenDialog.Filter = "Minden fájl (*.*)|*.*|PNG fájl (*.png)|*.png|JPG fájl (*.jpg)|*.jpg|WEBP fájl (*.webp)|*.webp";
            if (FileOpenDialog.ShowDialog() == DialogResult.OK)
            {

                string fajl = FileOpenDialog.FileName;
                Profilkep.Image = Image.FromFile(fajl);

            }

        }
    }
}
