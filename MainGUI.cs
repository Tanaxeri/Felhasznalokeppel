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
    public partial class MainGUI : Form
    {

        public static string Text0 = "";
        public static string Text1 = "";
        public static DateTime Text2;
        public static string Text3 = "";

        public MainGUI()
        {
            InitializeComponent();
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {

            FelGrid_felepites();
            FelGrid_frissit();

        }

        private void FelGrid_frissit()
        {

            Felhaszdata.Rows.Clear();

            foreach (FelhaszAdat rekord in Program.adat.osszesFelhasz())
            {

                int ISor = Felhaszdata.Rows.Add();
                DataGridViewRow ujsor = Felhaszdata.Rows[ISor];
                ujsor.Cells["id"].Value = rekord.Id;
                ujsor.Cells["nev"].Value = rekord.Nev;
                ujsor.Cells["szuldat"].Value = rekord.Szuldat;
                ujsor.Cells["profilkep"].Value = rekord.Profilkep;

            }

        }

        private void FelGrid_felepites()
        {
            
            DataGridViewColumn col_ID = new DataGridViewColumn();
            {

                col_ID.Name = "id";
                col_ID.ReadOnly = true;
                col_ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ID.HeaderText = "Felhasználói azonosító";

            }
            Felhaszdata.Columns.Add(col_ID);

            DataGridViewColumn col_nev = new DataGridViewColumn();
            {

                col_nev.Name = "nev";
                col_nev.CellTemplate = new DataGridViewTextBoxCell();
                col_nev.HeaderText = "Felhasználó neve";

            }
            Felhaszdata.Columns.Add(col_nev);

            DataGridViewColumn col_szuldat = new DataGridViewColumn();
            {

                col_szuldat.Name = "szuldat";
                col_szuldat.CellTemplate = new DataGridViewTextBoxCell();
                col_szuldat.HeaderText = "Felhasználó születési dátuma";

            }
            Felhaszdata.Columns.Add(col_szuldat);

            DataGridViewColumn col_profilkep = new DataGridViewColumn();
            {

                col_profilkep.Name = "";
                col_profilkep.CellTemplate = new DataGridViewTextBoxCell();
                col_profilkep.HeaderText = "Felhasználó profilképe";

            }
            Felhaszdata.Columns.Add(col_profilkep);

            Felhaszdata.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Felhaszdata_SelectionChanged(object sender, EventArgs e)
        {

            if (Felhaszdata.SelectedRows.Count < 1)
            {

                return;

            }

            DataGridViewRow row = Felhaszdata.SelectedRows[0];

            if (row.Cells["id"].Value == null)
            {

                return;

            }

            Text0 = row.Cells["id"].Value.ToString();
            Text1 = row.Cells["nev"].Value.ToString();
            Text2 = DateTime.Parse(row.Cells["szuldat"].Value.ToString());
            Text3 = row.Cells["profilkep"].Value.ToString();

        }

        private void UjAdat_M_Click(object sender, EventArgs e)
        {

            Program.ujadatform.ShowDialog();

            FelGrid_frissit();
        }

        private void Modos_M_Click(object sender, EventArgs e)
        {

            Program.modositform.ShowDialog();

            FelGrid_frissit();
        }

        private void Torol_M_Click(object sender, EventArgs e)
        {

            Program.torolform.ShowDialog();

            FelGrid_frissit();
        }
    }
}
