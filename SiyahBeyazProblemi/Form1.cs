using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiyahBeyazProblemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int basamak = int.Parse(textBox1.Text);
            if (basamak <= 0)
            {
                MessageBox.Show("0'dan büyük bir değer giriniz...");
            }
            else
            {
                int[] sayi1 = new int[basamak];
                int[] sayi2 = new int[basamak];
                sayi1[0] = 1;
                sayi2[0] = 1;
                int sayi1_Onluk = 0, sayi2_Onluk = 0;
                for (int i = 1; i < basamak; i++)
                {
                    sayi1[i] = 1;
                    sayi2[i] = 0;
                }
                int k = basamak - 1;
                for (int i = 0; i < basamak; i++)
                {
                    if (sayi1[i] == 0) continue;
                    sayi1_Onluk += (int)Math.Pow(2, i);

                    if (sayi2[i] == 0) continue;
                    sayi2_Onluk += (int)Math.Pow(2, k);
                    k--;
                }
                int kalan, temp, s, sayac = 0;
                bool durum = true;
                sayi1 = new int[basamak];

                for (int i = sayi2_Onluk; i <= sayi1_Onluk; i++)
                {
                    temp = i;
                    s = basamak - 1;
                    while (temp != 0)
                    {
                        kalan = temp % 2;
                        temp /= 2;
                        sayi1[s] = kalan;
                        s--;
                        if (s < basamak - 2)
                        {
                            if (sayi1[s + 1] == 0 && sayi1[s + 2] == 0)
                            {
                                durum = false;
                                break;
                            }
                            else durum = true;
                        }
                    }
                    if (durum == true) sayac++;
                    sayi1 = new int[basamak];
                }
                label1.Text = sayac.ToString();
            }
        }
    }
}
