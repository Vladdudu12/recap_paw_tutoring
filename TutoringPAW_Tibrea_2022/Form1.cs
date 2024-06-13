using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutoringPAW_Tibrea_2022
{
    public partial class Form1 : Form
    {
        Medic m;

        public Form1()
        {
            InitializeComponent();
            m = new Medic("Medic1", "Specializare1");
            textBox1.Text = m.Nume + " - " + m.Specializare;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            if (form2.DialogResult == DialogResult.OK)
            {
                try
                {
                    string nume = form2.tbNume.Text;
                    int varsta = Convert.ToInt32(form2.tbVarsta.Text);
                    float tarif = float.Parse(form2.tbTarif.Text);
                    Pacient p = new Pacient(nume, varsta, tarif);
                    m += p;
                    ListViewItem itm = new ListViewItem(nume);
                    itm.SubItems.Add(varsta.ToString());
                    itm.SubItems.Add(tarif.ToString());
                    lvPacienti.Items.Add(itm);
                    lvPacienti.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("S-a generat o exceptie! " + ex.Message);
                }
            }
        }

        private void btnEditare_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            int poz;
            if (lvPacienti.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvPacienti.SelectedItems[0];
                poz = itm.Index;
                form2.tbNume.Text = itm.SubItems[0].Text;
                form2.tbVarsta.Text = itm.SubItems[1].Text;
                form2.tbTarif.Text = itm.SubItems[2].Text;

                form2.ShowDialog();

                if (form2.DialogResult == DialogResult.OK)
                {
                    itm.SubItems[0].Text = form2.tbNume.Text;
                    itm.SubItems[1].Text = form2.tbVarsta.Text;
                    itm.SubItems[2].Text = form2.tbTarif.Text;
                    Pacient p = m.ListaPacienti[poz];
                    p.Nume = form2.tbNume.Text;
                    p.Varsta = Convert.ToInt32(form2.tbVarsta.Text);
                    p.Tarif_consultatie = float.Parse(form2.tbTarif.Text);
                    m[poz] = p;
                }
            }
            else
            {
                MessageBox.Show("Nu s-a selectat un element!");
            }
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            int poz;
            if (lvPacienti.SelectedItems.Count > 0)
            {
                ListViewItem itm = lvPacienti.SelectedItems[0];
                poz = itm.Index;
                itm.Remove();
                m.ListaPacienti.RemoveAt(poz);
            }
            else
            {
                MessageBox.Show("Nu s-a selectat un element!");
            }
        }

        private void calculeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbVenit.Text = "Venitul medicului este: " + m.calculeazaVenit();
        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(m);
            form3.Show();
        }
    }
}
