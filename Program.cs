using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Felhasznalo_keppel
{
    internal static class Program
    {
        static public MainGUI maingui = null;
        static public UjAdatForm ujadatform = null;
        static public ModositForm modositform = null;
        static public TorolForm torolform = null;
        static public Adatbazis adat = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            torolform = new TorolForm();
            modositform = new ModositForm();
            ujadatform = new UjAdatForm();
            maingui = new MainGUI();
            adat = new Adatbazis("localhost", "root", "", "felhasznalok");
            Application.Run(maingui);
        }
    }
}
