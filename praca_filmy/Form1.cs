using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace praca_filmy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OdczytZPliku();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodawanieDanych(tytulTxt.Text,RezyserTxt.Text, dateTimePicker1.Text,AktorTxt.Text);
            listView1.Refresh();
        }

        public void DodawanieDanych(string tytul, string rezyser, string niggerlol, string aktor)
        {
            ListViewItem Dante = new ListViewItem(new String[] { tytul, rezyser, niggerlol, aktor });
            listView1.Items.Add(Dante);
        }

        public void ZmienianieDanych(string tytul, string rezyser, string niggerlol, string aktor)
        {
            ListViewItem Donatello = new ListViewItem(new String[] { tytul, rezyser, niggerlol, aktor });
            listView1.Items.Add(Donatello);
        }

        private void usuńWybraneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems) 
            {
                listView1.Items.Remove(item);
            }
            listView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] nigaboi = new string[listView1.Items.Count];
            int nigeritto = 0;
            foreach (ListViewItem kys in listView1.Items)
            {
                nigaboi[nigeritto] = "";
                for (int i = 0; i < kys.SubItems.Count; i++)
                {
                    nigaboi[nigeritto] += kys.SubItems[i].Text + ";";
                }

                nigeritto++;
            }
            File.WriteAllLines("filmy.txt", nigaboi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OdczytZPliku()
        {
            if (!File.Exists("filmy.txt"))
                return;
            string[] linie = File.ReadAllLines("filmy.txt");
            foreach (string linia in linie)
            {
                string[] temp = linia.Split(';');
                DodawanieDanych(temp[0], temp[1], temp[2], temp[3]);
            }
        }

        private void zastąpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
            DodawanieDanych(tytulTxt.Text, RezyserTxt.Text, dateTimePicker1.Text, AktorTxt.Text);
            listView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
            DodawanieDanych(tytulTxt.Text, RezyserTxt.Text, dateTimePicker1.Text, AktorTxt.Text);
            listView1.Refresh();
        }
    }
}
