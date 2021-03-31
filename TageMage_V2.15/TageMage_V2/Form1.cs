using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TageMage_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //
        //Initialisation des variables
        //
        SqlDataAdapter adapteur;
        DataSet ds;
        Config config = new Config();
        int zoom = 14;

        //
        //CHARGEMENT TABLES
        //
        private void btnCalcul_Click(object sender, EventArgs e)
        {
            //Parametres configuration
            config.nomTable = "Calcul";
            config.colonneID = 1;
            config.colonneQuestion = 2;
            config.colonneImage = 3;
            config.colonneCorrection = 4;
            config.reglage = new List<bool> { true, true, true, true, true, true, true, 
                true, true, true, true, true, true};
            config.taille = new List<int> { 80, 50, 710, 150, 670 };
            parametrage();
        }
        private void btnCondMini_Click(object sender, EventArgs e)
        {
            //Parametres configuration
            config.nomTable = "CondMini";
            config.colonneID = 0;
            config.colonneQuestion = 1;
            config.colonneCorrection = 2;
            config.colonneImage = 0;
            config.reglage = new List<bool> { false, true, true, false, false, true, true, 
                true, true, true, true, false, true };
            config.taille = new List<int> { 50, 750, 860, 0, 0 };
            parametrage();
        }
        private void btnRaisonnement_Click(object sender, EventArgs e)
        {
            //Parametres configuration
            config.nomTable = "Raisonnement";
            config.colonneID = 0;
            config.colonneQuestion = 1;
            config.colonneCorrection = 2;
            config.colonneImage = 3;
            config.reglage = new List<bool> { false, true, true, true, true, false, false,
                    true, true, true, true, true, false };
            config.taille = new List<int> { 50, 700, 660, 250, 0 };
            parametrage();
        }
        private void btnExpression_Click(object sender, EventArgs e)
        {
            //Parametres configuration
            config.nomTable = "Expression";
            config.colonneID = 0;
            config.colonneQuestion = 1;
            config.colonneCorrection = 2;
            config.reglage = new List<bool> { false, true, true, false, false, false, false,
                    true, true, true, true , false, false};
            config.taille = new List<int> { 50, 910, 700, 0, 0 };
            parametrage();
        }
        public void parametrage()
        {
            //Connexion base de données
            config.connexion(config.nomTable, ref adapteur, ref ds, dataGridViewExo);
            //Mise en forme
            config.mettreEnForme(dataGridViewExo, zoom, config.taille);
            config.reglageFiltresBoutons(config.reglage, textBoxFiltreCatego, textBoxFiltreID, textBoxFiltreQuestion,
                btnAjoutImage, btnAjoutCorrection, btnSupprImage, btnSupprimerCorrection,
                btnHaut, btnBas, btnSave, checkBoxCorrection, ajouterImageToolStripMenuItem, ajouterCorrectionToolStripMenuItem);
            labelEnCours.Text = config.nomTable;
        }


        //
        //BOUTONS
        //
        //Filtres
        private void textBoxFiltreCatego_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables[config.nomTable];
            config.filtre(ds, dt, dataGridViewExo, "Catégorie", textBoxFiltreCatego.Text, config.nomTable, zoom, config.taille);
        }
        private void textBoxFiltreID_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables[config.nomTable];
            config.filtre(ds, dt, dataGridViewExo, "ID", textBoxFiltreID.Text, config.nomTable, zoom, config.taille);
        }
        private void textBoxFiltreQuestion_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables[config.nomTable];
            config.filtre(ds, dt, dataGridViewExo, "Question", textBoxFiltreQuestion.Text, config.nomTable, zoom, config.taille);
        }

        //Sauvegarde
        private void btnSave_Click(object sender, EventArgs e)
        {
            Fonction.sauvegarde(adapteur, ds, config);
        }

        //Boutons images
        private void btnAjoutImage_Click(object sender, EventArgs e)
        {
            int ligne = dataGridViewExo.CurrentCell.RowIndex;
            Fonction.afficherImage(dataGridViewExo, ligne, config.colonneImage);
        }
        private void btnSupprImage_Click(object sender, EventArgs e)
        {
            int ligne = dataGridViewExo.CurrentCell.RowIndex;
            Fonction.supprimerImage(dataGridViewExo, ligne, config.colonneImage);
        }
        private void btnAjoutCorrection_Click(object sender, EventArgs e)
        {
            int ligne = dataGridViewExo.CurrentCell.RowIndex;
            Fonction.afficherImage(dataGridViewExo, ligne, config.colonneCorrection);
        }
        private void btnSupprimerCorrection_Click(object sender, EventArgs e)
        {
            int ligne = dataGridViewExo.CurrentCell.RowIndex;
            Fonction.supprimerImage(dataGridViewExo, ligne, config.colonneCorrection);
        }

        //Boutons scrolling
        private void btnBas_Click(object sender, EventArgs e)
        {
            Fonction.allerEnBas(dataGridViewExo);
        }
        private void btnHaut_Click(object sender, EventArgs e)
        {
            Fonction.allerEnHaut(dataGridViewExo);
        }

        //Boutons zoom
        private void btnZoomPlus_Click(object sender, EventArgs e)
        {
            if (zoom <20)
            {
                zoom++;
                dataGridViewExo.DefaultCellStyle.Font = new Font("Calibri", zoom);
            }

        }
        private void btnZoomMoins_Click(object sender, EventArgs e)
        {
            if (zoom > 10)
            {
                zoom--;
                dataGridViewExo.DefaultCellStyle.Font = new Font("Calibri", zoom);
            }
        }

        //CheckBox Afficher/Masquer COrrections
        private void checkBoxCorrection_CheckedChanged(object sender, EventArgs e)
        {
            Fonction.affMasqCorrection(dataGridViewExo, checkBoxCorrection);
        }

        //Copie d'images
        private void dataGridViewExo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewExo.CurrentCell == dataGridViewExo.CurrentRow.Cells[config.colonneImage])
                {
                    byte[] img = (byte[])dataGridViewExo.CurrentRow.Cells[config.colonneImage].Value;
                    MemoryStream ms = new MemoryStream(img);
                    pictureBoxImage.Image = Image.FromStream(ms);
                    Clipboard.Clear();
                }
                else if (dataGridViewExo.CurrentCell == dataGridViewExo.CurrentRow.Cells[config.colonneCorrection])
                {
                    byte[] img = (byte[])dataGridViewExo.CurrentRow.Cells[config.colonneCorrection].Value;
                    MemoryStream ms = new MemoryStream(img);
                    pictureBoxImage.Image = Image.FromStream(ms);
                    Clipboard.Clear();
                }
            }
            catch (Exception)
            {
            }
        }
        private void btnCopie_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(pictureBoxImage.Image, true);
                pictureBoxImage.Image = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Selectionnez une image", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clipboard.Clear();
            }
        }

        //Capture ecran
        private void btnCapture_Click(object sender, EventArgs e)
        {
            Fonction.CopyDGVToClipBoard(dataGridViewExo);
        }


        //
        //MENUS
        //
        //Menu Fichier
        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fonction.sauvegarde(adapteur, ds, config);
        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void allerEnHautToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewExo.Enabled == true)
            {
                Fonction.allerEnHaut(dataGridViewExo);
            }
        }
        private void allerEnBasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewExo.Enabled == true)
            {
                Fonction.allerEnBas(dataGridViewExo);
            }
        }

        //Menu Edition
        private void ajouterImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
                int ligne = dataGridViewExo.CurrentCell.RowIndex;
                Fonction.afficherImage(dataGridViewExo, ligne, config.colonneImage);
        }
        private void ajouterCorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
                int ligne = dataGridViewExo.CurrentCell.RowIndex;
                Fonction.afficherImage(dataGridViewExo, ligne, config.colonneCorrection);
        }
        private void afficherMasquerCorrectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewExo.Enabled == true)
            {
                if (checkBoxCorrection.Checked == true)
                {
                    checkBoxCorrection.Checked = false;
                    Fonction.affMasqCorrection(dataGridViewExo, checkBoxCorrection);
                }
                else
                {
                    checkBoxCorrection.Checked = true;
                    Fonction.affMasqCorrection(dataGridViewExo, checkBoxCorrection);
                }
            }
        }
    }
}
