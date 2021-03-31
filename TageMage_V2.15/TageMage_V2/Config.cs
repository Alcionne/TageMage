using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace TageMage_V2
{
    public class Config
    {
        public string nomTable { get; set; }
        public int colonneID { get; set; }
        public int colonneQuestion { get; set; }
        public int colonneImage { get; set; }
        public int colonneCorrection { get; set; }
        public List<int> taille { get; set; }
        public List<bool> reglage { get; set; }

        public Config ()
        {
        }

        public void connexion(string tble, ref SqlDataAdapter adapt, ref DataSet ds, DataGridView dgv)
        {
            //Chaine de connexion
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["ConnectStringFile"];
            string chaineDeConnexion = settings.ConnectionString;
            //Connexion et affichage
            SqlConnection connexion = new SqlConnection(chaineDeConnexion);
            string affichageQuestion = "SELECT * FROM " + tble;
            adapt = new SqlDataAdapter(affichageQuestion, connexion);
            ds = new DataSet();
            adapt.Fill(ds, tble);
            dgv.Enabled = true;
            dgv.DataSource = ds;
            dgv.DataMember = tble;
        }

        public void mettreEnForme(DataGridView dgv, int z, List<int> t)
        {
            //Redimensionnement
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.Columns[0].Width = t[0];
            dgv.Columns[1].Width = t[1];
            try
            {
                dgv.Columns[2].Width = t[2];
            }
            catch (Exception)
            {
            }
            try
            {
                dgv.Columns[3].Width = t[3];
            }
            catch (Exception)
            {
            }
            try
            {
                dgv.Columns[4].Width = t[4];
            }
            catch (Exception)
            {
            }
            //Police
            dgv.DefaultCellStyle.Font = new Font("Calibri", z);
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            //Suppression des croix de la colonne image
            foreach (var column in dgv.Columns)
            {
                if (column is DataGridViewImageColumn)
                    (column as DataGridViewImageColumn).DefaultCellStyle.NullValue = null;
            }
            //Couleurs
            dgv.RowsDefaultCellStyle.BackColor = Color.LightCyan;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        //Reglages boutons et filtres
        public void reglageFiltresBoutons(List<bool> r, TextBox txtCatego, TextBox txtID, TextBox txtQuest,
                Button btnImg, Button btnCorrect, Button btnSupImg, Button btnSupCorrect, Button btnH, Button btnB, Button btnS,
                CheckBox checkCorrect, ToolStripMenuItem btnImgMenu, ToolStripMenuItem btnCorrectMenu)
        {
            txtCatego.Enabled = r[0];
            txtID.Enabled = r[1];
            txtQuest.Enabled = r[2];
            btnImg.Enabled = r[3];
            btnSupImg.Enabled = r[4];
            btnCorrect.Enabled = r[5];
            btnSupCorrect.Enabled = r[6];
            btnH.Enabled = r[7];
            btnB.Enabled = r[8];
            btnS.Enabled = r[9];
            checkCorrect.Enabled = r[10];
            btnImgMenu.Enabled = r[11];
            btnCorrectMenu.Enabled = r[12];
        }

        //Filtres
        public void filtre(DataSet ds, DataTable dt, DataGridView dgv, string colonne, 
            string textbox, string tble, int z, List<int> t)
        {
            dt = ds.Tables[tble];
            DataView dv = new DataView(dt);
            BindingSource source = new BindingSource();
            source.DataSource = dv;
            try
            {
                source.Filter = colonne + " LIKE '%" + textbox + "%'";
            }
            catch
            {
                source.Filter = "Convert(" + colonne + ", 'System.String') like '%" + textbox + "%'";
            }
            dgv.DataSource = dv;
            mettreEnForme(dgv, z, t);
        }
    }
}
