using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._18._2021ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ListViewItem lvi1 = new ListViewItem();
            lvi1.Text = txtIsim.Text;
            lvi1.SubItems.Add(txtSoyisim.Text);
            string telefon = string.Format("{0} {1} {2}", comboBox1.Text, comboBox2.Text, mskdTelefon.Text);
            lvi1.SubItems.Add(telefon);
            lvi1.SubItems.Add(mskdTelefon.Text);
            lvi1.SubItems.Add(dtpDogumTarihi.Value.ToShortDateString());

            listView1.Items.Add(lvi1);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

        }
    }
}
