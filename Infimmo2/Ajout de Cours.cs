using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace Infimmo2
{
    public partial class Ajout_de_Cours : Form
    {

        SQLiteConnection sqlConnexion;
        SQLiteCommand sqlCommande;
        SQLiteDataReader sqlLecteur;

        //String path = @"C:\Users\Alexis\Documents\Visual Studio 2012\Projects\Infimmo2\Infimmo2\DBSQLite";

        public Ajout_de_Cours()
        {
            InitializeComponent();

            String path = Path.GetDirectoryName(Application.ExecutablePath);
            String chnAppli = Path.Combine(path, "DBSQLite");

            try
            {
                String chn = "Data Source=" + chnAppli + ";Version=3";
                sqlConnexion = new SQLiteConnection(chn);
                sqlConnexion.Open();
                sqlCommande = sqlConnexion.CreateCommand();

                this.Refresh();
            }
            catch { }
        }

        private void btnValiderTitre_Click(object sender, EventArgs e)
        {
            try
            {
                String path = Path.GetDirectoryName(Application.ExecutablePath);
                String chnAppli = Path.Combine(path, "DBSQLite");
                String chn = "Data Source=" + chnAppli + ";Version=3";
                using (sqlConnexion = new SQLiteConnection(chn))
                {
                    sqlConnexion.Open();
                    using (sqlCommande = sqlConnexion.CreateCommand())
                    {
                        sqlCommande.CommandText = "INSERT INTO Cours VALUES (\"" + txbTitre.Text + "\", NULL)";
                        sqlLecteur = sqlCommande.ExecuteReader();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbTitre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
