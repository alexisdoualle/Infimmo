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
using System.Text.RegularExpressions;

//xcopy "C:\Users\Alexis\Documents\Visual Studio 2012\Projects\Infimmo2\Infimmo2\bin\Debug" C:\Infimmo

namespace Infimmo2
{
    public partial class Form1 : Form
    {
        double nombre1=0;
        double nombre2=0;
        bool calculFini = false;
        bool operation = false;
        bool mult = false;
        bool div = false;
        bool sous = false;

        SQLiteConnection sqlConnexion;
        SQLiteCommand sqlCommande;
        SQLiteDataReader sqlLecteur;
        String crlf = System.Environment.NewLine;
        bool connecté = false;

        //String path = @"C:\Users\Alexis\Documents\Visual Studio 2012\Projects\Infimmo2\Infimmo2\DBSQLite";

        public Form1()
        {
            InitializeComponent();



            try
            {
                String path = Path.GetDirectoryName(Application.ExecutablePath);
                String chnAppli = Path.Combine(path, "DBSQLite");
                String chn = "Data Source=" + chnAppli + ";Version=3";
                using (sqlConnexion = new SQLiteConnection(chn))
                {
                    sqlConnexion.Open();
                    sqlCommande = sqlConnexion.CreateCommand();
                    connecté = true;
                    this.Refresh();
            
                }
            }
            catch { }
            rafraichir();
/*
            sqlCommande.CommandText = "SELECT titre FROM Cours";
            sqlLecteur = sqlCommande.ExecuteReader();
            DataTable tb = new DataTable();
            tb.Load(sqlLecteur);

            foreach (DataRow row in tb.Rows)
            {
                String titre = row["titre"].ToString();
                comboBox1.Items.Add(titre);
            }
*/
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox2.Text) / 100;
                double b = a * double.Parse(textBox3.Text);
                textBox4.Text = b.ToString();
            }
            catch
            {
                textBox4.Text = "";
            }
            try
            {
                double c = double.Parse(textBox5.Text);
                double d = double.Parse(textBox6.Text);
                double f = (c / d) * 100;
                textBox7.Text = f.ToString();
            }
            catch 
            {
                textBox7.Text = "";
            }

        }

        private void classiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlCalculatricePC.Visible = false;
            pnlCalc2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (calculFini)
            {
                textCalcResultat.Text = ""; 
                txbNombres.Text = "";
            }
            calculFini = false;
            textCalcResultat.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (calculFini)
            {
                textCalcResultat.Text = "";
                txbNombres.Text = "";
            }
            calculFini = false;
            textCalcResultat.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (calculFini)
            {
                textCalcResultat.Text = "";
                txbNombres.Text = "";
            }
            calculFini = false;
            textCalcResultat.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (calculFini)
            {
                textCalcResultat.Text = "";
                txbNombres.Text = "";
            }
            calculFini = false;
            textCalcResultat.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (calculFini)
            {
                textCalcResultat.Text = "";
                txbNombres.Text = "";
            }
            calculFini = false;
            textCalcResultat.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (calculFini)
            {
                textCalcResultat.Text = "";
                txbNombres.Text = "";
            }
            calculFini = false;
            textCalcResultat.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (calculFini)
            {
                textCalcResultat.Text = "";
                txbNombres.Text = "";
            }
            calculFini = false;
            textCalcResultat.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (calculFini)
            {
                textCalcResultat.Text = "";
                txbNombres.Text = "";
            }
            calculFini = false;
            textCalcResultat.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (calculFini)
            {
                textCalcResultat.Text = "";
                txbNombres.Text = "";
            }
            calculFini = false;
            textCalcResultat.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (calculFini)
            {
                textCalcResultat.Text = "";
                txbNombres.Text = "";
            }
            calculFini = false;
            textCalcResultat.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (calculFini)
            {
                textCalcResultat.Text = "";
                txbNombres.Text = "";
            }
            calculFini = false;
            textCalcResultat.Text += ",";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
            nombre1 += double.Parse(textCalcResultat.Text);
            textCalcResultat.Text = "";
            txbNombres.Text += nombre1 + "+";
            sous = false;
            mult = false;
            div = false;

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            nombre2 = double.Parse(textCalcResultat.Text);
            if (mult)
            {
                double produit = nombre1 * nombre2;
                textCalcResultat.Text = produit.ToString();
            }
            else
            {
                if (div)
                {
                    double divis = nombre1 / nombre2;
                    textCalcResultat.Text = divis.ToString();
                }
                else
                {
                    if (sous)
                    {
                        double soustra = nombre1 - nombre2;
                        textCalcResultat.Text = soustra.ToString();
                    }
                    else
                    {
                        double somme = nombre2 + nombre1;
                        txbNombres.Text += textCalcResultat.Text+"=";
                   
                        textCalcResultat.Text = somme.ToString();
                    }
                }
            }
            calculFini = true;
            operation = false;
            mult = false;
            div = false;
            sous = false;
            nombre1 = 0;
            nombre2 = 0;

        }

        private void pourcentageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlCalculatricePC.Visible = !false;
            pnlCalc2.Visible = !true;
        }

        private void buttonSous_Click(object sender, EventArgs e)
        {
            nombre1 = double.Parse(textCalcResultat.Text);
            operation = true;
            sous = true;
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            
            nombre1 = double.Parse(textCalcResultat.Text);
            operation = true;
            mult = true;
            
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            nombre1 = double.Parse(textCalcResultat.Text);
            operation = true;
            div = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (connecté)
            {
                stsConnexion.Text = "Base de donnée connectée";
                stsConnexion.BackColor = System.Drawing.Color.PaleGreen;
            }
            else
            {
                stsConnexion.Text = "Base de donnée déconnectée";
                stsConnexion.BackColor = System.Drawing.Color.Tomato;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textCalcResultat.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_de_Cours fiche = new Ajout_de_Cours();
            if (fiche.ShowDialog() == DialogResult.OK)
            {

            }
            rafraichir();
            fiche.Dispose();
            comboBox1.Text = comboBox1.Items[comboBox1.Items.Count - 1].ToString();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            try
            {

                String path = Path.GetDirectoryName(Application.ExecutablePath);
                String chnAppli = Path.Combine(path, "DBSQLite");
                String chn = "Data Source=" + chnAppli + ";Version=3";
                using (sqlConnexion = new SQLiteConnection(chn))
                {
                    sqlConnexion.Open();
                    sqlCommande = sqlConnexion.CreateCommand();
                    connecté = true;
                    sqlLecteur.Close();
                    String chn5 = comboBox1.SelectedItem.ToString();
                    sqlCommande.CommandText = "SELECT Contenu FROM Cours WHERE Titre = \"" + chn5 + "\"";
                    sqlLecteur = sqlCommande.ExecuteReader();
                    txbContenu.Text = sqlLecteur[0].ToString();
                    rafraichir();
                    this.Refresh();

                }
            }
            catch { }
  
        }


        private void comboBox1_CursorChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        
        private String chaineCharEchappement(String ch)
        {
            int i = 0;
            String ch2 = ch;
            foreach (Match m in Regex.Matches(ch,"\""))
            {  
                ch2 = ch2.Insert(m.Index+i, "\"");
                i++;
            }
            return ch2;
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            try
            {

                String path = Path.GetDirectoryName(Application.ExecutablePath);
                String chnAppli = Path.Combine(path, "DBSQLite");
                String chn3 = "Data Source=" + chnAppli + ";Version=3";
                using (sqlConnexion = new SQLiteConnection(chn3))
                {
                    sqlConnexion.Open();
                    sqlCommande = sqlConnexion.CreateCommand();
                    connecté = true;

                    String chn = chaineCharEchappement(txbContenu.Text);
                    String chn2 = comboBox1.SelectedItem.ToString();

                    sqlCommande.CommandText = "UPDATE Cours SET Contenu = \" " + chn + "\" WHERE Titre = \"" + chn2 + "\"";
                    sqlLecteur = sqlCommande.ExecuteReader();

                    this.Refresh();

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            String ch1;
            ch1 = chaineCharEchappement(txbContenu.Text);
            txbContenu.Text = ch1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String path = Path.GetDirectoryName(Application.ExecutablePath);
                String chnAppli = Path.Combine(path, "DBSQLite");
                String chn = "Data Source=" + chnAppli + ";Version=3";
                using (sqlConnexion = new SQLiteConnection(chn))
                {
                    sqlConnexion.Open();
                    sqlCommande = sqlConnexion.CreateCommand();
                    connecté = true;
                    
                    String chn8 = comboBox1.SelectedItem.ToString();
                    sqlCommande.CommandText = "SELECT Contenu FROM Cours WHERE Titre = \"" + chn8 + "\"";
                    sqlLecteur = sqlCommande.ExecuteReader();
                    txbContenu.Text = sqlLecteur[0].ToString();
                    this.Refresh();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void rafraichir()
        {
            
            try
            {
                String path = Path.GetDirectoryName(Application.ExecutablePath);
                String chnAppli = Path.Combine(path, "DBSQLite");
                String chn = "Data Source=" + chnAppli + ";Version=3";
                using (sqlConnexion = new SQLiteConnection(chn))
                {
                    sqlConnexion.Open();
                    sqlCommande = sqlConnexion.CreateCommand();
                    connecté = true;

                    comboBox1.Items.Clear();
                    sqlCommande.CommandText = "SELECT titre FROM Cours";
                    sqlLecteur = sqlCommande.ExecuteReader();
                    DataTable tb = new DataTable();
                    tb.Load(sqlLecteur);

                    foreach (DataRow row in tb.Rows)
                    {
                        String titre = row["titre"].ToString();
                        comboBox1.Items.Add(titre);
                    }
                    comboBox1.Text = "Sélectionez un chapitre...";

                    this.Refresh();

                }
            }
            catch { }

        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {

        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr?", "Suppression de chapitre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    String path = Path.GetDirectoryName(Application.ExecutablePath);
                    String chnAppli = Path.Combine(path, "DBSQLite");
                    String chn = "Data Source=" + chnAppli + ";Version=3";
                    using (sqlConnexion = new SQLiteConnection(chn))
                    {
                        sqlConnexion.Open();
                        sqlCommande = sqlConnexion.CreateCommand();
                        connecté = true;
                        String chn9 = comboBox1.SelectedItem.ToString();
                        sqlCommande.CommandText = "DELETE FROM Cours WHERE titre = \"" + chn9 + "\" ";
                        sqlLecteur = sqlCommande.ExecuteReader();
                        rafraichir();
                        txbContenu.Text = "";
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String path = Path.GetDirectoryName(Application.ExecutablePath);
                String chnAppli = Path.Combine(path, "DBSQLite");
                String chn = "Data Source=" + chnAppli + ";Version=3";
                using (sqlConnexion = new SQLiteConnection(chn))
                {
                    sqlConnexion.Open();
                    sqlCommande = sqlConnexion.CreateCommand();
                    connecté = true;

                    sqlCommande.CommandText = "SELECT titre FROM Cours WHERE Contenu LIKE \"%" + txbSearch.Text + "%\"";
                    sqlLecteur = sqlCommande.ExecuteReader();

                    int nbrLignes = 0;
                    if (sqlLecteur.HasRows)
                    {
                        while (sqlLecteur.Read()) nbrLignes++;
                    }

                    String[] titres = new String[nbrLignes];
                    sqlLecteur.Close();

                    sqlLecteur = sqlCommande.ExecuteReader();
                    int i = 0;
                    while (sqlLecteur.Read())
                    {
                        titres[i] = sqlLecteur.GetString(0);
                        i++;
                    }
                    txbContenu.Text = "Des résultats ont été trouvés dans les chapitres suivants:" + crlf + crlf;
                    for (i = 0; i < nbrLignes; i++) txbContenu.Text += titres[i] + crlf;
            

                    this.Refresh();

                }
            }
            catch { }

        }

        private void btnRenommer_Click(object sender, EventArgs e)
        {
            titreForm = comboBox1.Text;
            Renommer fiche = new Renommer();
            if (fiche.ShowDialog() == DialogResult.OK)
            {
                
            }
            rafraichir();
            fiche.Dispose();
        }
        public static String titreForm;
    }
}
