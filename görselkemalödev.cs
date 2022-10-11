using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_notu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int v, f;
            double sonuc;
            v = Convert.ToInt32(textBox1.Text);
            f = Convert.ToInt32(textBox2.Text);
            sonuc = (v * 0.4) + (f * 0.6);
            label4.Text = Convert.ToString(sonuc);

            if (sonuc > 0 && sonuc <= 49)
                label3.Text = "FF";
            this.BackColor = Color.Red;
            if (sonuc >= 50 && sonuc < 59)
                label3.Text = "CC";
            this.BackColor = Color.Green;
            if (sonuc > 60 && sonuc < 69)
                label3.Text = "CB";
            this.BackColor = Color.Green;
            if (sonuc > 70 && sonuc < 79)
                label3.Text = "BB";
            this.BackColor = Color.Green;
            if (sonuc > 80 && sonuc < 89)
                label3.Text = "BA";
            this.BackColor = Color.Green;
            if (sonuc > 90 && sonuc <= 100)
                label3.Text = "AA";
            this.BackColor = Color.Green;
            if (sonuc > 100)
                label3.Text = "Yanlış not veya notlar girdiniz.";

         
            
                
            
        }
    }
    }

