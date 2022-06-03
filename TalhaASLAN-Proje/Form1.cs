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

namespace TalhaASLAN_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void jEANToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Form2 form2 = new Form2();
            form2.ShowDialog();
            form2.Close();
              
        }

        private void tİŞÖRTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                KadınTişört kadınTişört = new KadınTişört();
                kadınTişört.ShowDialog();
                
            }
        }

        private void eLBİSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KadınElbise kadınElbise = new KadınElbise();
            kadınElbise.ShowDialog();
           

        }

        private void pANTOLONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KadınPantolon kadınPantolon = new KadınPantolon();
            kadınPantolon.ShowDialog();
            

        }

        private void tİŞÖRTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ErkekTişört erkekTişört = new ErkekTişört();
            erkekTişört.ShowDialog();
            
        }

        private void şORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ErkekŞort erkekŞort = new ErkekŞort();
                erkekŞort.ShowDialog();
               
        }

        private void eŞOFMANToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ErkekEşofman erkekEşofman = new ErkekEşofman();
                erkekEşofman.ShowDialog();
              
        }

        private void gÖMLEKToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ErkekGömlek erkekGömlek = new ErkekGömlek();
                erkekGömlek.ShowDialog();
                
        }

        private void yELEKToolStripMenuItem_Click(object sender, EventArgs e)
        {
                ÇocukYelek çocukYelek = new ÇocukYelek();
                çocukYelek.ShowDialog();
                   
        }

        private void eTEKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÇocukEtek çocukEtek = new ÇocukEtek();
            çocukEtek.ShowDialog();
           
        }

        private void pİJAMATAKIMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÇocukPijamaTakımı çocukPijamaTakımı = new ÇocukPijamaTakımı();
            çocukPijamaTakımı.ShowDialog();
            
        }

        private void çORAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÇocukÇorap çocukÇorap = new ÇocukÇorap();
            çocukÇorap.ShowDialog();
           
        }

        private void tULUMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BebekTulum bebekTulum = new BebekTulum();   
            bebekTulum.ShowDialog();    
            
        }

        private void çITÇITLIBODYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BebekÇıtçıtlıBody bebekÇıtçıtlıBody = new BebekÇıtçıtlıBody();
            bebekÇıtçıtlıBody.ShowDialog();
            
        }

        private void aYAKKABIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BebekAyakkabı bebekAyakkabı = new BebekAyakkabı();
            bebekAyakkabı.ShowDialog();
            
        }

        private void pİJAMATAKIMIToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BebekPijamaTakımı bebekPijamaTakımı = new BebekPijamaTakımı();
            bebekPijamaTakımı.ShowDialog();
          
        }

        private void bABETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyakkabıBabet ayakkabıBabet = new AyakkabıBabet();
            ayakkabıBabet.ShowDialog();
           
        }

        private void tERLİKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyakkabıTerlik ayakkabıTerlik = new AyakkabıTerlik();
            ayakkabıTerlik.ShowDialog();
            
        }

        private void sPORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyakkabıSpor ayakkabıSpor = new AyakkabıSpor();
            ayakkabıSpor.ShowDialog();  
            
        }

        private void dERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyakkabıDeri ayakkabıDeri = new AyakkabıDeri();
            ayakkabıDeri.ShowDialog();
            
        }

        private void çANTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AksesuarÇanta aksesuarÇanta = new AksesuarÇanta();
            aksesuarÇanta.ShowDialog();
            
        }

        private void şAPKAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AksesuarŞapka aksesuarŞapka = new AksesuarŞapka();
            aksesuarŞapka.ShowDialog();
            
        }

        private void cÜZDANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AksesuarÇüzdan aksesuarÇüzdan = new AksesuarÇüzdan();
            aksesuarÇüzdan.ShowDialog();
            
        }

        private void kEMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AksesuarKemer aksesuarKemer = new AksesuarKemer();  
            aksesuarKemer.ShowDialog();
            
        }

        private void pİKEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvYaşamPike evYaşamPike = new EvYaşamPike();
            evYaşamPike.ShowDialog();
            
        }

        private void çARŞAFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvYaşamÇarşaf evYaşamÇarşaf = new EvYaşamÇarşaf();
            evYaşamÇarşaf.ShowDialog();
            
        }

        private void hAVLUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvYaşamHavlu evYaşamHavlu = new EvYaşamHavlu();
            evYaşamHavlu.ShowDialog();  
            
        }

        private void bORNOZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvYaşamBornoz evYaşamBornoz = new EvYaşamBornoz();
            evYaşamBornoz.ShowDialog();
           
        }

        private void sEPETİNİZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            sepet.ShowDialog();
            
        }

        public static List<string> MyList;
        public static int toplam;
        private void Form1_Load(object sender, EventArgs e)
        {
            MyList = new List<string>();    
            
        }
    }

}
