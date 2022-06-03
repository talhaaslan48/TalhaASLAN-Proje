using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalhaASLAN_Proje
{
    public partial class ÇocukEtek : Form
    {
        public ÇocukEtek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                string uzantı = radioButton1.Text + " " + label1.Text;
                Form1.toplam = Form1.toplam + Convert.ToInt32(label1.Text);
                Form1.MyList.Add(uzantı);
                MessageBox.Show("Ürün sepete eklendi");
                MessageBox.Show("Alışverişe devam etmek istiyorsanız Tamam'a basın ");
            }
            else if (radioButton2.Checked == true)
            {
                string uzantı = radioButton2.Text + " " + label2.Text;
                Form1.toplam = Form1.toplam + Convert.ToInt32(label2.Text);
                Form1.MyList.Add(uzantı);
                MessageBox.Show("Ürün sepete eklendi");
                MessageBox.Show("Alışverişe devam etmek istiyorsanız Tamam'a basın ");
            }
            else if (radioButton3.Checked == true)
            {
                string uzantı = radioButton3.Text + " " + label3.Text;
                Form1.toplam = Form1.toplam + Convert.ToInt32(label3.Text);
                Form1.MyList.Add(uzantı);
                MessageBox.Show("Ürün sepete eklendi");
                MessageBox.Show("Alışverişe devam etmek istiyorsanız Tamam'a basın ");
            }
        }
    }
}
