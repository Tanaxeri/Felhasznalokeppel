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
    public partial class TorolForm : Form
    {
        public TorolForm()
        {
            InitializeComponent();
        }

        private void TorolButton_Click(object sender, EventArgs e)
        {

            if (Program.adat.Modosit(int.Parse(AzonText.Text), NevText.Text, (DateTime)DateTime.Value, Profilkep.ToString()))
            {



            }

            Close();

        }

        private void TorolForm_Load(object sender, EventArgs e)
        {

            Program.modositform.AzonText.Text = MainGUI.Text0;
            Program.modositform.NevText.Text = MainGUI.Text1;
            Program.modositform.DateTime.Value = MainGUI.Text2;
            Program.modositform.Profilkep.Text = MainGUI.Text3;

        }
    }
}
