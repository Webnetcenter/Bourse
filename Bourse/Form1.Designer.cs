namespace Bourse
{
    partial class WebNetCenter
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
            this.webGraphique = new System.Windows.Forms.WebBrowser();
            this.cbWebnetcenter = new System.Windows.Forms.ComboBox();
            this.btnGauche = new System.Windows.Forms.Button();
            this.btnDroite = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.lblFinviz = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.cbTitre = new System.Windows.Forms.ComboBox();
            this.lblTitreSymbole = new System.Windows.Forms.Label();
            this.lblPeriodeVisible = new System.Windows.Forms.Label();
            this.cbPeriode = new System.Windows.Forms.ComboBox();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnSaveCSV = new System.Windows.Forms.Button();
            this.cmbChoix = new System.Windows.Forms.ComboBox();
            this.lblSecteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webGraphique
            // 
            this.webGraphique.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webGraphique.Location = new System.Drawing.Point(-2, 62);
            this.webGraphique.MinimumSize = new System.Drawing.Size(20, 20);
            this.webGraphique.Name = "webGraphique";
            this.webGraphique.Size = new System.Drawing.Size(3000, 610);
            this.webGraphique.TabIndex = 0;
            this.webGraphique.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // cbWebnetcenter
            // 
            this.cbWebnetcenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cbWebnetcenter.FormattingEnabled = true;
            this.cbWebnetcenter.Location = new System.Drawing.Point(541, 15);
            this.cbWebnetcenter.Name = "cbWebnetcenter";
            this.cbWebnetcenter.Size = new System.Drawing.Size(146, 33);
            this.cbWebnetcenter.TabIndex = 1;
            this.cbWebnetcenter.SelectedIndexChanged += new System.EventHandler(this.cbWebnetcenter_SelectedIndexChanged);
            this.cbWebnetcenter.Enter += new System.EventHandler(this.btnGauche_Click);
            this.cbWebnetcenter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbWebnetcenter_MouseClick);
            // 
            // btnGauche
            // 
            this.btnGauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGauche.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGauche.Location = new System.Drawing.Point(707, 7);
            this.btnGauche.Name = "btnGauche";
            this.btnGauche.Size = new System.Drawing.Size(65, 46);
            this.btnGauche.TabIndex = 2;
            this.btnGauche.Text = "<<";
            this.btnGauche.UseVisualStyleBackColor = true;
            this.btnGauche.Click += new System.EventHandler(this.btnGauche_Click);
            // 
            // btnDroite
            // 
            this.btnDroite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDroite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDroite.Location = new System.Drawing.Point(778, 7);
            this.btnDroite.Name = "btnDroite";
            this.btnDroite.Size = new System.Drawing.Size(65, 46);
            this.btnDroite.TabIndex = 3;
            this.btnDroite.Text = ">>";
            this.btnDroite.UseVisualStyleBackColor = true;
            this.btnDroite.Click += new System.EventHandler(this.btnDroite_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPreview.Location = new System.Drawing.Point(849, 7);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(107, 44);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // lblFinviz
            // 
            this.lblFinviz.AutoSize = true;
            this.lblFinviz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFinviz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFinviz.Location = new System.Drawing.Point(439, 20);
            this.lblFinviz.Name = "lblFinviz";
            this.lblFinviz.Size = new System.Drawing.Size(96, 25);
            this.lblFinviz.TabIndex = 8;
            this.lblFinviz.Text = "Symbole";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(86, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 57);
            this.label2.TabIndex = 9;
            this.label2.Text = "WebNetCenter";
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitre.Location = new System.Drawing.Point(422, 18);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(0, 25);
            this.lblTitre.TabIndex = 10;
            // 
            // cbTitre
            // 
            this.cbTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cbTitre.FormattingEnabled = true;
            this.cbTitre.Location = new System.Drawing.Point(1810, 70);
            this.cbTitre.Name = "cbTitre";
            this.cbTitre.Size = new System.Drawing.Size(98, 28);
            this.cbTitre.TabIndex = 11;
            this.cbTitre.Visible = false;
            // 
            // lblTitreSymbole
            // 
            this.lblTitreSymbole.AutoSize = true;
            this.lblTitreSymbole.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitreSymbole.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitreSymbole.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitreSymbole.Location = new System.Drawing.Point(991, 14);
            this.lblTitreSymbole.Name = "lblTitreSymbole";
            this.lblTitreSymbole.Size = new System.Drawing.Size(0, 29);
            this.lblTitreSymbole.TabIndex = 12;
            // 
            // lblPeriodeVisible
            // 
            this.lblPeriodeVisible.AutoSize = true;
            this.lblPeriodeVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPeriodeVisible.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPeriodeVisible.Location = new System.Drawing.Point(1796, 20);
            this.lblPeriodeVisible.Name = "lblPeriodeVisible";
            this.lblPeriodeVisible.Size = new System.Drawing.Size(99, 25);
            this.lblPeriodeVisible.TabIndex = 13;
            this.lblPeriodeVisible.Text = "Période :";
            this.lblPeriodeVisible.Click += new System.EventHandler(this.lblPeriodeVisible_Click);
            // 
            // cbPeriode
            // 
            this.cbPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cbPeriode.FormattingEnabled = true;
            this.cbPeriode.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.cbPeriode.Location = new System.Drawing.Point(1901, 15);
            this.cbPeriode.Name = "cbPeriode";
            this.cbPeriode.Size = new System.Drawing.Size(121, 33);
            this.cbPeriode.TabIndex = 14;
            this.cbPeriode.UseWaitCursor = true;
            this.cbPeriode.SelectedIndexChanged += new System.EventHandler(this.cbPeriode_SelectedIndexChanged);
            this.cbPeriode.Click += new System.EventHandler(this.btnGauche_Click);
            // 
            // btnDrop
            // 
            this.btnDrop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrop.Location = new System.Drawing.Point(1554, 15);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(84, 32);
            this.btnDrop.TabIndex = 15;
            this.btnDrop.Text = "Drop";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.Visible = false;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // btnSaveCSV
            // 
            this.btnSaveCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCSV.Location = new System.Drawing.Point(1644, 16);
            this.btnSaveCSV.Name = "btnSaveCSV";
            this.btnSaveCSV.Size = new System.Drawing.Size(146, 32);
            this.btnSaveCSV.TabIndex = 16;
            this.btnSaveCSV.Text = "Save CSV";
            this.btnSaveCSV.UseVisualStyleBackColor = true;
            this.btnSaveCSV.Visible = false;
            this.btnSaveCSV.Click += new System.EventHandler(this.btnSaveCSV_Click);
            // 
            // cmbChoix
            // 
            this.cmbChoix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChoix.FormattingEnabled = true;
            this.cmbChoix.Items.AddRange(new object[] {
            "COVID VACCIN",
            "ELECTRIC CAR",
            "CASINO ",
            "NASDAQ Communication Service",
            "NASDAQ Consumer Cyclical",
            "NASDAQ Technology",
            "NYSE Communication Services",
            "NYSE HealthCare",
            "NYSE Technology",
            "CANNABIS",
            "IPO CHINOIS"});
            this.cmbChoix.Location = new System.Drawing.Point(1413, 16);
            this.cmbChoix.Name = "cmbChoix";
            this.cmbChoix.Size = new System.Drawing.Size(378, 33);
            this.cmbChoix.TabIndex = 18;
            this.cmbChoix.SelectedIndexChanged += new System.EventHandler(this.cmbChoix_SelectedIndexChanged);
            // 
            // lblSecteur
            // 
            this.lblSecteur.AutoSize = true;
            this.lblSecteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecteur.Location = new System.Drawing.Point(1304, 21);
            this.lblSecteur.Name = "lblSecteur";
            this.lblSecteur.Size = new System.Drawing.Size(94, 25);
            this.lblSecteur.TabIndex = 19;
            this.lblSecteur.Text = "Secteur:";
            // 
            // WebNetCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 671);
            this.Controls.Add(this.lblSecteur);
            this.Controls.Add(this.cmbChoix);
            this.Controls.Add(this.btnSaveCSV);
            this.Controls.Add(this.btnDrop);
            this.Controls.Add(this.cbPeriode);
            this.Controls.Add(this.lblPeriodeVisible);
            this.Controls.Add(this.lblTitreSymbole);
            this.Controls.Add(this.cbTitre);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFinviz);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnDroite);
            this.Controls.Add(this.btnGauche);
            this.Controls.Add(this.cbWebnetcenter);
            this.Controls.Add(this.webGraphique);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WebNetCenter";
            this.Text = "WebNetCenter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WebNetCenter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webGraphique;
        private System.Windows.Forms.ComboBox cbWebnetcenter;
        private System.Windows.Forms.Button btnGauche;
        private System.Windows.Forms.Button btnDroite;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label lblFinviz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.ComboBox cbTitre;
        private System.Windows.Forms.Label lblTitreSymbole;
        private System.Windows.Forms.Label lblPeriodeVisible;
        private System.Windows.Forms.ComboBox cbPeriode;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnSaveCSV;
        private System.Windows.Forms.ComboBox cmbChoix;
        private System.Windows.Forms.Label lblSecteur;
    }
}

