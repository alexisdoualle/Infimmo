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
    public partial class Renommer : Form
    {

        SQLiteConnection sqlConnexion;
        SQLiteCommand sqlCommande;
        SQLiteDataReader sqlLecteur;

        public Renommer()
        {
            InitializeComponent();
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {


                String path = Path.GetDirectoryName(Application.ExecutablePath);
                String chnAppli = Path.Combine(path, "DBSQLite");

                try
                {
                    String chn = "Data Source=" + chnAppli + ";Version=3";
                    using (sqlConnexion = new SQLiteConnection(chn))
                    {
                        sqlConnexion.Open();
                        using (sqlCommande = sqlConnexion.CreateCommand())
                        {
                            String ch2 = Form1.titreForm;
                            sqlCommande.CommandText = "UPDATE Cours SET Titre = '" + txbChapitre.Text + "' WHERE Titre = '" + ch2 + "'";
                            sqlLecteur = sqlCommande.ExecuteReader();
                        }
                        sqlConnexion.Close();
                    }
                    this.Refresh();
                }
                catch { }



            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

        }
          
    }
}
