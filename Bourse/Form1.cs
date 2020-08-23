using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Bourse
{
    public partial class WebNetCenter : Form
    {
        string Periode ;
        string Sequence;
        int Position;
        public WebNetCenter()
        {
            InitializeComponent();

            //          var column1 = new List<string>();
            //           var column2 = new List<string>();
            //           var column3 = new List<string>();
            //  Bonjour salut
            
            cmbChoix.SelectedIndex = 0;
            cbWebnetcenter.Items.Clear();
            cbTitre.Items.Clear();
            using (var rd = new StreamReader("webnetcenter/symbole.csv"))
            {
                while (!rd.EndOfStream)
                {
                   var splits = rd.ReadLine().Split(';');
                if(splits[1] == cmbChoix.SelectedItem.ToString())
                {
                   cbWebnetcenter.Items.Add(splits[0]);
                   cbTitre.Items.Add(splits[2]);
                }
                }
                cbWebnetcenter.SelectedIndex = 0;
                cbTitre.SelectedIndex = 0;
                cbPeriode.SelectedIndex = 0;
                Periode = cbPeriode.SelectedItem.ToString();
            }
        }

        private void cbWebnetcenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string URL;

            if(Periode == "Daily")
                URL = "https://finviz.com/chart.ashx/?t=" + cbWebnetcenter.SelectedItem.ToString() + "&ta=1&ty=c&p=" + Sequence+"&s=1";
            else URL = "https://finviz.com/chart.ashx/?t=" + cbWebnetcenter.SelectedItem.ToString() + "&ty=c&p=" + Sequence + "&s=1";

            Position = cbWebnetcenter.SelectedIndex;
            cbTitre.SelectedIndex = Position;
            lblTitreSymbole.Text = cbTitre.SelectedItem.ToString();

            webGraphique.Navigate(URL);
        }

        private void WebNetCenter_Load(object sender, EventArgs e)
        {
             cbWebnetcenter.Focus();
        }

        private void cbPeriode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string URL;

            Periode = cbPeriode.SelectedItem.ToString();

            if (Periode == "Daily")
                Sequence = "D";
            else
            {
                if (Periode == "Weekly")
                    Sequence = "W";
                else Sequence = "M";
            }

            if (Periode == "Daily")
                URL = "https://finviz.com/chart.ashx/?t=" + cbWebnetcenter.SelectedItem.ToString() + "&ta=1&ty=c&p=" + Sequence + "&s=1";
            else URL = "https://finviz.com/chart.ashx/?t=" + cbWebnetcenter.SelectedItem.ToString() + "&ty=c&p=" + Sequence + "&s=1";

            Position = cbWebnetcenter.SelectedIndex;
            cbTitre.SelectedIndex = Position;
            lblTitreSymbole.Text = cbTitre.SelectedItem.ToString();

            webGraphique.Navigate(URL);
            cbWebnetcenter.Focus();
        }

        private void cbWebnetcenter_MouseClick(object sender, MouseEventArgs e)
        {
            string URL;

            if (Periode == "Daily")
                URL = "https://finviz.com/chart.ashx/?t=" + cbWebnetcenter.SelectedItem.ToString() + "&ta=1&ty=c&p=" + Sequence + "&s=1";
            else URL = "https://finviz.com/chart.ashx/?t=" + cbWebnetcenter.SelectedItem.ToString() + "&ty=c&p=" + Sequence + "&s=1";

            Position = cbWebnetcenter.SelectedIndex;
            cbTitre.SelectedIndex = Position;
            lblTitreSymbole.Text = cbTitre.SelectedItem.ToString();

            webGraphique.Navigate(URL);
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            {
                int Position = cbWebnetcenter.SelectedIndex;

                cbWebnetcenter.Items.RemoveAt(Position);
                cbTitre.Items.RemoveAt(Position);
                cbWebnetcenter.SelectedIndex = Position;
                cbWebnetcenter.Focus();
            }
        }
        private void btnSaveCSV_Click(object sender, EventArgs e)
        {
            int Nombre = 0;

            using (var wd = new StreamWriter("/webnetcenter/testsymbole.csv"))
            { 
                while (Nombre < cbWebnetcenter.Items.Count)
                {
                    cbWebnetcenter.SelectedIndex = Nombre;
                    cbTitre.SelectedIndex = Nombre;
                    var Symbole = cbWebnetcenter.SelectedItem;
                    var Marche = "OQ";
                    var Titre = cbTitre.SelectedItem;
                    var line = string.Format("{0};{1};{2}", Symbole, Marche, Titre);
                    wd.WriteLine(line);
                    lblTitreSymbole.Text = cbTitre.SelectedItem.ToString();
                    Nombre++;
                    wd.Flush();
                }
            }
        }

        private void btnCorrection_Click(object sender, EventArgs e)
        {
            var wd = new StreamWriter("/webnetcenter/Correctionsymbole.csv");

            var Newrd= new StreamReader("/webnetcenter/symbole.csv");

            using (var Oldrd = new StreamReader("/webnetcenter/symbole OLD 0.csv"))
            {
                var splits1 = Oldrd.ReadLine().Split(';');
                var splits2 = Newrd.ReadLine().Split(';');

                while (!Newrd.EndOfStream)
                {
                    //          var splits1 = rd.ReadLine().Split(';');
                    //          var splits2 = rd.ReadLine().Split(';');
                    if (splits2[0] == splits1[0])
                    {
                        var Symbole = splits2[0];
                        var Marche = "OQ";
                        var Titre = splits1[2];
                        var line = string.Format("{0};{1};{2}", Symbole, Marche, Titre);
                        wd.WriteLine(line);
                        splits1 = Oldrd.ReadLine().Split(';');
                        splits2 = Newrd.ReadLine().Split(';');
                    }
                    else
                    {
                        while (splits1[0] != splits2[0])
                        {
                            splits1 = Oldrd.ReadLine().Split(';');
                        }
                    }
                }
            }
        }
        private void lblPeriodeVisible_Click(object sender, EventArgs e)
        {

                 if (btnDrop.Visible == false)
                {
                    cmbChoix.Visible = false;
                    lblSecteur.Visible = false;
                    btnDrop.Visible = true;
                    btnSaveCSV.Visible = true;
//                    btnCorrection.Visible = true;

                }
                else
                {
                    cmbChoix.Visible = true;
                    lblSecteur.Visible = true;
                    btnDrop.Visible = false;
                    btnSaveCSV.Visible = false;
 //                   btnCorrection.Visible = false;
                }
                cbWebnetcenter.Focus();

        }
        private void btnGauche_Click(object sender, EventArgs e)
        {
            webGraphique.GoBack();
        }

        private void btnDroite_Click(object sender, EventArgs e)
        {
            webGraphique.GoForward();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            webGraphique.ShowPrintDialog();
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            webGraphique.ShowPrintPreviewDialog();
        }

        private void cmbChoix_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var rd = new StreamReader("webnetcenter/symbole.csv"))
            {
                cbWebnetcenter.Items.Clear();
                cbTitre.Items.Clear();
                while (!rd.EndOfStream)
                {
                    var splits = rd.ReadLine().Split(';');
                    if (splits[1] == cmbChoix.SelectedItem.ToString())
                    {
                        cbWebnetcenter.Items.Add(splits[0]);
                        cbTitre.Items.Add(splits[2]);
                    }
                }
            }
            cbWebnetcenter.SelectedIndex = 0;
            cbTitre.SelectedIndex = 0;
            cbPeriode.SelectedIndex = 0;
            Periode = cbPeriode.SelectedItem.ToString();
            cbWebnetcenter.Focus();
        }
    }
}
