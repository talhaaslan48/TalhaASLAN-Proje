using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.OleDb;




namespace TalhaASLAN_Proje
{
    public partial class Sepet : Form
    {
        public Sepet()
        {
            InitializeComponent();
        }
        public static int toplam;
        private void button2_Click(object sender, EventArgs e)
        { 
            
           if (textBox5.TextLength != 16)
            {
                MessageBox.Show("Lütfen geçerli bir kredi kartı numarası giriniz");
            }
            if (textBox1.TextLength != 5 )
            {
                MessageBox.Show("Lütfen geçerli son kullanma tarihi giriniz");
            }
            if (textBox6.TextLength != 3)
            {
                MessageBox.Show("Lütfen geçerli bir cvv numarası giriniz");
            }

            if (textBox5.TextLength == 16 && textBox1.TextLength == 5 && textBox6.TextLength == 3)
            {
               
                MessageBox.Show("Ödemeniz başarıyla tamamlanmıştır.Tekrar Bekleriz İyi Günler");
               
                
            }
        }

      

        private void Sepet_Load(object sender, EventArgs e)
        {
           listBox1.Items.Clear();
            for(int i = 0; i < Form1.MyList.Count; i++)
            {
                listBox1.Items.Add(Form1.MyList[i]);
            }
          

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add("Toplam Tutarınız :" + Form1.toplam + "  " + " TL'dir");
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var test = new BankaVeriTabanıDataSetTableAdapters.BilgilerrTableAdapter().GetData().ToList();
             var kartNo = textBox5.Text.ToString();
             var cvv = textBox6.Text.ToString();
             var valid = textBox1.Text.ToString();
            new BankaVeriTabanıDataSetTableAdapters.BilgilerrTableAdapter().Insert(kartNo,valid,cvv);
        }
    }
}
   


