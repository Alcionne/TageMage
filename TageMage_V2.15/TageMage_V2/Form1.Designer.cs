
namespace TageMage_V2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridViewExo = new System.Windows.Forms.DataGridView();
            this.labelFiltreCatego = new System.Windows.Forms.Label();
            this.labelFiltreID = new System.Windows.Forms.Label();
            this.labelFiltreQuestion = new System.Windows.Forms.Label();
            this.textBoxFiltreCatego = new System.Windows.Forms.TextBox();
            this.textBoxFiltreID = new System.Windows.Forms.TextBox();
            this.textBoxFiltreQuestion = new System.Windows.Forms.TextBox();
            this.btnAjoutImage = new System.Windows.Forms.Button();
            this.btnSupprImage = new System.Windows.Forms.Button();
            this.groupBoxFiltre = new System.Windows.Forms.GroupBox();
            this.groupBoxImage = new System.Windows.Forms.GroupBox();
            this.btnSupprimerCorrection = new System.Windows.Forms.Button();
            this.btnAjoutCorrection = new System.Windows.Forms.Button();
            this.btnCopie = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allerEnHautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allerEnBasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherMasquerCorrectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxCorrection = new System.Windows.Forms.CheckBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.labelEnCours = new System.Windows.Forms.Label();
            this.btnZoomMoins = new System.Windows.Forms.Button();
            this.btnZoomPlus = new System.Windows.Forms.Button();
            this.btnExpression = new System.Windows.Forms.Button();
            this.btnRaisonnement = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.btnCondMini = new System.Windows.Forms.Button();
            this.btnCalcul = new System.Windows.Forms.Button();
            this.btnHaut = new System.Windows.Forms.Button();
            this.btnBas = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExo)).BeginInit();
            this.groupBoxFiltre.SuspendLayout();
            this.groupBoxImage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExo
            // 
            this.dataGridViewExo.AllowUserToResizeColumns = false;
            this.dataGridViewExo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewExo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExo.Enabled = false;
            this.dataGridViewExo.Location = new System.Drawing.Point(154, 30);
            this.dataGridViewExo.Name = "dataGridViewExo";
            this.dataGridViewExo.Size = new System.Drawing.Size(1720, 968);
            this.dataGridViewExo.TabIndex = 0;
            this.dataGridViewExo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExo_CellClick);
            // 
            // labelFiltreCatego
            // 
            this.labelFiltreCatego.AutoSize = true;
            this.labelFiltreCatego.Location = new System.Drawing.Point(6, 25);
            this.labelFiltreCatego.Name = "labelFiltreCatego";
            this.labelFiltreCatego.Size = new System.Drawing.Size(70, 13);
            this.labelFiltreCatego.TabIndex = 1;
            this.labelFiltreCatego.Text = "Par catégorie";
            // 
            // labelFiltreID
            // 
            this.labelFiltreID.AutoSize = true;
            this.labelFiltreID.Location = new System.Drawing.Point(6, 78);
            this.labelFiltreID.Name = "labelFiltreID";
            this.labelFiltreID.Size = new System.Drawing.Size(37, 13);
            this.labelFiltreID.TabIndex = 2;
            this.labelFiltreID.Text = "Par ID";
            // 
            // labelFiltreQuestion
            // 
            this.labelFiltreQuestion.AutoSize = true;
            this.labelFiltreQuestion.Location = new System.Drawing.Point(6, 130);
            this.labelFiltreQuestion.Name = "labelFiltreQuestion";
            this.labelFiltreQuestion.Size = new System.Drawing.Size(60, 13);
            this.labelFiltreQuestion.TabIndex = 3;
            this.labelFiltreQuestion.Text = "Par mot-clé";
            // 
            // textBoxFiltreCatego
            // 
            this.textBoxFiltreCatego.Enabled = false;
            this.textBoxFiltreCatego.Location = new System.Drawing.Point(9, 41);
            this.textBoxFiltreCatego.Name = "textBoxFiltreCatego";
            this.textBoxFiltreCatego.Size = new System.Drawing.Size(115, 20);
            this.textBoxFiltreCatego.TabIndex = 4;
            this.textBoxFiltreCatego.TextChanged += new System.EventHandler(this.textBoxFiltreCatego_TextChanged);
            // 
            // textBoxFiltreID
            // 
            this.textBoxFiltreID.Enabled = false;
            this.textBoxFiltreID.Location = new System.Drawing.Point(9, 94);
            this.textBoxFiltreID.Name = "textBoxFiltreID";
            this.textBoxFiltreID.Size = new System.Drawing.Size(115, 20);
            this.textBoxFiltreID.TabIndex = 5;
            this.textBoxFiltreID.TextChanged += new System.EventHandler(this.textBoxFiltreID_TextChanged);
            // 
            // textBoxFiltreQuestion
            // 
            this.textBoxFiltreQuestion.Enabled = false;
            this.textBoxFiltreQuestion.Location = new System.Drawing.Point(9, 146);
            this.textBoxFiltreQuestion.Name = "textBoxFiltreQuestion";
            this.textBoxFiltreQuestion.Size = new System.Drawing.Size(115, 20);
            this.textBoxFiltreQuestion.TabIndex = 6;
            this.textBoxFiltreQuestion.TextChanged += new System.EventHandler(this.textBoxFiltreQuestion_TextChanged);
            // 
            // btnAjoutImage
            // 
            this.btnAjoutImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAjoutImage.Enabled = false;
            this.btnAjoutImage.Location = new System.Drawing.Point(6, 19);
            this.btnAjoutImage.Name = "btnAjoutImage";
            this.btnAjoutImage.Size = new System.Drawing.Size(60, 40);
            this.btnAjoutImage.TabIndex = 11;
            this.btnAjoutImage.Text = "Ajout image";
            this.btnAjoutImage.UseVisualStyleBackColor = false;
            this.btnAjoutImage.Click += new System.EventHandler(this.btnAjoutImage_Click);
            // 
            // btnSupprImage
            // 
            this.btnSupprImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSupprImage.Enabled = false;
            this.btnSupprImage.Location = new System.Drawing.Point(6, 65);
            this.btnSupprImage.Name = "btnSupprImage";
            this.btnSupprImage.Size = new System.Drawing.Size(60, 40);
            this.btnSupprImage.TabIndex = 14;
            this.btnSupprImage.Text = "Supp image";
            this.btnSupprImage.UseVisualStyleBackColor = false;
            this.btnSupprImage.Click += new System.EventHandler(this.btnSupprImage_Click);
            // 
            // groupBoxFiltre
            // 
            this.groupBoxFiltre.Controls.Add(this.labelFiltreCatego);
            this.groupBoxFiltre.Controls.Add(this.textBoxFiltreCatego);
            this.groupBoxFiltre.Controls.Add(this.labelFiltreID);
            this.groupBoxFiltre.Controls.Add(this.textBoxFiltreID);
            this.groupBoxFiltre.Controls.Add(this.labelFiltreQuestion);
            this.groupBoxFiltre.Controls.Add(this.textBoxFiltreQuestion);
            this.groupBoxFiltre.Location = new System.Drawing.Point(8, 263);
            this.groupBoxFiltre.Name = "groupBoxFiltre";
            this.groupBoxFiltre.Size = new System.Drawing.Size(140, 190);
            this.groupBoxFiltre.TabIndex = 15;
            this.groupBoxFiltre.TabStop = false;
            this.groupBoxFiltre.Text = "Filtres";
            // 
            // groupBoxImage
            // 
            this.groupBoxImage.Controls.Add(this.btnSupprimerCorrection);
            this.groupBoxImage.Controls.Add(this.btnAjoutCorrection);
            this.groupBoxImage.Controls.Add(this.btnAjoutImage);
            this.groupBoxImage.Controls.Add(this.btnCopie);
            this.groupBoxImage.Controls.Add(this.btnSupprImage);
            this.groupBoxImage.Location = new System.Drawing.Point(8, 671);
            this.groupBoxImage.Name = "groupBoxImage";
            this.groupBoxImage.Size = new System.Drawing.Size(140, 170);
            this.groupBoxImage.TabIndex = 16;
            this.groupBoxImage.TabStop = false;
            // 
            // btnSupprimerCorrection
            // 
            this.btnSupprimerCorrection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSupprimerCorrection.Enabled = false;
            this.btnSupprimerCorrection.Location = new System.Drawing.Point(74, 65);
            this.btnSupprimerCorrection.Name = "btnSupprimerCorrection";
            this.btnSupprimerCorrection.Size = new System.Drawing.Size(60, 40);
            this.btnSupprimerCorrection.TabIndex = 16;
            this.btnSupprimerCorrection.Text = "Supp correct";
            this.btnSupprimerCorrection.UseVisualStyleBackColor = false;
            this.btnSupprimerCorrection.Click += new System.EventHandler(this.btnSupprimerCorrection_Click);
            // 
            // btnAjoutCorrection
            // 
            this.btnAjoutCorrection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAjoutCorrection.Enabled = false;
            this.btnAjoutCorrection.Location = new System.Drawing.Point(74, 19);
            this.btnAjoutCorrection.Name = "btnAjoutCorrection";
            this.btnAjoutCorrection.Size = new System.Drawing.Size(60, 40);
            this.btnAjoutCorrection.TabIndex = 15;
            this.btnAjoutCorrection.Text = "Ajout correct";
            this.btnAjoutCorrection.UseVisualStyleBackColor = false;
            this.btnAjoutCorrection.Click += new System.EventHandler(this.btnAjoutCorrection_Click);
            // 
            // btnCopie
            // 
            this.btnCopie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCopie.Location = new System.Drawing.Point(4, 122);
            this.btnCopie.Name = "btnCopie";
            this.btnCopie.Size = new System.Drawing.Size(128, 30);
            this.btnCopie.TabIndex = 20;
            this.btnCopie.Text = "Copier image";
            this.btnCopie.UseVisualStyleBackColor = false;
            this.btnCopie.Click += new System.EventHandler(this.btnCopie_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1884, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvegarderToolStripMenuItem,
            this.allerEnHautToolStripMenuItem,
            this.allerEnBasToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.sauvegarderToolStripMenuItem.Text = "Enregistrer";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem_Click);
            // 
            // allerEnHautToolStripMenuItem
            // 
            this.allerEnHautToolStripMenuItem.Name = "allerEnHautToolStripMenuItem";
            this.allerEnHautToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.allerEnHautToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.allerEnHautToolStripMenuItem.Text = "Aller en haut";
            this.allerEnHautToolStripMenuItem.Click += new System.EventHandler(this.allerEnHautToolStripMenuItem_Click);
            // 
            // allerEnBasToolStripMenuItem
            // 
            this.allerEnBasToolStripMenuItem.Name = "allerEnBasToolStripMenuItem";
            this.allerEnBasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.allerEnBasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.allerEnBasToolStripMenuItem.Text = "Aller en bas";
            this.allerEnBasToolStripMenuItem.Click += new System.EventHandler(this.allerEnBasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // editionToolStripMenuItem
            // 
            this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterImageToolStripMenuItem,
            this.ajouterCorrectionToolStripMenuItem,
            this.afficherMasquerCorrectionsToolStripMenuItem});
            this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
            this.editionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editionToolStripMenuItem.Text = "Edition";
            // 
            // ajouterImageToolStripMenuItem
            // 
            this.ajouterImageToolStripMenuItem.Enabled = false;
            this.ajouterImageToolStripMenuItem.Name = "ajouterImageToolStripMenuItem";
            this.ajouterImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.ajouterImageToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.ajouterImageToolStripMenuItem.Text = "Ajouter image";
            this.ajouterImageToolStripMenuItem.Click += new System.EventHandler(this.ajouterImageToolStripMenuItem_Click);
            // 
            // ajouterCorrectionToolStripMenuItem
            // 
            this.ajouterCorrectionToolStripMenuItem.Enabled = false;
            this.ajouterCorrectionToolStripMenuItem.Name = "ajouterCorrectionToolStripMenuItem";
            this.ajouterCorrectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.ajouterCorrectionToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.ajouterCorrectionToolStripMenuItem.Text = "Ajouter correction";
            this.ajouterCorrectionToolStripMenuItem.Click += new System.EventHandler(this.ajouterCorrectionToolStripMenuItem_Click);
            // 
            // afficherMasquerCorrectionsToolStripMenuItem
            // 
            this.afficherMasquerCorrectionsToolStripMenuItem.Name = "afficherMasquerCorrectionsToolStripMenuItem";
            this.afficherMasquerCorrectionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.afficherMasquerCorrectionsToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.afficherMasquerCorrectionsToolStripMenuItem.Text = "Afficher / Masquer corrections";
            this.afficherMasquerCorrectionsToolStripMenuItem.Click += new System.EventHandler(this.afficherMasquerCorrectionsToolStripMenuItem_Click);
            // 
            // checkBoxCorrection
            // 
            this.checkBoxCorrection.Checked = true;
            this.checkBoxCorrection.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCorrection.Enabled = false;
            this.checkBoxCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCorrection.Location = new System.Drawing.Point(17, 626);
            this.checkBoxCorrection.Name = "checkBoxCorrection";
            this.checkBoxCorrection.Size = new System.Drawing.Size(115, 39);
            this.checkBoxCorrection.TabIndex = 22;
            this.checkBoxCorrection.Text = "Afficher / Masquer Corrections";
            this.checkBoxCorrection.UseVisualStyleBackColor = true;
            this.checkBoxCorrection.CheckedChanged += new System.EventHandler(this.checkBoxCorrection_CheckedChanged);
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.Transparent;
            this.btnCapture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapture.Location = new System.Drawing.Point(14, 870);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(128, 30);
            this.btnCapture.TabIndex = 26;
            this.btnCapture.Text = "Capture ecran";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // labelEnCours
            // 
            this.labelEnCours.AutoSize = true;
            this.labelEnCours.BackColor = System.Drawing.Color.White;
            this.labelEnCours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEnCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnCours.Location = new System.Drawing.Point(195, 9);
            this.labelEnCours.Name = "labelEnCours";
            this.labelEnCours.Size = new System.Drawing.Size(13, 15);
            this.labelEnCours.TabIndex = 27;
            this.labelEnCours.Text = " ";
            // 
            // btnZoomMoins
            // 
            this.btnZoomMoins.Image = global::TageMage_V2.Properties.Resources.zoom_moins;
            this.btnZoomMoins.Location = new System.Drawing.Point(97, 468);
            this.btnZoomMoins.Name = "btnZoomMoins";
            this.btnZoomMoins.Size = new System.Drawing.Size(45, 45);
            this.btnZoomMoins.TabIndex = 29;
            this.btnZoomMoins.UseVisualStyleBackColor = true;
            this.btnZoomMoins.Click += new System.EventHandler(this.btnZoomMoins_Click);
            // 
            // btnZoomPlus
            // 
            this.btnZoomPlus.Image = global::TageMage_V2.Properties.Resources.zoom_plus;
            this.btnZoomPlus.Location = new System.Drawing.Point(14, 468);
            this.btnZoomPlus.Name = "btnZoomPlus";
            this.btnZoomPlus.Size = new System.Drawing.Size(45, 45);
            this.btnZoomPlus.TabIndex = 28;
            this.btnZoomPlus.UseVisualStyleBackColor = true;
            this.btnZoomPlus.Click += new System.EventHandler(this.btnZoomPlus_Click);
            // 
            // btnExpression
            // 
            this.btnExpression.BackColor = System.Drawing.Color.White;
            this.btnExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpression.Image = global::TageMage_V2.Properties.Resources.expression;
            this.btnExpression.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpression.Location = new System.Drawing.Point(8, 197);
            this.btnExpression.Name = "btnExpression";
            this.btnExpression.Size = new System.Drawing.Size(134, 50);
            this.btnExpression.TabIndex = 25;
            this.btnExpression.Text = "Expression";
            this.btnExpression.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExpression.UseVisualStyleBackColor = false;
            this.btnExpression.Click += new System.EventHandler(this.btnExpression_Click);
            // 
            // btnRaisonnement
            // 
            this.btnRaisonnement.BackColor = System.Drawing.Color.White;
            this.btnRaisonnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaisonnement.Image = global::TageMage_V2.Properties.Resources.raisonnement;
            this.btnRaisonnement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaisonnement.Location = new System.Drawing.Point(8, 141);
            this.btnRaisonnement.Name = "btnRaisonnement";
            this.btnRaisonnement.Size = new System.Drawing.Size(134, 50);
            this.btnRaisonnement.TabIndex = 24;
            this.btnRaisonnement.Text = "Raisonnement";
            this.btnRaisonnement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRaisonnement.UseVisualStyleBackColor = false;
            this.btnRaisonnement.Click += new System.EventHandler(this.btnRaisonnement_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Enabled = false;
            this.pictureBoxImage.Location = new System.Drawing.Point(440, 11);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(134, 13);
            this.pictureBoxImage.TabIndex = 21;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Visible = false;
            // 
            // btnCondMini
            // 
            this.btnCondMini.BackColor = System.Drawing.Color.White;
            this.btnCondMini.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCondMini.Image = global::TageMage_V2.Properties.Resources.condmini;
            this.btnCondMini.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCondMini.Location = new System.Drawing.Point(8, 85);
            this.btnCondMini.Name = "btnCondMini";
            this.btnCondMini.Size = new System.Drawing.Size(134, 50);
            this.btnCondMini.TabIndex = 18;
            this.btnCondMini.Text = "Cond. Mini.";
            this.btnCondMini.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCondMini.UseVisualStyleBackColor = false;
            this.btnCondMini.Click += new System.EventHandler(this.btnCondMini_Click);
            // 
            // btnCalcul
            // 
            this.btnCalcul.BackColor = System.Drawing.Color.White;
            this.btnCalcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcul.Image = global::TageMage_V2.Properties.Resources.calcul;
            this.btnCalcul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcul.Location = new System.Drawing.Point(8, 29);
            this.btnCalcul.Name = "btnCalcul";
            this.btnCalcul.Size = new System.Drawing.Size(134, 50);
            this.btnCalcul.TabIndex = 17;
            this.btnCalcul.Text = "Calcul";
            this.btnCalcul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcul.UseVisualStyleBackColor = false;
            this.btnCalcul.Click += new System.EventHandler(this.btnCalcul_Click);
            // 
            // btnHaut
            // 
            this.btnHaut.Enabled = false;
            this.btnHaut.Image = global::TageMage_V2.Properties.Resources.haut;
            this.btnHaut.Location = new System.Drawing.Point(14, 530);
            this.btnHaut.Name = "btnHaut";
            this.btnHaut.Size = new System.Drawing.Size(45, 60);
            this.btnHaut.TabIndex = 9;
            this.btnHaut.UseVisualStyleBackColor = true;
            this.btnHaut.Click += new System.EventHandler(this.btnHaut_Click);
            // 
            // btnBas
            // 
            this.btnBas.Enabled = false;
            this.btnBas.Image = global::TageMage_V2.Properties.Resources.bas;
            this.btnBas.Location = new System.Drawing.Point(97, 530);
            this.btnBas.Name = "btnBas";
            this.btnBas.Size = new System.Drawing.Size(45, 60);
            this.btnBas.TabIndex = 8;
            this.btnBas.UseVisualStyleBackColor = true;
            this.btnBas.Click += new System.EventHandler(this.btnBas_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Image = global::TageMage_V2.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(41, 915);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 58);
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1884, 1006);
            this.Controls.Add(this.btnZoomMoins);
            this.Controls.Add(this.btnZoomPlus);
            this.Controls.Add(this.labelEnCours);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.btnExpression);
            this.Controls.Add(this.btnRaisonnement);
            this.Controls.Add(this.checkBoxCorrection);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.btnCondMini);
            this.Controls.Add(this.btnCalcul);
            this.Controls.Add(this.groupBoxImage);
            this.Controls.Add(this.groupBoxFiltre);
            this.Controls.Add(this.btnHaut);
            this.Controls.Add(this.btnBas);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridViewExo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tage Mage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExo)).EndInit();
            this.groupBoxFiltre.ResumeLayout(false);
            this.groupBoxFiltre.PerformLayout();
            this.groupBoxImage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExo;
        private System.Windows.Forms.Label labelFiltreCatego;
        private System.Windows.Forms.Label labelFiltreID;
        private System.Windows.Forms.Label labelFiltreQuestion;
        private System.Windows.Forms.TextBox textBoxFiltreCatego;
        private System.Windows.Forms.TextBox textBoxFiltreID;
        private System.Windows.Forms.TextBox textBoxFiltreQuestion;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBas;
        private System.Windows.Forms.Button btnHaut;
        private System.Windows.Forms.Button btnAjoutImage;
        private System.Windows.Forms.Button btnSupprImage;
        private System.Windows.Forms.GroupBox groupBoxFiltre;
        private System.Windows.Forms.GroupBox groupBoxImage;
        private System.Windows.Forms.Button btnAjoutCorrection;
        private System.Windows.Forms.Button btnSupprimerCorrection;
        private System.Windows.Forms.Button btnCalcul;
        private System.Windows.Forms.Button btnCondMini;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterCorrectionToolStripMenuItem;
        private System.Windows.Forms.Button btnCopie;
        private System.Windows.Forms.CheckBox checkBoxCorrection;
        private System.Windows.Forms.ToolStripMenuItem afficherMasquerCorrectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allerEnHautToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allerEnBasToolStripMenuItem;
        private System.Windows.Forms.Button btnRaisonnement;
        private System.Windows.Forms.Button btnExpression;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelEnCours;
        private System.Windows.Forms.Button btnZoomPlus;
        private System.Windows.Forms.Button btnZoomMoins;
    }
}

