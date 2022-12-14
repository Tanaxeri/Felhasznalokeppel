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
    public partial class UjAdatForm : Form
    {
        public UjAdatForm()
        {
            InitializeComponent();
        }

        private void HozzadButton_Click(object sender, EventArgs e)
        {

            if (Program.adat.Hozzaadas(NevText.Text, (DateTime)DateTime.Value, Profilkep.ToString()))
            {

                NevText.Text = "";
                DateTime.ResetText();
                Profilkep.ResetText();

            }

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
