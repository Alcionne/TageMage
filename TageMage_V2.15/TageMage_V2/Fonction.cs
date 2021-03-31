using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TageMage_V2
{
    static public class Fonction
    {
        //Affichage image
        public static void afficherImage(DataGridView dgv, int row, int col)
        {
            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Choisir une image(*.png;)|*.png;";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    dgv[col, row].Value = Image.FromFile(opf.FileName);
                    try
                    {
                        dgv.CurrentCell = dgv.Rows[row - 1].Cells[2];
                        dgv.CurrentCell = dgv.Rows[row].Cells[0];
                    }
                    catch (Exception)
                    {
                        dgv.CurrentCell = dgv.Rows[row + 1].Cells[2];
                        dgv.CurrentCell = dgv.Rows[row].Cells[0];
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur !!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Suppression image
        public static void supprimerImage(DataGridView dgv, int row, int col)
        {
            try
            {
                dgv[col, row].Value = null;
                try
                {
                    dgv.CurrentCell = dgv.Rows[row - 1].Cells[2];
                    dgv.CurrentCell = dgv.Rows[row].Cells[0];
                }
                catch (Exception)
                {
                    dgv.CurrentCell = dgv.Rows[row + 1].Cells[2];
                    dgv.CurrentCell = dgv.Rows[row].Cells[0];
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Un numéro de ligne doit être renseigné pour supprimer l'image", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Scrolling
        public static void allerEnBas(DataGridView dgv)
        {
            int nRowIndex = dgv.RowCount - 2;
            dgv.CurrentCell = dgv.Rows[nRowIndex].Cells[0];
            dgv.FirstDisplayedScrollingRowIndex = nRowIndex;
        }
        public static void allerEnHaut(DataGridView dgv)
        {
            int nRowIndex = 0;
            dgv.CurrentCell = dgv.Rows[nRowIndex].Cells[0];
            dgv.FirstDisplayedScrollingRowIndex = nRowIndex;
        }

        //Sauvegarde
        public static void sauvegarde(SqlDataAdapter adapt, DataSet ds, Config conf)
        {
            try
            {
                SqlCommandBuilder cmbdl = new SqlCommandBuilder(adapt);
                if (adapt != null)
                {
                    adapt.Update(ds, conf.nomTable);
                    MessageBox.Show("Informations sauvegardées", "Sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("L'ID doit être renseigné et être unique", "Erreur de mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Afficher/Masquer corrections
        public static void affMasqCorrection(DataGridView dgv, CheckBox checkCorrect)
        {
            if (checkCorrect.Checked == false)
            {
                dgv.Columns["Correction"].Visible = false;
                if (dgv.Columns["Schéma"] != null)
                {
                    dgv.Columns["Schéma"].Visible = false;
                }
            }
            if (checkCorrect.Checked == true)
            {
                dgv.Columns["Correction"].Visible = true;
                if (dgv.Columns["Schéma"] != null)
                {
                    dgv.Columns["Schéma"].Visible = true;
                }
            }
        }

        //Capture ecran
        public static void CopyDGVToClipBoard(DataGridView dgv)
        {
            int height, width;
            height = 968;
            width = 1720;
            Bitmap image = new Bitmap(width, height);
            dgv.DrawToBitmap(image, new Rectangle(0, 0, width, height));
            Clipboard.SetImage(image);
        }
    }
}
