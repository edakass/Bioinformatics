using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eda_Kaş_170508044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            string[] seq1oku = File.ReadAllLines("C:/Users/User/source/repos/G/seq1.txt");
            string[] seq2oku = File.ReadAllLines("C:/Users/User/source/repos/G/seq2.txt");
            string Seq1 = seq1oku[1];
            string Seq2 = seq2oku[1];



            int matchPuani = Convert.ToInt32(this.textBox1.Text);
            int missmatchCezasi = Convert.ToInt32(this.textBox2.Text);
            int gapCezasi = Convert.ToInt32(this.textBox3.Text);


            int seq1Uzunluk = Seq1.Length;
            int seq2Uzunluk = Seq2.Length;


            int[,] skorMatris = new int[seq1Uzunluk, seq2Uzunluk];
            char[,] geriAdim = new char[seq1Uzunluk, seq2Uzunluk];

            skorMatris[0, 0] = 0;


            for (int i = 1; i < seq1Uzunluk; i++)
            {
                skorMatris[i, 0] = skorMatris[i - 1, 0] + gapCezasi;
                geriAdim[i, 0] = 'R'; //sağ kısım için
            }
            for (int i = 1; i < seq2Uzunluk; i++)
            {
                skorMatris[0, i] = skorMatris[0, i - 1] + gapCezasi;
                geriAdim[0, i] = 'U'; //yukarı kısımlar için
            }


        }
    }
}
