using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Matriste ve diğer hesaplamalarda kullanacağımız değişkenlerimizi tanımladık. 
        double x, y, x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, x24, x25, x26, x27, x28, x29, x30, x31, x32, x33;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Transpoze işlemini yapmak için lütfen tüm boyutları aynı seçiniz");

            if (panel1.Visible) // Eğer panel1 görünüyorsa
            {
                if (panel8.Visible)
                {
                    x2 = Convert.ToDouble(textBox2.Text);
                    x3 = Convert.ToDouble(textBox3.Text); 
                    x4 = Convert.ToDouble(textBox4.Text); 
                    x5 = Convert.ToDouble(textBox5.Text);           
                    textBox35.Text = Convert.ToString(x2); 
                    textBox37.Text = Convert.ToString(x3); 
                    textBox34.Text = Convert.ToString(x4); 
                    textBox36.Text = Convert.ToString(x5); 
                  

                }
            }
            if (panel2.Visible) // Eğer panel2 görünüyorsa
            {
                if (panel7.Visible)
                {
                    x2 = Convert.ToDouble(textBox6.Text); 
                    x3 = Convert.ToDouble(textBox7.Text); 
                    x4 = Convert.ToDouble(textBox8.Text); 
                    x5 = Convert.ToDouble(textBox9.Text); 
                    x6 = Convert.ToDouble(textBox10.Text); 
                    x7 = Convert.ToDouble(textBox11.Text);
                    x8 = Convert.ToDouble(textBox12.Text); 
                    x9 = Convert.ToDouble(textBox13.Text); 
                    x10 = Convert.ToDouble(textBox14.Text);                  
                    textBox46.Text = Convert.ToString(x2); 
                    textBox43.Text = Convert.ToString(x3); 
                    textBox40.Text = Convert.ToString(x4); 
                    textBox45.Text = Convert.ToString(x5); 
                    textBox42.Text = Convert.ToString(x6); 
                    textBox39.Text = Convert.ToString(x7); 
                    textBox44.Text = Convert.ToString(x8);
                    textBox41.Text = Convert.ToString(x9); 
                    textBox38.Text = Convert.ToString(x10);
                  
                   
                }
                
            }
            if (panel3.Visible) // Eğer panel3 görünüyorsa
            {
                if (panel6.Visible)
                {
                    x2 = Convert.ToDouble(textBox15.Text); 
                    x3 = Convert.ToDouble(textBox16.Text); 
                    x4 = Convert.ToDouble(textBox17.Text); 
                    x5 = Convert.ToDouble(textBox18.Text); 
                    x6 = Convert.ToDouble(textBox19.Text);
                    x7 = Convert.ToDouble(textBox20.Text); 
                    x8 = Convert.ToDouble(textBox21.Text); 
                    x9 = Convert.ToDouble(textBox22.Text); 
                    x10 = Convert.ToDouble(textBox23.Text);
                    x11 = Convert.ToDouble(textBox24.Text); 
                    x12 = Convert.ToDouble(textBox25.Text); 
                    x13 = Convert.ToDouble(textBox26.Text); 
                    x14 = Convert.ToDouble(textBox27.Text); 
                    x15 = Convert.ToDouble(textBox28.Text); 
                    x16 = Convert.ToDouble(textBox29.Text); 
                    x17 = Convert.ToDouble(textBox30.Text); 
                    textBox138.Text = Convert.ToString(x2); 
                    textBox137.Text = Convert.ToString(x6); 
                    textBox136.Text = Convert.ToString(x10); 
                    textBox135.Text = Convert.ToString(x14);
                    textBox133.Text = Convert.ToString(x3); 
                    textBox132.Text = Convert.ToString(x7);
                    textBox131.Text = Convert.ToString(x11);
                    textBox130.Text = Convert.ToString(x15); 
                    textBox128.Text = Convert.ToString(x4); 
                    textBox127.Text = Convert.ToString(x8);
                    textBox126.Text = Convert.ToString(x12); 
                    textBox125.Text = Convert.ToString(x16);
                    textBox123.Text = Convert.ToString(x5); 
                    textBox122.Text = Convert.ToString(x9); 
                    textBox121.Text = Convert.ToString(x13); 
                    textBox120.Text = Convert.ToString(x17); 
                  
                }
               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Determinant işlemini yapmak için lütfen boyut olarak 2x2 veya 3x3 seçiniz");

            if (panel1.Visible) // Eğer panel1 görünüyorsa
            {
                if (panel8.Visible)
                {
                    x2 = Convert.ToDouble(textBox2.Text);
                    x3 = Convert.ToDouble(textBox3.Text);
                    x4 = Convert.ToDouble(textBox4.Text);
                    x5 = Convert.ToDouble(textBox5.Text);
                    textBox47.Text = Convert.ToString((x2 * x5) - (x4 * x3));

                }
            }
            if (panel2.Visible) // Eğer panel2 görünüyorsa
            {
                if (panel7.Visible)
                {
                    x2 = Convert.ToDouble(textBox6.Text);
                    x3 = Convert.ToDouble(textBox7.Text);
                    x4 = Convert.ToDouble(textBox8.Text);
                    x5 = Convert.ToDouble(textBox9.Text);
                    x6 = Convert.ToDouble(textBox10.Text);
                    x7 = Convert.ToDouble(textBox11.Text);
                    x8 = Convert.ToDouble(textBox12.Text);
                    x9 = Convert.ToDouble(textBox13.Text);
                    x10 = Convert.ToDouble(textBox14.Text);
                    textBox47.Text = Convert.ToString(((x2 * x6 * x10) + (x5 * x9 * x4)+(x8 * x3 * x7))- ((x4 * x6 * x8) + (x7 * x9 * x2) + (x10 * x3 * x5)));


                }

            }
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        string islem;
        bool C;
        public Form1()
        {
            InitializeComponent();
        }

        // İkinci matrisin elemanlarını sıfırlayan butonun kod bloğu
        private void button45_Click(object sender, EventArgs e)
        {
            if (panel6.Visible)
            {
                textclear(panel6); // Eğer panel6 görünüyorsa panel6 nın elemanlarını sıfırla
            }
            if (panel7.Visible)
            {
                textclear(panel7); // Eğer panel7 görünüyorsa panel7 nın elemanlarını sıfırla
            }
            if (panel8.Visible)
            {
                textclear(panel8); // Eğer panel8 görünüyorsa panel8 nın elemanlarını sıfırla
            }
        }

        // Üçüncü matrisin elemanlarını sıfırlayan butonun kod bloğu
        private void button57_Click(object sender, EventArgs e)
        {
            if (panel4.Visible)
            {
                textclear(panel4); // Eğer panel4 görünüyorsa panel4 nın elemanlarını sıfırla
            }
            if (panel5.Visible)
            {
                textclear(panel5); // Eğer panel5 görünüyorsa panel5 nın elemanlarını sıfırla
            }
            if (panel9.Visible)
            {
                textclear(panel9); // Eğer panel9 görünüyorsa panel9 nın elemanlarını sıfırla
            }
        }

        // İkinci matrisin 2x2 lik matris izini hesaplatan butonun kod bloğu
        private void button65_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(textBox111.Text); // İkinci 2x2 lik matrisin 1. elemanını x1 değişkenine atadık 
            x2 = Convert.ToDouble(textBox112.Text); // İkinci 2x2 lik matrisin 4. elemanını x2 değişkenine atadık
            textBox33.Text = Convert.ToString(x1 + x2); // İkinci 2x2 lik matrisin matris izini button65 in yanına yazdırdık
        }

        // İkinci matrisin 3x3 lük matris izini hesaplatan butonun kod bloğu
        private void button64_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(textBox109.Text); // İkinci 3x3 lük matrisin 1. elemanını x1 değişkenine atadık
            x2 = Convert.ToDouble(textBox105.Text); // İkinci 3x3 lük matrisin 5. elemanını x2 değişkenine atadık
            x3 = Convert.ToDouble(textBox101.Text); // İkinci 3x3 lük matrisin 9. elemanını x3 değişkenine atadık
            textBox32.Text = Convert.ToString(x1 + x2 + x3); // İkinci 3x3 lük matrisin matris izini button64 ün yanına yazdırdık
        }

        // İkinci matrisin 4x4 lük matris izini hesaplatan butonun kod bloğu
        private void button59_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(textBox100.Text); // İkinci 4x4 lük matrisin 1.elemanını x1 değişkenine atadık
            x2 = Convert.ToDouble(textBox95.Text); // İkinci 4x4 lük matrisin 6.elemanını x2 değişkenine atadık
            x3 = Convert.ToDouble(textBox90.Text); // İkinci 4x4 lük matrisin 11.elemanını x3 değişkenine atadık
            x4 = Convert.ToDouble(textBox85.Text); // İkinci 4x4 lük matrisin 16.elemanını x4 değişkenine atadık
            textBox31.Text = Convert.ToString(x1 + x2 + x3 + x4); // İkinci 4x4 lük matrisin matris izini button59 un yanına yazdırdık
        }

        // İkinci matrisin 2x2 lik matris tersini hesaplatan butonun kod bloğu 
        private void button67_Click(object sender, EventArgs e)
        {
            x2 = Convert.ToDouble(textBox111.Text); // İkinci 2x2 lik matrisin 1.elemanını x2 değişkenine atadık
            x3 = Convert.ToDouble(textBox110.Text); // İkinci 2x2 lik matrisin 2. elemanını x3 değişkenine atadık
            x4 = Convert.ToDouble(textBox113.Text); // İkinci 2x2 lik matrisin 3. elemanını x4 değişkenine atadık
            x5 = Convert.ToDouble(textBox112.Text); // İkinci 2x2 lik matrisin 4. elemanını x5 değişkenine atadık
            textBox111.Text = Convert.ToString(x5 / (x2 * x5 - x4 * x3)); // Ek matris / determinant
            textBox110.Text = Convert.ToString(-x3 / (x2 * x5 - x4 * x3)); // Ek matris / determinant 
            textBox113.Text = Convert.ToString(-x4 / (x2 * x5 - x4 * x3)); // Ek matris / determinant
            textBox112.Text = Convert.ToString(x2 / (x2 * x5 - x4 * x3)); // Ek matris / determinant
        }

        // İkinci matrisin 3x3 lük matris tersini hesaplatan butonun kod bloğu 
        private void button66_Click(object sender, EventArgs e)
        {
            x2 = Convert.ToDouble(textBox109.Text); // İkinci 3x3 lük matrisin 1.elemanını x2 değişkenine atadık
            x3 = Convert.ToDouble(textBox108.Text); // İkinci 3x3 lük matrisin 2.elemanını x3 değişkenine atadık
            x4 = Convert.ToDouble(textBox107.Text); // İkinci 3x3 lük matrisin 3.elemanını x4 değişkenine atadık
            x5 = Convert.ToDouble(textBox106.Text); // İkinci 3x3 lük matrisin 4.elemanını x5 değişkenine atadık
            x6 = Convert.ToDouble(textBox105.Text); // İkinci 3x3 lük matrisin 5.elemanını x6 değişkenine atadık
            x7 = Convert.ToDouble(textBox104.Text); // İkinci 3x3 lük matrisin 6.elemanını x7 değişkenine atadık
            x8 = Convert.ToDouble(textBox103.Text); // İkinci 3x3 lük matrisin 7.elemanını x8 değişkenine atadık
            x9 = Convert.ToDouble(textBox102.Text); // İkinci 3x3 lük matrisin 8.elemanını x9 değişkenine atadık
            x10 = Convert.ToDouble(textBox101.Text);  // İkinci 3x3 lük matrisin 9.elemanını x10 değişkenine atadık
            textBox109.Text = Convert.ToString(((x6 * x10) - (x9 * x7)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox108.Text = Convert.ToString(((x9 * x4) - (x3 * x10)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox107.Text = Convert.ToString(((x3 * x7) - (x6 * x4)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox106.Text = Convert.ToString(((x8 * x7) - (x5 * x10)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox105.Text = Convert.ToString(((x2 * x10) - (x8 * x4)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox104.Text = Convert.ToString(((x5 * x4) - (x2 * x7)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox103.Text = Convert.ToString(((x5 * x9) - (x8 * x6)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox102.Text = Convert.ToString(((x8 * x3) - (x2 * x9)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox101.Text = Convert.ToString(((x2 * x6) - (x5 * x3)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
        }

        // Üçüncü matrisin 2x2 lik matris tersini hesaplatan butonun kod bloğu
        private void button69_Click(object sender, EventArgs e)
        {
            x2 = Convert.ToDouble(textBox35.Text); // Üçüncü 2x2 lik matrisin 1.elemanını x2 değişkenine atadık
            x3 = Convert.ToDouble(textBox34.Text); // Üçüncü 2x2 lik matrisin 2.elemanını x3 değişkenine atadık
            x4 = Convert.ToDouble(textBox37.Text); // Üçüncü 2x2 lik matrisin 3.elemanını x4 değişkenine atadık
            x5 = Convert.ToDouble(textBox36.Text); // Üçüncü 2x2 lik matrisin 4.elemanını x5 değişkenine atadık
            textBox35.Text = Convert.ToString(x5 / (x2 * x5 - x4 * x3)); // Ek matris / determinant
            textBox34.Text = Convert.ToString(-x3 / (x2 * x5 - x4 * x3)); // Ek matris / determinant
            textBox37.Text = Convert.ToString(-x4 / (x2 * x5 - x4 * x3)); // Ek matris / determinant
            textBox36.Text = Convert.ToString(x2 / (x2 * x5 - x4 * x3)); // Ek matris / determinant
        }

        // Üçüncü matrisin 3x3 lük matris tersini hesaplatan butonun kod bloğu
        private void button68_Click(object sender, EventArgs e)
        {
            x2 = Convert.ToDouble(textBox46.Text); // Üçüncü 3x3 lük matrisin 1.elemanını x2 değişkenine atadık
            x3 = Convert.ToDouble(textBox45.Text); // Üçüncü 3x3 lük matrisin 2.elemanını x3 değişkenine atadık
            x4 = Convert.ToDouble(textBox44.Text); // Üçüncü 3x3 lük matrisin 3.elemanını x4 değişkenine atadık
            x5 = Convert.ToDouble(textBox43.Text); // Üçüncü 3x3 lük matrisin 4.elemanını x5 değişkenine atadık
            x6 = Convert.ToDouble(textBox42.Text); // Üçüncü 3x3 lük matrisin 5.elemanını x6 değişkenine atadık
            x7 = Convert.ToDouble(textBox41.Text); // Üçüncü 3x3 lük matrisin 6.elemanını x7 değişkenine atadık
            x8 = Convert.ToDouble(textBox40.Text); // Üçüncü 3x3 lük matrisin 7.elemanını x8 değişkenine atadık
            x9 = Convert.ToDouble(textBox39.Text); // Üçüncü 3x3 lük matrisin 8.elemanını x9 değişkenine atadık
            x10 = Convert.ToDouble(textBox38.Text); // Üçüncü 3x3 lük matrisin 9.elemanını x10 değişkenine atadık
            textBox46.Text = Convert.ToString(((x6 * x10) - (x9 * x7)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox45.Text = Convert.ToString(((x9 * x4) - (x3 * x10)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox44.Text = Convert.ToString(((x3 * x7) - (x6 * x4)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox43.Text = Convert.ToString(((x8 * x7) - (x5 * x10)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox42.Text = Convert.ToString(((x2 * x10) - (x8 * x4)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox41.Text = Convert.ToString(((x5 * x4) - (x2 * x7)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox40.Text = Convert.ToString(((x5 * x9) - (x8 * x6)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox39.Text = Convert.ToString(((x8 * x3) - (x2 * x9)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox38.Text = Convert.ToString(((x2 * x6) - (x5 * x3)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
        }

        // Birinci matrisin 4x4 lük matris tersini hesaplatan butonun kod bloğu
        private void button70_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(textBox15.Text); // Birinci 4x4 lük matrisin 1.elemanını x1 değişkenine atadık
            x2 = Convert.ToDouble(textBox16.Text); // Birinci 4x4 lük matrisin 2.elemanını x2 değişkenine atadık
            x3 = Convert.ToDouble(textBox17.Text); // Birinci 4x4 lük matrisin 3.elemanını x3 değişkenine atadık
            x4 = Convert.ToDouble(textBox18.Text); // Birinci 4x4 lük matrisin 4.elemanını x4 değişkenine atadık
            x5 = Convert.ToDouble(textBox19.Text); // Birinci 4x4 lük matrisin 5.elemanını x5 değişkenine atadık
            x6 = Convert.ToDouble(textBox20.Text); // Birinci 4x4 lük matrisin 6.elemanını x6 değişkenine atadık
            x7 = Convert.ToDouble(textBox21.Text); // Birinci 4x4 lük matrisin 7.elemanını x7 değişkenine atadık
            x8 = Convert.ToDouble(textBox22.Text); // Birinci 4x4 lük matrisin 8.elemanını x8 değişkenine atadık
            x9 = Convert.ToDouble(textBox23.Text); // Birinci 4x4 lük matrisin 9.elemanını x9 değişkenine atadık
            x10 = Convert.ToDouble(textBox24.Text); // Birinci 4x4 lük matrisin 10.elemanını x10 değişkenine atadık
            x11 = Convert.ToDouble(textBox25.Text); // Birinci 4x4 lük matrisin 11.elemanını x11 değişkenine atadık
            x12 = Convert.ToDouble(textBox26.Text); // Birinci 4x4 lük matrisin 12.elemanını x12 değişkenine atadık
            x13 = Convert.ToDouble(textBox27.Text); // Birinci 4x4 lük matrisin 13.elemanını x13 değişkenine atadık
            x14 = Convert.ToDouble(textBox28.Text); // Birinci 4x4 lük matrisin 14.elemanını x14 değişkenine atadık
            x15 = Convert.ToDouble(textBox29.Text); // Birinci 4x4 lük matrisin 15.elemanını x15 değişkenine atadık
            x16 = Convert.ToDouble(textBox30.Text); // Birinci 4x4 lük matrisin 16.elemanını x16 değişkenine atadık
            double det = (x1 * (x6 * (x11 * x16 - x15 * x12) - x7 * (x10 * x16 - x14 * x12) + x8 * (x10 * x15 - x14 * x11)) + -x2 * (x5 * (x11 * x16 - x15 * x12) - x7 * (x9 * x16 - x13 * x12) + x8 * (x9 * x15 - x13 * x11)) + x3 * (x5 * (x10 * x16 - x14 * x12) - x6 * (x9 * x16 - x13 * x12) + x8 * (x9 * x14 - x13 * x10)) - x4 * (x5 * (x10 * x15 - x14 * x11) - x6 * (x9 * x15 - x13 * x11) + x7 * (x9 * x14 - x13 * x10))); // determinant
            textBox15.Text = Convert.ToString((x6 * (x11 * x16 - x15 * x12) - x7 * (x10 * x16 - x14 * x12) + x8 * (x10 * x15 - x14 * x11)) / det); // Ek matris / determinant
            textBox20.Text = Convert.ToString((x1 * (x11 * x16 - x15 * x12) - x3 * (x9 * x16 - x13 * x12) + x4 * (x9 * x15 - x13 * x12)) / det); // Ek matris / determinant
            textBox25.Text = Convert.ToString((x1 * (x6 * x16 - x14 * x8) - x2 * (x5 * x16 - x13 * x8) + x4 * (x5 * x14 - x13 * x6)) / det); // Ek matris / determinant
            textBox30.Text = Convert.ToString((x1 * (x6 * x11 - x10 * x7) - x2 * (x5 * x11 - x9 * x7) + x3 * (x5 * x10 - x9 * x6)) / det); // Ek matris / determinant
            textBox19.Text = Convert.ToString(-(x5 * (x11 * x16 - x15 * x12) - x7 * (x9 * x16 - x13 * x12) + x8 * (x9 * x15 - x13 * x11)) / det); // Ek matris / determinant
            textBox16.Text = Convert.ToString(-(x2 * (x11 * x16 - x15 * x12) - x3 * (x10 * x16 - x14 * x12) + x4 * (x10 * x15 - x14 * x11)) / det); // Ek matris / determinant
            textBox17.Text = Convert.ToString((x2 * (x7 * x16 - x15 * x8) - x3 * (x6 * x16 - x14 * x8) + x4 * (x6 * x15 - x14 * x7)) / det); // Ek matris / determinant
            textBox23.Text = Convert.ToString((x5 * (x10 * x16 - x14 * x12) - x6 * (x9 * x16 - x13 * x12) + x8 * (x9 * x14 - x13 * x10)) / det); // Ek matris / determinant
            textBox27.Text = Convert.ToString(-(x5 * (x10 * x15 - x14 * x11) - x6 * (x9 * x15 - x13 * x11) + x7 * (x9 * x14 - x13 * x10)) / det); // Ek matris / determinant
            textBox24.Text = Convert.ToString(-(x1 * (x10 * x16 - x14 * x12) - x2 * (x9 * x16 - x13 * x12) + x4 * (x9 * x14 - x13 * x10)) / det); // Ek matris / determinant
            textBox21.Text = Convert.ToString(-(x1 * (x7 * x16 - x15 * x8) - x3 * (x5 * x16 - x13 * x8) + x4 * (x5 * x15 - x13 * x7)) / det); // Ek matris / determinant
            textBox18.Text = Convert.ToString(-(x2 * (x7 * x12 - x11 * x8) - x3 * (x6 * x12 - x10 * x8) + x4 * (x6 * x11 - x10 * x7)) / det); // Ek matris / determinant 
            textBox26.Text = Convert.ToString(-(x1 * (x6 * x12 - x10 * x8) - x2 * (x5 * x12 - x9 * x8) + x4 * (x5 * x10 - x9 * x6)) / det); // Ek matris / determinant
            textBox29.Text = Convert.ToString(-(x1 * (x6 * x15 - x14 * x7) - x2 * (x5 * x15 - x13 * x7) + x3 * (x5 * x14 - x13 * x6)) / det); // Ek matris / determinant
            textBox28.Text = Convert.ToString((x1 * (x10 * x15 - x14 * x11) - x2 * (x9 * x15 - x13 * x11) + x3 * (x9 * x14 - x13 * x10)) / det); // Ek matris / determinant
            textBox22.Text = Convert.ToString((x1 * (x7 * x12 - x11 * x8) - x3 * (x5 * x12 - x9 * x8) + x4 * (x5 * x11 - x9 * x7)) / det); // Ek matris / determinant
        }

        // İkinci matrisin 4x4 lük matris tersini hesaplatan butonun kod bloğu
        private void button71_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(textBox100.Text); // İkinci 4x4 lük matrisin 1.elemanını x1 değişkenine atadık
            x2 = Convert.ToDouble(textBox99.Text); // İkinci 4x4 lük matrisin 2.elemanını x2 değişkenine atadık
            x3 = Convert.ToDouble(textBox98.Text); // İkinci 4x4 lük matrisin 3.elemanını x3 değişkenine atadık
            x4 = Convert.ToDouble(textBox97.Text); // İkinci 4x4 lük matrisin 4.elemanını x4 değişkenine atadık
            x5 = Convert.ToDouble(textBox96.Text); // İkinci 4x4 lük matrisin 5.elemanını x5 değişkenine atadık
            x6 = Convert.ToDouble(textBox95.Text); // İkinci 4x4 lük matrisin 6.elemanını x6 değişkenine atadık
            x7 = Convert.ToDouble(textBox94.Text); // İkinci 4x4 lük matrisin 7.elemanını x7 değişkenine atadık
            x8 = Convert.ToDouble(textBox93.Text); // İkinci 4x4 lük matrisin 8.elemanını x8 değişkenine atadık
            x9 = Convert.ToDouble(textBox92.Text); // İkinci 4x4 lük matrisin 9.elemanını x9 değişkenine atadık
            x10 = Convert.ToDouble(textBox91.Text); // İkinci 4x4 lük matrisin 10.elemanını x10 değişkenine atadık
            x11 = Convert.ToDouble(textBox90.Text); // İkinci 4x4 lük matrisin 11.elemanını x11 değişkenine atadık
            x12 = Convert.ToDouble(textBox89.Text); // İkinci 4x4 lük matrisin 12.elemanını x12 değişkenine atadık
            x13 = Convert.ToDouble(textBox88.Text); // İkinci 4x4 lük matrisin 13.elemanını x13 değişkenine atadık
            x14 = Convert.ToDouble(textBox87.Text); // İkinci 4x4 lük matrisin 14.elemanını x14 değişkenine atadık
            x15 = Convert.ToDouble(textBox86.Text); // İkinci 4x4 lük matrisin 15.elemanını x15 değişkenine atadık
            x16 = Convert.ToDouble(textBox85.Text); // İkinci 4x4 lük matrisin 16.elemanını x16 değişkenine atadık
            double det = (x1 * (x6 * (x11 * x16 - x15 * x12) - x7 * (x10 * x16 - x14 * x12) + x8 * (x10 * x15 - x14 * x11)) + -x2 * (x5 * (x11 * x16 - x15 * x12) - x7 * (x9 * x16 - x13 * x12) + x8 * (x9 * x15 - x13 * x11)) + x3 * (x5 * (x10 * x16 - x14 * x12) - x6 * (x9 * x16 - x13 * x12) + x8 * (x9 * x14 - x13 * x10)) - x4 * (x5 * (x10 * x15 - x14 * x11) - x6 * (x9 * x15 - x13 * x11) + x7 * (x9 * x14 - x13 * x10))); // determinant
            textBox100.Text = Convert.ToString((x6 * (x11 * x16 - x15 * x12) - x7 * (x10 * x16 - x14 * x12) + x8 * (x10 * x15 - x14 * x11)) / det); // Ek matris / determinant
            textBox95.Text = Convert.ToString((x1 * (x11 * x16 - x15 * x12) - x3 * (x9 * x16 - x13 * x12) + x4 * (x9 * x15 - x13 * x12)) / det); // Ek matris / determinant
            textBox90.Text = Convert.ToString((x1 * (x6 * x16 - x14 * x8) - x2 * (x5 * x16 - x13 * x8) + x4 * (x5 * x14 - x13 * x6)) / det); // Ek matris / determinant
            textBox85.Text = Convert.ToString((x1 * (x6 * x11 - x10 * x7) - x2 * (x5 * x11 - x9 * x7) + x3 * (x5 * x10 - x9 * x6)) / det); // Ek matris / determinant
            textBox96.Text = Convert.ToString(-(x5 * (x11 * x16 - x15 * x12) - x7 * (x9 * x16 - x13 * x12) + x8 * (x9 * x15 - x13 * x11)) / det); // Ek matris / determinant
            textBox99.Text = Convert.ToString(-(x2 * (x11 * x16 - x15 * x12) - x3 * (x10 * x16 - x14 * x12) + x4 * (x10 * x15 - x14 * x11)) / det); // Ek matris / determinant
            textBox98.Text = Convert.ToString((x2 * (x7 * x16 - x15 * x8) - x3 * (x6 * x16 - x14 * x8) + x4 * (x6 * x15 - x14 * x7)) / det); // Ek matris / determinant
            textBox92.Text = Convert.ToString((x5 * (x10 * x16 - x14 * x12) - x6 * (x9 * x16 - x13 * x12) + x8 * (x9 * x14 - x13 * x10)) / det); // Ek matris / determinant
            textBox88.Text = Convert.ToString(-(x5 * (x10 * x15 - x14 * x11) - x6 * (x9 * x15 - x13 * x11) + x7 * (x9 * x14 - x13 * x10)) / det); // Ek matris / determinant
            textBox91.Text = Convert.ToString(-(x1 * (x10 * x16 - x14 * x12) - x2 * (x9 * x16 - x13 * x12) + x4 * (x9 * x14 - x13 * x10)) / det); // Ek matris / determinant
            textBox94.Text = Convert.ToString(-(x1 * (x7 * x16 - x15 * x8) - x3 * (x5 * x16 - x13 * x8) + x4 * (x5 * x15 - x13 * x7)) / det); // Ek matris / determinant
            textBox97.Text = Convert.ToString(-(x2 * (x7 * x12 - x11 * x8) - x3 * (x6 * x12 - x10 * x8) + x4 * (x6 * x11 - x10 * x7)) / det); // Ek matris / determinant
            textBox89.Text = Convert.ToString(-(x1 * (x6 * x12 - x10 * x8) - x2 * (x5 * x12 - x9 * x8) + x4 * (x5 * x10 - x9 * x6)) / det); // Ek matris / determinant
            textBox86.Text = Convert.ToString(-(x1 * (x6 * x15 - x14 * x7) - x2 * (x5 * x15 - x13 * x7) + x3 * (x5 * x14 - x13 * x6)) / det); // Ek matris / determinant
            textBox87.Text = Convert.ToString((x1 * (x10 * x15 - x14 * x11) - x2 * (x9 * x15 - x13 * x11) + x3 * (x9 * x14 - x13 * x10)) / det); // Ek matris / determinant
            textBox93.Text = Convert.ToString((x1 * (x7 * x12 - x11 * x8) - x3 * (x5 * x12 - x9 * x8) + x4 * (x5 * x11 - x9 * x7)) / det); // Ek matris / determinant
        }
        // Üçüncü matrisin 4x4 lük matris tersini hesaplatan butonun kod bloğu
        private void button72_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(textBox138.Text); // Üçüncü 4x4 lük matrisin 1.elemanını x1 değişkenine atadık
            x2 = Convert.ToDouble(textBox137.Text); // Üçüncü 4x4 lük matrisin 2.elemanını x2 değişkenine atadık
            x3 = Convert.ToDouble(textBox136.Text); // Üçüncü 4x4 lük matrisin 3.elemanını x3 değişkenine atadık
            x4 = Convert.ToDouble(textBox135.Text); // Üçüncü 4x4 lük matrisin 4.elemanını x4 değişkenine atadık
            x5 = Convert.ToDouble(textBox133.Text); // Üçüncü 4x4 lük matrisin 5.elemanını x5 değişkenine atadık
            x6 = Convert.ToDouble(textBox132.Text); // Üçüncü 4x4 lük matrisin 6.elemanını x6 değişkenine atadık
            x7 = Convert.ToDouble(textBox131.Text); // Üçüncü 4x4 lük matrisin 7.elemanını x7 değişkenine atadık
            x8 = Convert.ToDouble(textBox130.Text); // Üçüncü 4x4 lük matrisin 8.elemanını x8 değişkenine atadık
            x9 = Convert.ToDouble(textBox128.Text); // Üçüncü 4x4 lük matrisin 9.elemanını x9 değişkenine atadık
            x10 = Convert.ToDouble(textBox127.Text); // Üçüncü 4x4 lük matrisin 10.elemanını x10 değişkenine atadık
            x11 = Convert.ToDouble(textBox126.Text); // Üçüncü 4x4 lük matrisin 11.elemanını x11 değişkenine atadık
            x12 = Convert.ToDouble(textBox125.Text); // Üçüncü 4x4 lük matrisin 12.elemanını x12 değişkenine atadık
            x13 = Convert.ToDouble(textBox123.Text); // Üçüncü 4x4 lük matrisin 13.elemanını x13 değişkenine atadık
            x14 = Convert.ToDouble(textBox122.Text); // Üçüncü 4x4 lük matrisin 14.elemanını x14 değişkenine atadık
            x15 = Convert.ToDouble(textBox121.Text); // Üçüncü 4x4 lük matrisin 15.elemanını x15 değişkenine atadık
            x16 = Convert.ToDouble(textBox120.Text); // Üçüncü 4x4 lük matrisin 16.elemanını x16 değişkenine atadık
            double det = (x1 * (x6 * (x11 * x16 - x15 * x12) - x7 * (x10 * x16 - x14 * x12) + x8 * (x10 * x15 - x14 * x11)) + -x2 * (x5 * (x11 * x16 - x15 * x12) - x7 * (x9 * x16 - x13 * x12) + x8 * (x9 * x15 - x13 * x11)) + x3 * (x5 * (x10 * x16 - x14 * x12) - x6 * (x9 * x16 - x13 * x12) + x8 * (x9 * x14 - x13 * x10)) - x4 * (x5 * (x10 * x15 - x14 * x11) - x6 * (x9 * x15 - x13 * x11) + x7 * (x9 * x14 - x13 * x10))); // determinant
            textBox138.Text = Convert.ToString((x6 * (x11 * x16 - x15 * x12) - x7 * (x10 * x16 - x14 * x12) + x8 * (x10 * x15 - x14 * x11)) / det); // Ek matris / determinant
            textBox132.Text = Convert.ToString((x1 * (x11 * x16 - x15 * x12) - x3 * (x9 * x16 - x13 * x12) + x4 * (x9 * x15 - x13 * x12)) / det); // Ek matris / determinant
            textBox126.Text = Convert.ToString((x1 * (x6 * x16 - x14 * x8) - x2 * (x5 * x16 - x13 * x8) + x4 * (x5 * x14 - x13 * x6)) / det); // Ek matris / determinant
            textBox120.Text = Convert.ToString((x1 * (x6 * x11 - x10 * x7) - x2 * (x5 * x11 - x9 * x7) + x3 * (x5 * x10 - x9 * x6)) / det); // Ek matris / determinant
            textBox133.Text = Convert.ToString(-(x5 * (x11 * x16 - x15 * x12) - x7 * (x9 * x16 - x13 * x12) + x8 * (x9 * x15 - x13 * x11)) / det); // Ek matris / determinant
            textBox137.Text = Convert.ToString(-(x2 * (x11 * x16 - x15 * x12) - x3 * (x10 * x16 - x14 * x12) + x4 * (x10 * x15 - x14 * x11)) / det); // Ek matris / determinant
            textBox136.Text = Convert.ToString((x2 * (x7 * x16 - x15 * x8) - x3 * (x6 * x16 - x14 * x8) + x4 * (x6 * x15 - x14 * x7)) / det); // Ek matris / determinant
            textBox128.Text = Convert.ToString((x5 * (x10 * x16 - x14 * x12) - x6 * (x9 * x16 - x13 * x12) + x8 * (x9 * x14 - x13 * x10)) / det); // Ek matris / determinant
            textBox123.Text = Convert.ToString(-(x5 * (x10 * x15 - x14 * x11) - x6 * (x9 * x15 - x13 * x11) + x7 * (x9 * x14 - x13 * x10)) / det); // Ek matris / determinant
            textBox127.Text = Convert.ToString(-(x1 * (x10 * x16 - x14 * x12) - x2 * (x9 * x16 - x13 * x12) + x4 * (x9 * x14 - x13 * x10)) / det); // Ek matris / determinant
            textBox131.Text = Convert.ToString(-(x1 * (x7 * x16 - x15 * x8) - x3 * (x5 * x16 - x13 * x8) + x4 * (x5 * x15 - x13 * x7)) / det); // Ek matris / determinant
            textBox135.Text = Convert.ToString(-(x2 * (x7 * x12 - x11 * x8) - x3 * (x6 * x12 - x10 * x8) + x4 * (x6 * x11 - x10 * x7)) / det); // Ek matris / determinant
            textBox125.Text = Convert.ToString(-(x1 * (x6 * x12 - x10 * x8) - x2 * (x5 * x12 - x9 * x8) + x4 * (x5 * x10 - x9 * x6)) / det); // Ek matris / determinant
            textBox121.Text = Convert.ToString(-(x1 * (x6 * x15 - x14 * x7) - x2 * (x5 * x15 - x13 * x7) + x3 * (x5 * x14 - x13 * x6)) / det); // Ek matris / determinant
            textBox122.Text = Convert.ToString((x1 * (x10 * x15 - x14 * x11) - x2 * (x9 * x15 - x13 * x11) + x3 * (x9 * x14 - x13 * x10)) / det); // Ek matris / determinant
            textBox130.Text = Convert.ToString((x1 * (x7 * x12 - x11 * x8) - x3 * (x5 * x12 - x9 * x8) + x4 * (x5 * x11 - x9 * x7)) / det); // Ek matris / determinant
        }
        // Üçüncü matrisin 2x2 lik matris tablosunu gösteren butonun kod bloğu
        private void button77_Click(object sender, EventArgs e)
        {
            if (panel5.Visible || panel9.Visible)
            {
                panel5.Visible = false; // Eğer panel15 veya panel9 görünüyorsa panel5 in görünürlüğünü kapat
                panel9.Visible = false; // panel9 un görünürlüğünü kapat
                panel4.Visible = true; // panel4 ün görünürlüğünü aç 
                button77.Enabled = false; // button77 nin aktifliğini kapat
                button78.Enabled = true; // button78 in aktifliğini aç
                button79.Enabled = true; // button79 un aktifliğini aç
            }
        }
        // Üçüncü matrisin 3x3 lük matris tablosunu gösteren butonun kod bloğu
        private void button78_Click(object sender, EventArgs e)
        {
            if (panel4.Visible || panel9.Visible)
            {
                panel4.Visible = false; // Eğer panel4 veya panel9 görünüyorsa panel4 ün görünürlüğünü kapat
                panel9.Visible = false; // panel9 un görünürlüğünü kapat
                panel5.Visible = true; // panel5 in görünürlüğünü aç
                button78.Enabled = false; // button78 in aktifliğini kapat
                button77.Enabled = true; // button77 nin aktifliğini aç
                button79.Enabled = true; // button79 un aktifliğini aç
            }
        }

        // Üçüncü matrisin 4x4 lük matris tablosunu gösteren butonun kod bloğu
        private void button79_Click(object sender, EventArgs e)
        {
            if (panel5.Visible || panel4.Visible)
            {
                panel5.Visible = false; // Eğer panel5 veya panel4 görünüyorsa panel5 in görünürlüğünü kapat
                panel4.Visible = false; // panel4 ün görünürlüğünü kapat
                panel9.Visible = true; // panel9 un görünürlüğünü aç
                button79.Enabled = false; // button79 in aktifliğini kapat
                button77.Enabled = true; // button77 in aktifliğini aç
                button78.Enabled = true; // button78 in aktifliğini aç
            }

        }



        // Matrislerin toplamını hesaplatan butonun kod bloğu
        private void button50_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Toplama işlemini yapmak için lütfen tüm boyutları aynı seçiniz.");

            if (panel1.Visible) // Eğer panel1 görünüyorsa
            {
                if (panel8.Visible)
                {
                    x2 = Convert.ToDouble(textBox2.Text); //Eğer panel8 görünüyorsa Birinci 2x2 lik matrisin 1.elemanını x2 değişkenine atadık
                    x3 = Convert.ToDouble(textBox3.Text); // Birinci 2x2 lik matrisin 2. elemanını x3 değişkenine atadık
                    x4 = Convert.ToDouble(textBox4.Text); // Birinci 2x2 lik matrisin 3. elemanını x4 değişkenine atadık
                    x5 = Convert.ToDouble(textBox5.Text); // Birinci 2x2 lik matrisin 4. elemanını x5 değişkenine atadık
                    x6 = Convert.ToDouble(textBox111.Text); // İkinci 2x2 lik matrisin 1. elemanını x6 değişkenine atadık
                    x7 = Convert.ToDouble(textBox110.Text); // İkinci 2x2 lik matrisin 2. elemanını x7 değişkenine atadık
                    x8 = Convert.ToDouble(textBox113.Text); // İkinci 2x2 lik matrisin 3. elemanını x8 değişkenine atadık
                    x9 = Convert.ToDouble(textBox112.Text); // İkinci 2x2 lik matrisin 4. elemanını x9 değişkenine atadık
                    textBox35.Text = Convert.ToString(x2 + x6); // Birinci 2x2 lik matrisin 1. elemanı ile İkinci 2x2 lik matrisin 1. elemanının toplamı
                    textBox34.Text = Convert.ToString(x3 + x7); // Birinci 2x2 lik matrisin 2. elemanı ile İkinci 2x2 lik matrisin 2. elemanının toplamı
                    textBox37.Text = Convert.ToString(x4 + x8); // Birinci 2x2 lik matrisin 3. elemanı ile İkinci 2x2 lik matrisin 3. elemanının toplamı
                    textBox36.Text = Convert.ToString(x5 + x9); // Birinci 2x2 lik matrisin 4. elemanı ile İkinci 2x2 lik matrisin 4. elemanının toplamı
                }
                

            }
            if (panel2.Visible) // Eğer panel2 görünüyorsa
            {
                if (panel7.Visible)
                {
                    x2 = Convert.ToDouble(textBox6.Text); // Eğer panel7 görünüyorsa Birinci 3x3 lük matrisin 1. elemanını x2 değişkenine atadık
                    x3 = Convert.ToDouble(textBox7.Text); // Birinci 3x3 lük matrisin 2. elemanını x3 değişkenine atadık
                    x4 = Convert.ToDouble(textBox8.Text); // Birinci 3x3 lük matrisin 3. elemanını x4 değişkenine atadık
                    x5 = Convert.ToDouble(textBox9.Text); // Birinci 3x3 lük matrisin 4. elemanını x5 değişkenine atadık
                    x6 = Convert.ToDouble(textBox10.Text); // Birinci 3x3 lük matrisin 5. elemanını x6 değişkenine atadık
                    x7 = Convert.ToDouble(textBox11.Text); // Birinci 3x3 lük matrisin 6. elemanını x7 değişkenine atadık
                    x8 = Convert.ToDouble(textBox12.Text); // Birinci 3x3 lük matrisin 7. elemanını x8 değişkenine atadık
                    x9 = Convert.ToDouble(textBox13.Text); // Birinci 3x3 lük matrisin 8. elemanını x9 değişkenine atadık
                    x10 = Convert.ToDouble(textBox14.Text); // Birinci 3x3 lük matrisin 9. elemanını x10 değişkenine atadık
                    x11 = Convert.ToDouble(textBox109.Text); // İkinci 3x3 lük matrisin 1. elemanını x11 değişkenine atadık
                    x12 = Convert.ToDouble(textBox108.Text); // İkinci 3x3 lük matrisin 2. elemanını x12 değişkenine atadık
                    x13 = Convert.ToDouble(textBox107.Text); // İkinci 3x3 lük matrisin 3. elemanını x13 değişkenine atadık
                    x14 = Convert.ToDouble(textBox106.Text); // İkinci 3x3 lük matrisin 4. elemanını x14 değişkenine atadık
                    x15 = Convert.ToDouble(textBox105.Text); // İkinci 3x3 lük matrisin 5. elemanını x15 değişkenine atadık
                    x16 = Convert.ToDouble(textBox104.Text); // İkinci 3x3 lük matrisin 6. elemanını x16 değişkenine atadık
                    x17 = Convert.ToDouble(textBox103.Text); // İkinci 3x3 lük matrisin 7. elemanını x17 değişkenine atadık
                    x18 = Convert.ToDouble(textBox102.Text); // İkinci 3x3 lük matrisin 8. elemanını x18 değişkenine atadık
                    x19 = Convert.ToDouble(textBox101.Text); // İkinci 3x3 lük matrisin 9. elemanını x19 değişkenine atadık
                    textBox46.Text = Convert.ToString(x2 + x11); // Birinci 3x3 lük matrisin 1. elemanı ile İkinci 3x3 lük matrisin 1. elemanının toplamı
                    textBox45.Text = Convert.ToString(x3 + x12); // Birinci 3x3 lük matrisin 2. elemanı ile İkinci 3x3 lük matrisin 2. elemanının toplamı
                    textBox44.Text = Convert.ToString(x4 + x13); // Birinci 3x3 lük matrisin 3. elemanı ile İkinci 3x3 lük matrisin 3. elemanının toplamı
                    textBox43.Text = Convert.ToString(x5 + x14); // Birinci 3x3 lük matrisin 4. elemanı ile İkinci 3x3 lük matrisin 4. elemanının toplamı
                    textBox42.Text = Convert.ToString(x6 + x15); // Birinci 3x3 lük matrisin 5. elemanı ile İkinci 3x3 lük matrisin 5. elemanının toplamı
                    textBox41.Text = Convert.ToString(x7 + x16); // Birinci 3x3 lük matrisin 6. elemanı ile İkinci 3x3 lük matrisin 6. elemanının toplamı
                    textBox40.Text = Convert.ToString(x8 + x17); // Birinci 3x3 lük matrisin 7. elemanı ile İkinci 3x3 lük matrisin 7. elemanının toplamı
                    textBox39.Text = Convert.ToString(x9 + x18); // Birinci 3x3 lük matrisin 8. elemanı ile İkinci 3x3 lük matrisin 8. elemanının toplamı
                    textBox38.Text = Convert.ToString(x10 + x19); // Birinci 3x3 lük matrisin 9. elemanı ile İkinci 3x3 lük matrisin 9. elemanının toplamı
                }
                
            }
            if (panel3.Visible) // Eğer panel3 görünüyorsa
            {
                if (panel6.Visible)
                {
                    x2 = Convert.ToDouble(textBox15.Text); // Eğer panel6 görünüyorsa Birinci 4x4 lük matrisin 1. elemanını x2 değişkenine atadık
                    x3 = Convert.ToDouble(textBox16.Text); // Birinci 4x4 lük matrisin 2. elemanını x3 değişkenine atadık
                    x4 = Convert.ToDouble(textBox17.Text); // Birinci 4x4 lük matrisin 3. elemanını x4 değişkenine atadık
                    x5 = Convert.ToDouble(textBox18.Text); // Birinci 4x4 lük matrisin 4. elemanını x5 değişkenine atadık
                    x6 = Convert.ToDouble(textBox19.Text); // Birinci 4x4 lük matrisin 5. elemanını x6 değişkenine atadık
                    x7 = Convert.ToDouble(textBox20.Text); // Birinci 4x4 lük matrisin 6. elemanını x7 değişkenine atadık
                    x8 = Convert.ToDouble(textBox21.Text); // Birinci 4x4 lük matrisin 7. elemanını x8 değişkenine atadık
                    x9 = Convert.ToDouble(textBox22.Text); // Birinci 4x4 lük matrisin 8. elemanını x9 değişkenine atadık
                    x10 = Convert.ToDouble(textBox23.Text); // Birinci 4x4 lük matrisin 9. elemanını x10 değişkenine atadık
                    x11 = Convert.ToDouble(textBox24.Text); // Birinci 4x4 lük matrisin 10. elemanını x11 değişkenine atadık
                    x12 = Convert.ToDouble(textBox25.Text); // Birinci 4x4 lük matrisin 11. elemanını x12 değişkenine atadık
                    x13 = Convert.ToDouble(textBox26.Text); // Birinci 4x4 lük matrisin 12. elemanını x13 değişkenine atadık
                    x14 = Convert.ToDouble(textBox27.Text); // Birinci 4x4 lük matrisin 13. elemanını x14 değişkenine atadık
                    x15 = Convert.ToDouble(textBox28.Text); // Birinci 4x4 lük matrisin 14. elemanını x15 değişkenine atadık
                    x16 = Convert.ToDouble(textBox29.Text); // Birinci 4x4 lük matrisin 15. elemanını x16 değişkenine atadık
                    x17 = Convert.ToDouble(textBox30.Text); // Birinci 4x4 lük matrisin 16. elemanını x17 değişkenine atadık
                    x18 = Convert.ToDouble(textBox100.Text); // İkinci 4x4 lük matrisin 1. elemanını x18 değişkenine atadık
                    x19 = Convert.ToDouble(textBox99.Text); // İkinci 4x4 lük matrisin 2. elemanını x19 değişkenine atadık
                    x20 = Convert.ToDouble(textBox98.Text); // İkinci 4x4 lük matrisin 3. elemanını x20 değişkenine atadık
                    x21 = Convert.ToDouble(textBox97.Text); // İkinci 4x4 lük matrisin 4. elemanını x21 değişkenine atadık
                    x22 = Convert.ToDouble(textBox96.Text); // İkinci 4x4 lük matrisin 5. elemanını x22 değişkenine atadık
                    x23 = Convert.ToDouble(textBox95.Text); // İkinci 4x4 lük matrisin 6. elemanını x23 değişkenine atadık
                    x24 = Convert.ToDouble(textBox94.Text); // İkinci 4x4 lük matrisin 7. elemanını x24 değişkenine atadık
                    x25 = Convert.ToDouble(textBox93.Text); // İkinci 4x4 lük matrisin 8. elemanını x25 değişkenine atadık
                    x26 = Convert.ToDouble(textBox92.Text); // İkinci 4x4 lük matrisin 9. elemanını x26 değişkenine atadık
                    x27 = Convert.ToDouble(textBox91.Text); // İkinci 4x4 lük matrisin 10. elemanını x27 değişkenine atadık
                    x28 = Convert.ToDouble(textBox90.Text); // İkinci 4x4 lük matrisin 11. elemanını x28 değişkenine atadık
                    x29 = Convert.ToDouble(textBox89.Text); // İkinci 4x4 lük matrisin 12. elemanını x29 değişkenine atadık
                    x30 = Convert.ToDouble(textBox88.Text); // İkinci 4x4 lük matrisin 13. elemanını x30 değişkenine atadık
                    x31 = Convert.ToDouble(textBox87.Text); // İkinci 4x4 lük matrisin 14. elemanını x31 değişkenine atadık
                    x32 = Convert.ToDouble(textBox86.Text); // İkinci 4x4 lük matrisin 15. elemanını x32 değişkenine atadık
                    x33 = Convert.ToDouble(textBox85.Text); // İkinci 4x4 lük matrisin 16. elemanını x33 değişkenine atadık
                    textBox138.Text = Convert.ToString(x2 + x18); // Birinci 4x4 lük matrisin 1. elemanı ile İkinci 4x4 lük matrisin 1. elemanının toplamı 
                    textBox137.Text = Convert.ToString(x3 + x19); // Birinci 4x4 lük matrisin 2. elemanı ile İkinci 4x4 lük matrisin 2. elemanının toplamı
                    textBox136.Text = Convert.ToString(x4 + x20); // Birinci 4x4 lük matrisin 3. elemanı ile İkinci 4x4 lük matrisin 3. elemanının toplamı
                    textBox135.Text = Convert.ToString(x5 + x21); // Birinci 4x4 lük matrisin 4. elemanı ile İkinci 4x4 lük matrisin 4. elemanının toplamı
                    textBox133.Text = Convert.ToString(x6 + x22); // Birinci 4x4 lük matrisin 5. elemanı ile İkinci 4x4 lük matrisin 5. elemanının toplamı
                    textBox132.Text = Convert.ToString(x7 + x23); // Birinci 4x4 lük matrisin 6. elemanı ile İkinci 4x4 lük matrisin 6. elemanının toplamı
                    textBox131.Text = Convert.ToString(x8 + x24); // Birinci 4x4 lük matrisin 7. elemanı ile İkinci 4x4 lük matrisin 7. elemanının toplamı
                    textBox130.Text = Convert.ToString(x9 + x25); // Birinci 4x4 lük matrisin 8. elemanı ile İkinci 4x4 lük matrisin 8. elemanının toplamı
                    textBox128.Text = Convert.ToString(x10 + x26); // Birinci 4x4 lük matrisin 9. elemanı ile İkinci 4x4 lük matrisin 9. elemanının toplamı
                    textBox127.Text = Convert.ToString(x11 + x27); // Birinci 4x4 lük matrisin 10. elemanı ile İkinci 4x4 lük matrisin 10. elemanının toplamı
                    textBox126.Text = Convert.ToString(x12 + x28); // Birinci 4x4 lük matrisin 11. elemanı ile İkinci 4x4 lük matrisin 11. elemanının toplamı
                    textBox125.Text = Convert.ToString(x13 + x29); // Birinci 4x4 lük matrisin 12. elemanı ile İkinci 4x4 lük matrisin 12. elemanının toplamı
                    textBox123.Text = Convert.ToString(x14 + x30); // Birinci 4x4 lük matrisin 13. elemanı ile İkinci 4x4 lük matrisin 13. elemanının toplamı
                    textBox122.Text = Convert.ToString(x15 + x31); // Birinci 4x4 lük matrisin 14. elemanı ile İkinci 4x4 lük matrisin 14. elemanının toplamı
                    textBox121.Text = Convert.ToString(x16 + x32); // Birinci 4x4 lük matrisin 15. elemanı ile İkinci 4x4 lük matrisin 15. elemanının toplamı
                    textBox120.Text = Convert.ToString(x17 + x33); // Birinci 4x4 lük matrisin 16. elemanı ile İkinci 4x4 lük matrisin 16. elemanının toplamı
                }
               
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fark işlemini yapmak için lütfen tüm boyutları aynı seçiniz");

            if (panel1.Visible) // Eğer panel1 görünüyorsa
            {
                if (panel8.Visible)
                {
                    x2 = Convert.ToDouble(textBox2.Text); // Eğer panel8 görünüyorsa Birinci 2x2 lik matrisin 1. elemanını x2 değişkenine atadık 
                    x3 = Convert.ToDouble(textBox3.Text); // Birinci 2x2 lik matrisin 2. elemanını x3 değişkenine atadık
                    x4 = Convert.ToDouble(textBox4.Text); // Birinci 2x2 lik matrisin 3.elemanını x4 değişkenine atadık
                    x5 = Convert.ToDouble(textBox5.Text); // Birinci 2x2 lik matrisin 4.elemanını x5 değişkenine atadık
                    x6 = Convert.ToDouble(textBox111.Text); // İkinci 2x2 lik matrisin 1.elemanını x6 değişkenine atadık
                    x7 = Convert.ToDouble(textBox110.Text); // İkinci 2x2 lik matrisin 2.elemanını x7 değişkenine atadık
                    x8 = Convert.ToDouble(textBox113.Text); // İkinci 2x2 lik matrisin 3.elemanını x8 değişkenine atadık
                    x9 = Convert.ToDouble(textBox112.Text); // İkinci 2x2 lik matrisin 4.elemanını x9 değişkenine atadık
                    textBox35.Text = Convert.ToString(x2 - x6); // Birinci 2x2 lik matrisin 1. elemanı ile İkinci 2x2 lik matrisin 1. elemanının farkı
                    textBox34.Text = Convert.ToString(x3 - x7); // Birinci 2x2 lik matrisin 2. elemanı ile İkinci 2x2 lik matrisin 2. elemanının farkı
                    textBox37.Text = Convert.ToString(x4 - x8); // Birinci 2x2 lik matrisin 3. elemanı ile İkinci 2x2 lik matrisin 3. elemanının farkı
                    textBox36.Text = Convert.ToString(x5 - x9); // Birinci 2x2 lik matrisin 4. elemanı ile İkinci 2x2 lik matrisin 4. elemanının farkı
                }
                

            }
            if (panel2.Visible) // Eğer panel2 görünüyorsa
            {
                if (panel7.Visible)
                {
                    x2 = Convert.ToDouble(textBox6.Text); // Eğer panel7 görünüyorsa Birinci 3x3 lük matrisin 1. elemanını x2 değişkenine atadık
                    x3 = Convert.ToDouble(textBox7.Text); // Birinci 3x3 lük matrisin 2. elemanını x3 değişkenine atadık
                    x4 = Convert.ToDouble(textBox8.Text); // Birinci 3x3 lük matrisin 3. elemanını x4 değişkenine atadık
                    x5 = Convert.ToDouble(textBox9.Text); // Birinci 3x3 lük matrisin 4. elemanını x5 değişkenine atadık
                    x6 = Convert.ToDouble(textBox10.Text); // Birinci 3x3 lük matrisin 5. elemanını x6 değişkenine atadık
                    x7 = Convert.ToDouble(textBox11.Text); // Birinci 3x3 lük matrisin 6. elemanını x7 değişkenine atadık
                    x8 = Convert.ToDouble(textBox12.Text); // Birinci 3x3 lük matrisin 7. elemanını x8 değişkenine atadık
                    x9 = Convert.ToDouble(textBox13.Text); // Birinci 3x3 lük matrisin 8. elemanını x9 değişkenine atadık
                    x10 = Convert.ToDouble(textBox14.Text); // Birinci 3x3 lük matrisin 9. elemanını x10 değişkenine atadık
                    x11 = Convert.ToDouble(textBox109.Text); // İkinci 3x3 lük matrisin 1. elemanını x11 değişkenine atadık
                    x12 = Convert.ToDouble(textBox108.Text); // İkinci 3x3 lük matrisin 2. elemanını x12 değişkenine atadık
                    x13 = Convert.ToDouble(textBox107.Text); // İkinci 3x3 lük matrisin 3. elemanını x13 değişkenine atadık
                    x14 = Convert.ToDouble(textBox106.Text); // İkinci 3x3 lük matrisin 4. elemanını x14 değişkenine atadık
                    x15 = Convert.ToDouble(textBox105.Text); // İkinci 3x3 lük matrisin 5. elemanını x15 değişkenine atadık
                    x16 = Convert.ToDouble(textBox104.Text); // İkinci 3x3 lük matrisin 6. elemanını x16 değişkenine atadık
                    x17 = Convert.ToDouble(textBox103.Text); // İkinci 3x3 lük matrisin 7. elemanını x17 değişkenine atadık
                    x18 = Convert.ToDouble(textBox102.Text); // İkinci 3x3 lük matrisin 8. elemanını x18 değişkenine atadık
                    x19 = Convert.ToDouble(textBox101.Text); // İkinci 3x3 lük matrisin 9. elemanını x19 değişkenine atadık
                    textBox46.Text = Convert.ToString(x2 - x11); // Birinci 3x3 lük matrisin 1. elemanı ile İkinci 3x3 lük matrisin 1. elemanının farkı
                    textBox45.Text = Convert.ToString(x3 - x12); // Birinci 3x3 lük matrisin 2. elemanı ile İkinci 3x3 lük matrisin 2. elemanının farkı
                    textBox44.Text = Convert.ToString(x4 - x13); // Birinci 3x3 lük matrisin 3. elemanı ile İkinci 3x3 lük matrisin 3. elemanının farkı
                    textBox43.Text = Convert.ToString(x5 - x14); // Birinci 3x3 lük matrisin 4. elemanı ile İkinci 3x3 lük matrisin 4. elemanının farkı
                    textBox42.Text = Convert.ToString(x6 - x15); // Birinci 3x3 lük matrisin 5. elemanı ile İkinci 3x3 lük matrisin 5. elemanının farkı
                    textBox41.Text = Convert.ToString(x7 - x16); // Birinci 3x3 lük matrisin 6. elemanı ile İkinci 3x3 lük matrisin 6. elemanının farkı
                    textBox40.Text = Convert.ToString(x8 - x17); // Birinci 3x3 lük matrisin 7. elemanı ile İkinci 3x3 lük matrisin 7. elemanının farkı
                    textBox39.Text = Convert.ToString(x9 - x18); // Birinci 3x3 lük matrisin 8. elemanı ile İkinci 3x3 lük matrisin 8. elemanının farkı
                    textBox38.Text = Convert.ToString(x10 - x19); // Birinci 3x3 lük matrisin 9. elemanı ile İkinci 3x3 lük matrisin 9. elemanının farkı

                }
                
            }
            if (panel3.Visible) // Eğer panel3 görünüyorsa 
            {
                if (panel6.Visible)
                {
                    x2 = Convert.ToDouble(textBox15.Text); // Eğer panel6 görünüyorsa Birinci 4x4 lük matrisin 1. elemanını x2 değişkenine atadık
                    x3 = Convert.ToDouble(textBox16.Text); // Birinci 4x4 lük matrisin 2. elemanını x3 değişkenine atadık
                    x4 = Convert.ToDouble(textBox17.Text); // Birinci 4x4 lük matrisin 3. elemanını x4 değişkenine atadık
                    x5 = Convert.ToDouble(textBox18.Text); // Birinci 4x4 lük matrisin 4. elemanını x5 değişkenine atadık
                    x6 = Convert.ToDouble(textBox19.Text); // Birinci 4x4 lük matrisin 5. elemanını x6 değişkenine atadık
                    x7 = Convert.ToDouble(textBox20.Text); // Birinci 4x4 lük matrisin 6. elemanını x7 değişkenine atadık
                    x8 = Convert.ToDouble(textBox21.Text); // Birinci 4x4 lük matrisin 7. elemanını x8 değişkenine atadık
                    x9 = Convert.ToDouble(textBox22.Text); // Birinci 4x4 lük matrisin 8. elemanını x9 değişkenine atadık
                    x10 = Convert.ToDouble(textBox23.Text); // Birinci 4x4 lük matrisin 9. elemanını x10 değişkenine atadık 
                    x11 = Convert.ToDouble(textBox24.Text); // Birinci 4x4 lük matrisin 10. elemanını x11 değişkenine atadık
                    x12 = Convert.ToDouble(textBox25.Text); // Birinci 4x4 lük matrisin 11. elemanını x12 değişkenine atadık
                    x13 = Convert.ToDouble(textBox26.Text); // Birinci 4x4 lük matrisin 12. elemanını x13 değişkenine atadık
                    x14 = Convert.ToDouble(textBox27.Text); // Birinci 4x4 lük matrisin 13. elemanını x14 değişkenine atadık
                    x15 = Convert.ToDouble(textBox28.Text); // Birinci 4x4 lük matrisin 14. elemanını x15 değişkenine atadık
                    x16 = Convert.ToDouble(textBox29.Text); // Birinci 4x4 lük matrisin 15. elemanını x16 değişkenine atadık
                    x17 = Convert.ToDouble(textBox30.Text); // Birinci 4x4 lük matrisin 16. elemanını x17 değişkenine atadık
                    x18 = Convert.ToDouble(textBox100.Text); // İkinci 4x4 lük matrisin 1. elemanını x18 değişkenine atadık
                    x19 = Convert.ToDouble(textBox99.Text); // İkinci 4x4 lük matrisin 2. elemanını x19 değişkenine atadık
                    x20 = Convert.ToDouble(textBox98.Text); // İkinci 4x4 lük matrisin 3. elemanını x20 değişkenine atadık
                    x21 = Convert.ToDouble(textBox97.Text); // İkinci 4x4 lük matrisin 4. elemanını x21 değişkenine atadık
                    x22 = Convert.ToDouble(textBox96.Text); // İkinci 4x4 lük matrisin 5. elemanını x22 değişkenine atadık
                    x23 = Convert.ToDouble(textBox95.Text); // İkinci 4x4 lük matrisin 6. elemanını x23 değişkenine atadık
                    x24 = Convert.ToDouble(textBox94.Text); // İkinci 4x4 lük matrisin 7. elemanını x24 değişkenine atadık
                    x25 = Convert.ToDouble(textBox93.Text); // İkinci 4x4 lük matrisin 8. elemanını x25 değişkenine atadık
                    x26 = Convert.ToDouble(textBox92.Text); // İkinci 4x4 lük matrisin 9. elemanını x26 değişkenine atadık
                    x27 = Convert.ToDouble(textBox91.Text); // İkinci 4x4 lük matrisin 10. elemanını x27 değişkenine atadık
                    x28 = Convert.ToDouble(textBox90.Text); // İkinci 4x4 lük matrisin 11. elemanını x28 değişkenine atadık
                    x29 = Convert.ToDouble(textBox89.Text); // İkinci 4x4 lük matrisin 12. elemanını x29 değişkenine atadık
                    x30 = Convert.ToDouble(textBox88.Text); // İkinci 4x4 lük matrisin 13. elemanını x30 değişkenine atadık
                    x31 = Convert.ToDouble(textBox87.Text); // İkinci 4x4 lük matrisin 14. elemanını x31 değişkenine atadık
                    x32 = Convert.ToDouble(textBox86.Text); // İkinci 4x4 lük matrisin 15. elemanını x32 değişkenine atadık
                    x33 = Convert.ToDouble(textBox85.Text); // İkinci 4x4 lük matrisin 16. elemanını x33 değişkenine atadık
                    textBox138.Text = Convert.ToString(x2 - x18); // Birinci 4x4 lük matrisin 1. elemanı ile İkinci 4x4 lük matrisin 1. elemanının farkı
                    textBox137.Text = Convert.ToString(x3 - x19); // Birinci 4x4 lük matrisin 2. elemanı ile İkinci 4x4 lük matrisin 2. elemanının farkı
                    textBox136.Text = Convert.ToString(x4 - x20); // Birinci 4x4 lük matrisin 3. elemanı ile İkinci 4x4 lük matrisin 3. elemanının farkı
                    textBox135.Text = Convert.ToString(x5 - x21); // Birinci 4x4 lük matrisin 4. elemanı ile İkinci 4x4 lük matrisin 4. elemanının farkı
                    textBox133.Text = Convert.ToString(x6 - x22); // Birinci 4x4 lük matrisin 5. elemanı ile İkinci 4x4 lük matrisin 5. elemanının farkı
                    textBox132.Text = Convert.ToString(x7 - x23); // Birinci 4x4 lük matrisin 6. elemanı ile İkinci 4x4 lük matrisin 6. elemanının farkı
                    textBox131.Text = Convert.ToString(x8 - x24); // Birinci 4x4 lük matrisin 7. elemanı ile İkinci 4x4 lük matrisin 7. elemanının farkı
                    textBox130.Text = Convert.ToString(x9 - x25); // Birinci 4x4 lük matrisin 8. elemanı ile İkinci 4x4 lük matrisin 8. elemanının farkı
                    textBox128.Text = Convert.ToString(x10 - x26); // Birinci 4x4 lük matrisin 9. elemanı ile İkinci 4x4 lük matrisin 9. elemanının farkı
                    textBox127.Text = Convert.ToString(x11 - x27); // Birinci 4x4 lük matrisin 10. elemanı ile İkinci 4x4 lük matrisin 10. elemanının farkı
                    textBox126.Text = Convert.ToString(x12 - x28); // Birinci 4x4 lük matrisin 11. elemanı ile İkinci 4x4 lük matrisin 11. elemanının farkı
                    textBox125.Text = Convert.ToString(x13 - x29); // Birinci 4x4 lük matrisin 12. elemanı ile İkinci 4x4 lük matrisin 12. elemanının farkı
                    textBox123.Text = Convert.ToString(x14 - x30); // Birinci 4x4 lük matrisin 13. elemanı ile İkinci 4x4 lük matrisin 13. elemanının farkı
                    textBox122.Text = Convert.ToString(x15 - x31); // Birinci 4x4 lük matrisin 14. elemanı ile İkinci 4x4 lük matrisin 14. elemanının farkı
                    textBox121.Text = Convert.ToString(x16 - x32); // Birinci 4x4 lük matrisin 15. elemanı ile İkinci 4x4 lük matrisin 15. elemanının farkı
                    textBox120.Text = Convert.ToString(x17 - x33); // Birinci 4x4 lük matrisin 16. elemanı ile İkinci 4x4 lük matrisin 16. elemanının farkı
                }
                
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çarpama işlemini yapmak için lütfen tüm boyutları aynı seçiniz.");

            if (panel1.Visible) // Eğer panel1 görünüyorsa
            {
                if (panel8.Visible)
                {
                    x2 = Convert.ToDouble(textBox2.Text); // Eğer panel8 görünüyorsa Birinci 2x2 lik matrisin 1. elemanını x2 değişkenine atadık
                    x3 = Convert.ToDouble(textBox3.Text); // Birinci 2x2 lik matrisin 2. elemanını x3 değişkenine atadık
                    x4 = Convert.ToDouble(textBox4.Text); // Birinci 2x2 lik matrisin 3. elemanını x4 değişkenine atadık
                    x5 = Convert.ToDouble(textBox5.Text); // Birinci 2x2 lik matrisin 4. elemanını x5 değişkenine atadık
                    x6 = Convert.ToDouble(textBox111.Text); // İkinci 2x2 lik matrisin 1. elemanını x6 değişkenine atadık
                    x7 = Convert.ToDouble(textBox110.Text); // İkinci 2x2 lik matrisin 2. elemanını x7 değişkenine atadık
                    x8 = Convert.ToDouble(textBox113.Text); // İkinci 2x2 lik matrisin 3. elemanını x8 değişkenine atadık
                    x9 = Convert.ToDouble(textBox112.Text); // İkinci 2x2 lik matrisin 4. elemanını x9 değişkenine atadık
                    textBox35.Text = Convert.ToString(x2 * x6 + x3 * x8); // Üçüncü 2x2 lik matrisin 1. elemanı
                    textBox34.Text = Convert.ToString(x2 * x7 + x3 * x9); // Üçüncü 2x2 lik matrisin 2. elemanı
                    textBox37.Text = Convert.ToString(x4 * x6 + x5 * x8); // Üçüncü 2x2 lik matrisin 3. elemanı 
                    textBox36.Text = Convert.ToString(x4 * x7 + x5 * x9); // Üçüncü 2x2 lik matrisin 4. elemanı
                }
                

            }
            if (panel2.Visible) // Eğer panel2 görünüyorsa 
            {
                if (panel7.Visible)
                {
                    x2 = Convert.ToDouble(textBox6.Text); // Eğer panel7 görünüyorsa Birinci 3x3 lük matrisin 1. elemanını x2 değişkenine atadık
                    x3 = Convert.ToDouble(textBox7.Text); // Birinci 3x3 lük matrisin 2. elemanını x3 değişkenine atadık
                    x4 = Convert.ToDouble(textBox8.Text); // Birinci 3x3 lük matrisin 3. elemanını x4 değişkenine atadık
                    x5 = Convert.ToDouble(textBox9.Text); // Birinci 3x3 lük matrisin 4. elemanını x5 değişkenine atadık
                    x6 = Convert.ToDouble(textBox10.Text); // Birinci 3x3 lük matrisin 5. elemanını x6 değişkenine atadık
                    x7 = Convert.ToDouble(textBox11.Text); // Birinci 3x3 lük matrisin 6. elemanını x7 değişkenine atadık
                    x8 = Convert.ToDouble(textBox12.Text); // Birinci 3x3 lük matrisin 7. elemanını x8 değişkenine atadık
                    x9 = Convert.ToDouble(textBox13.Text); // Birinci 3x3 lük matrisin 8. elemanını x9 değişkenine atadık
                    x10 = Convert.ToDouble(textBox14.Text); // Birinci 3x3 lük matrisin 9. elemanını x10 değişkenine atadık
                    x11 = Convert.ToDouble(textBox109.Text); // İkinci 3x3 lük matrisin 1. elemanını x11 değişkenine atadık
                    x12 = Convert.ToDouble(textBox108.Text); // İkinci 3x3 lük matrisin 2. elemanını x12 değişkenine atadık
                    x13 = Convert.ToDouble(textBox107.Text); // İkinci 3x3 lük matrisin 3. elemanını x13 değişkenine atadık
                    x14 = Convert.ToDouble(textBox106.Text); // İkinci 3x3 lük matrisin 4. elemanını x14 değişkenine atadık
                    x15 = Convert.ToDouble(textBox105.Text); // İkinci 3x3 lük matrisin 5. elemanını x15 değişkenine atadık
                    x16 = Convert.ToDouble(textBox104.Text); // İkinci 3x3 lük matrisin 6. elemanını x16 değişkenine atadık
                    x17 = Convert.ToDouble(textBox103.Text); // İkinci 3x3 lük matrisin 7. elemanını x17 değişkenine atadık
                    x18 = Convert.ToDouble(textBox102.Text); // İkinci 3x3 lük matrisin 8. elemanını x18 değişkenine atadık
                    x19 = Convert.ToDouble(textBox101.Text); // İkinci 3x3 lük matrisin 9. elemanını x19 değişkenine atadık
                    textBox46.Text = Convert.ToString(x2 * x11 + x3 * x14 + x4 * x17); // Üçüncü 3x3 lük matrisin 1. elemanı
                    textBox45.Text = Convert.ToString(x2 * x12 + x3 * x15 + x4 * x18); // Üçüncü 3x3 lük matrisin 2. elemanı
                    textBox44.Text = Convert.ToString(x2 * x13 + x3 * x16 + x4 * x19); // Üçüncü 3x3 lük matrisin 3. elemanı
                    textBox43.Text = Convert.ToString(x5 * x11 + x6 * x14 + x7 * x17); // Üçüncü 3x3 lük matrisin 4. elemanı
                    textBox42.Text = Convert.ToString(x5 * x12 + x6 * x15 + x7 * x18); // Üçüncü 3x3 lük matrisin 5. elemanı
                    textBox41.Text = Convert.ToString(x5 * x13 + x6 * x16 + x7 * x19); // Üçüncü 3x3 lük matrisin 6. elemanı
                    textBox40.Text = Convert.ToString(x8 * x11 + x9 * x14 + x10 * x17); // Üçüncü 3x3 lük matrisin 7. elemanı
                    textBox39.Text = Convert.ToString(x8 * x12 + x9 * x15 + x10 * x18); // Üçüncü 3x3 lük matrisin 8. elemanı
                    textBox38.Text = Convert.ToString(x8 * x13 + x9 * x16 + x10 * x19); // Üçüncü 3x3 lük matrisin 9. elemanı

                }
               
            }
            if (panel3.Visible) // Eğer panel3 görünüyorsa
            {
                if (panel6.Visible)
                {
                    x2 = Convert.ToDouble(textBox15.Text); // Eğer panel6 görünüyorsa Birinci 4x4 lük matrisin 1. elemanını x2 değişkenine atadık
                    x3 = Convert.ToDouble(textBox16.Text); // Birinci 4x4 lük matrisin 2. elemanını x3 değişkenine atadık
                    x4 = Convert.ToDouble(textBox17.Text); // Birinci 4x4 lük matrisin 3. elemanını x4 değişkenine atadık
                    x5 = Convert.ToDouble(textBox18.Text); // Birinci 4x4 lük matrisin 4. elemanını x5 değişkenine atadık
                    x6 = Convert.ToDouble(textBox19.Text); // Birinci 4x4 lük matrisin 5. elemanını x6 değişkenine atadık
                    x7 = Convert.ToDouble(textBox20.Text); // Birinci 4x4 lük matrisin 6. elemanını x7 değişkenine atadık
                    x8 = Convert.ToDouble(textBox21.Text); // Birinci 4x4 lük matrisin 7. elemanını x8 değişkenine atadık
                    x9 = Convert.ToDouble(textBox22.Text); // Birinci 4x4 lük matrisin 8. elemanını x9 değişkenine atadık
                    x10 = Convert.ToDouble(textBox23.Text); // Birinci 4x4 lük matrisin 9. elemanını x10 değişkenine atadık
                    x11 = Convert.ToDouble(textBox24.Text); // Birinci 4x4 lük matrisin 10. elemanını x11 değişkenine atadık
                    x12 = Convert.ToDouble(textBox25.Text); // Birinci 4x4 lük matrisin 11. elemanını x12 değişkenine atadık
                    x13 = Convert.ToDouble(textBox26.Text); // Birinci 4x4 lük matrisin 12. elemanını x13 değişkenine atadık
                    x14 = Convert.ToDouble(textBox27.Text); // Birinci 4x4 lük matrisin 13. elemanını x14 değişkenine atadık
                    x15 = Convert.ToDouble(textBox28.Text); // Birinci 4x4 lük matrisin 14. elemanını x15 değişkenine atadık
                    x16 = Convert.ToDouble(textBox29.Text); // Birinci 4x4 lük matrisin 15. elemanını x16 değişkenine atadık
                    x17 = Convert.ToDouble(textBox30.Text); // Birinci 4x4 lük matrisin 16. elemanını x17 değişkenine atadık
                    x18 = Convert.ToDouble(textBox100.Text); // İkinci 4x4 lük matrisin 1. elemanını x18 değişkenine atadık
                    x19 = Convert.ToDouble(textBox99.Text); // İkinci 4x4 lük matrisin 2. elemanını x19 değişkenine atadık
                    x20 = Convert.ToDouble(textBox98.Text); // İkinci 4x4 lük matrisin 3. elemanını x20 değişkenine atadık
                    x21 = Convert.ToDouble(textBox97.Text); // İkinci 4x4 lük matrisin 4. elemanını x21 değişkenine atadık
                    x22 = Convert.ToDouble(textBox96.Text); // İkinci 4x4 lük matrisin 5. elemanını x22 değişkenine atadık 
                    x23 = Convert.ToDouble(textBox95.Text); // İkinci 4x4 lük matrisin 6. elemanını x23 değişkenine atadık
                    x24 = Convert.ToDouble(textBox94.Text); // İkinci 4x4 lük matrisin 7. elemanını x24 değişkenine atadık
                    x25 = Convert.ToDouble(textBox93.Text); // İkinci 4x4 lük matrisin 8. elemanını x25 değişkenine atadık
                    x26 = Convert.ToDouble(textBox92.Text); // İkinci 4x4 lük matrisin 9. elemanını x26 değişkenine atadık
                    x27 = Convert.ToDouble(textBox91.Text); // İkinci 4x4 lük matrisin 10. elemanını x27 değişkenine atadık
                    x28 = Convert.ToDouble(textBox90.Text); // İkinci 4x4 lük matrisin 11. elemanını x28 değişkenine atadık
                    x29 = Convert.ToDouble(textBox89.Text); // İkinci 4x4 lük matrisin 12. elemanını x29 değişkenine atadık
                    x30 = Convert.ToDouble(textBox88.Text); // İkinci 4x4 lük matrisin 13. elemanını x30 değişkenine atadık
                    x31 = Convert.ToDouble(textBox87.Text); // İkinci 4x4 lük matrisin 14. elemanını x31 değişkenine atadık
                    x32 = Convert.ToDouble(textBox86.Text); // İkinci 4x4 lük matrisin 15. elemanını x32 değişkenine atadık
                    x33 = Convert.ToDouble(textBox85.Text); // İkinci 4x4 lük matrisin 16. elemanını x33 değişkenine atadık
                    textBox138.Text = Convert.ToString(x2 * x18 + x3 * x22 + x4 * x26 + x5 * x30); // Üçüncü 4x4 lük matrisin 1. elemanı
                    textBox137.Text = Convert.ToString(x2 * x19 + x3 * x23 + x4 * x27 + x5 * x31); // Üçüncü 4x4 lük matrisin 2. elemanı
                    textBox136.Text = Convert.ToString(x2 * x20 + x3 * x24 + x4 * x28 + x5 * x32); // Üçüncü 4x4 lük matrisin 3. elemanı
                    textBox135.Text = Convert.ToString(x2 * x21 + x3 * x25 + x4 * x29 + x5 * x33); // Üçüncü 4x4 lük matrisin 4. elemanı
                    textBox133.Text = Convert.ToString(x6 * x18 + x7 * x22 + x8 * x26 + x9 * x30); // Üçüncü 4x4 lük matrisin 5. elemanı
                    textBox132.Text = Convert.ToString(x6 * x19 + x7 * x23 + x8 * x27 + x9 * x31); // Üçüncü 4x4 lük matrisin 6. elemanı
                    textBox131.Text = Convert.ToString(x6 * x20 + x7 * x24 + x8 * x28 + x9 * x32); // Üçüncü 4x4 lük matrisin 7. elemanı
                    textBox130.Text = Convert.ToString(x6 * x21 + x7 * x25 + x8 * x29 + x9 * x33); // Üçüncü 4x4 lük matrisin 8. elemanı
                    textBox128.Text = Convert.ToString(x10 * x18 + x11 * x22 + x12 * x26 + x13 * x30); // Üçüncü 4x4 lük matrisin 9. elemanı
                    textBox127.Text = Convert.ToString(x10 * x19 + x11 * x23 + x12 * x27 + x13 * x31); // Üçüncü 4x4 lük matrisin 10. elemanı
                    textBox126.Text = Convert.ToString(x10 * x20 + x11 * x24 + x12 * x28 + x13 * x32); // Üçüncü 4x4 lük matrisin 11. elemanı
                    textBox125.Text = Convert.ToString(x10 * x21 + x11 * x25 + x12 * x29 + x13 * x33); // Üçüncü 4x4 lük matrisin 12. elemanı
                    textBox123.Text = Convert.ToString(x14 * x18 + x15 * x22 + x16 * x26 + x17 * x30); // Üçüncü 4x4 lük matrisin 13. elemanı
                    textBox122.Text = Convert.ToString(x14 * x19 + x15 * x23 + x16 * x27 + x17 * x31); // Üçüncü 4x4 lük matrisin 14. elemanı
                    textBox121.Text = Convert.ToString(x14 * x20 + x15 * x24 + x16 * x28 + x17 * x32); // Üçüncü 4x4 lük matrisin 15. elemanı
                    textBox120.Text = Convert.ToString(x14 * x21 + x15 * x25 + x16 * x29 + x17 * x33); // Üçüncü 4x4 lük matrisin 16. elemanı
                }
              
            }
        }

        // İkinci matrisin 2x2 lik matris tablosunu gösteren butonun kod bloğu
        private void button63_Click(object sender, EventArgs e)
        {
            if (panel6.Visible || panel7.Visible)
            {
                panel6.Visible = false; // Eğer panel6 veya panel7 görünüyorsa panel6 nın görünürlüğünü kapat
                panel7.Visible = false; // panel7 nin görünürlüğünü kapat
                panel8.Visible = true; // panel8 in görünürlüğünü aç
                button63.Enabled = false; // button63 ün aktifliğini kapat
                button62.Enabled = true; // button62 nin aktifliğini aç
                button60.Enabled = true; // button60 ın aktifliğini aç
            }

        }

        // İkinci matrisin 3x3 lük matris tablosunu gösteren butonun kod bloğu
        private void button62_Click(object sender, EventArgs e)
        {
            if (panel6.Visible || panel8.Visible)
            {
                panel6.Visible = false; // Eğer panel6 veya panel8 görünüyorsa panel6 nın görünürlüğünü kapat
                panel8.Visible = false; // panel8 in görünürlüğünü kapat
                panel7.Visible = true; // panel7 nin görünürlüğünü aç
                button63.Enabled = true; // button63 ün aktifliğini aç
                button62.Enabled = false; // button62 nin aktifliğini kapat
                button60.Enabled = true; // button60 ın aktifliğini aç
            }
        }

        // İkinci matrisin 4x4 lük matris tablosunu gösteren butonun kod bloğu
        private void button60_Click(object sender, EventArgs e)
        {
            if (panel7.Visible || panel8.Visible)
            {
                panel7.Visible = false; // Eğer panel7 veya panel8 görünüyorsa panel7 nin görünürlüğünü kapat
                panel8.Visible = false; // panel8 in görünürlüğünü kapat
                panel6.Visible = true; // panel6 nın görünürlüğünü aç
                button63.Enabled = true; // button63 ün aktifliğini aç
                button62.Enabled = true; // button62 nin aktifliğini aç
                button60.Enabled = false; // button60 ın aktifliğini kapat
            }

        }

        // Birinci matrisin 2x2 lik matris tablosunu gösteren butonun kod bloğu
        private void button48_Click(object sender, EventArgs e)
        {
            if (panel2.Visible || panel3.Visible)
            {
                panel2.Visible = false; // Eğer panel2 veya panel3 görünüyorsa panel2 nin görünürlüğünü kapat
                panel3.Visible = false; // panel3 ün görünürlüğünü kapat 
                panel1.Visible = true; // panel1 in görünürlüğünü aç
                button48.Enabled = false; // button48 in aktifliğini kapat
                button49.Enabled = true; // button49 un aktifliğini aç
                button41.Enabled = true; // button41 in aktifliğini aç
            }
        }

        // Birinci matrisin 3x3 lük matris izini hesaplatan butonun kod bloğu
        private void button55_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(textBox6.Text); // Birinci 3x3 lük matrisin 1. elemanını x1 değişkenine atadık 
            x2 = Convert.ToDouble(textBox10.Text); // Birinci 3x3 lük matrisin 5. elemanını x2 değişkenine atadık
            x3 = Convert.ToDouble(textBox14.Text); // Birinci 3x3 lük matrisin 9. elemanını x3 değişkenine atadık
            textBox57.Text = Convert.ToString(x1 + x2 + x3); // Birinci 3x3 lük matrisin matris izini button55 in yanına yazdırdık
        }

        // Birinci matrisin 4x4 lük matris izini hesaplatan butonun kod bloğu
        private void button56_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(textBox15.Text); // Birinci 4x4 lük matrisin 1. elemanını x1 değişkenine atadık 
            x2 = Convert.ToDouble(textBox20.Text); // Birinci 4x4 lük matrisin 6. elemanını x2 değişkenine atadık
            x3 = Convert.ToDouble(textBox25.Text); // Birinci 4x4 lük matrisin 11. elemanını x3 değişkenine atadık
            x4 = Convert.ToDouble(textBox30.Text); // Birinci 4x4 lük matrisin 16. elemanını x4 değişkenine atadık
            textBox58.Text = Convert.ToString(x1 + x2 + x3 + x4); // Birinci 4x4 lük matrisin matris izini button56 nın yanına yazdırdık
        }
        // Matrislerin elemanlarını sıfırlayan algoritmayı içeren kod bloğu
        private void textclear(Control ctl) // textclear adında kapalı ve geri değer döndürmeyen bir metot tanımladık
        {
            foreach (Control item in ctl.Controls) // foreach döngüsüyle Control tipinde item değişkeni kullandık ve ctl içerisinde adım adım döngüyü tekrarladık
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "0"; // Eğer eleman textbox ise textbox ın yazısını 0 yap dedik
                }
            }
        }

        // Birinci matrisin elemanlarını sıfırlayan butonun kod bloğu
        private void button58_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                textclear(panel1); // Eğer panel1 görünüyorsa panel1 in elemanlarını sıfırla dedik
            }
            if (panel2.Visible)
            {
                textclear(panel2); // Eğer panel2 görünüyorsa panel2 nin elemanlarını sıfırla dedik
            }
            if (panel3.Visible)
            {
                textclear(panel3); // Eğer panel3 görünüyorsa panel3 ün elemanlarını sıfırla dedik
            }
        }

        // Birinci matrisin 2x2 lik matris tersini hesaplatan butonun kod bloğu
        private void button61_Click(object sender, EventArgs e)
        {
            x2 = Convert.ToDouble(textBox2.Text); // Birinci 2x2 lik matrisin 1. elemanını x2 değişkenine atadık
            x3 = Convert.ToDouble(textBox3.Text); // Birinci 2x2 lik matrisin 2. elemanını x3 değişkenine atadık
            x4 = Convert.ToDouble(textBox4.Text); // Birinci 2x2 lik matrisin 3. elemanını x4 değişkenine atadık
            x5 = Convert.ToDouble(textBox5.Text); // Birinci 2x2 lik matrisin 4. elemanını x5 değişkenine atadık
            textBox2.Text = Convert.ToString(x5 / (x2 * x5 - x4 * x3)); // Ek matris / determinant
            textBox3.Text = Convert.ToString(-x3 / (x2 * x5 - x4 * x3)); // Ek matris / determinant
            textBox4.Text = Convert.ToString(-x4 / (x2 * x5 - x4 * x3)); // Ek matris / determinant
            textBox5.Text = Convert.ToString(x2 / (x2 * x5 - x4 * x3)); // Ek matris / determinant
        }

        // Birinci matrisin 3x3 lük matris tersini hesaplatan butonun kod bloğu
        private void button53_Click(object sender, EventArgs e)
        {
            x2 = Convert.ToDouble(textBox6.Text); // Birinci 3x3 lük matrisin 1. elemanını x2 değişkenine atadık
            x3 = Convert.ToDouble(textBox7.Text); // Birinci 3x3 lük matrisin 2. elemanını x3 değişkenine atadık
            x4 = Convert.ToDouble(textBox8.Text); // Birinci 3x3 lük matrisin 3. elemanını x4 değişkenine atadık
            x5 = Convert.ToDouble(textBox9.Text); // Birinci 3x3 lük matrisin 4. elemanını x5 değişkenine atadık
            x6 = Convert.ToDouble(textBox10.Text); // Birinci 3x3 lük matrisin 5. elemanını x6 değişkenine atadık
            x7 = Convert.ToDouble(textBox11.Text); // Birinci 3x3 lük matrisin 6. elemanını x7 değişkenine atadık
            x8 = Convert.ToDouble(textBox12.Text); // Birinci 3x3 lük matrisin 7. elemanını x8 değişkenine atadık
            x9 = Convert.ToDouble(textBox13.Text); // Birinci 3x3 lük matrisin 8. elemanını x9 değişkenine atadık
            x10 = Convert.ToDouble(textBox14.Text); // Birinci 3x3 lük matrisin 9. elemanını x10 değişkenine atadık
            textBox6.Text = Convert.ToString(((x6 * x10) - (x9 * x7)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox7.Text = Convert.ToString(((x9 * x4) - (x3 * x10)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox8.Text = Convert.ToString(((x3 * x7) - (x6 * x4)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox9.Text = Convert.ToString(((x8 * x7) - (x5 * x10)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox10.Text = Convert.ToString(((x2 * x10) - (x8 * x4)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox11.Text = Convert.ToString(((x5 * x4) - (x2 * x7)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox12.Text = Convert.ToString(((x5 * x9) - (x8 * x6)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox13.Text = Convert.ToString(((x8 * x3) - (x2 * x9)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
            textBox14.Text = Convert.ToString(((x2 * x6) - (x5 * x3)) / ((x2 * (x6 * x10 - x9 * x7)) + (x3 * (x8 * x7 - x5 * x10)) + (x4 * (x5 * x9 - x8 * x6)))); // Ek matris / determinant
        }

        // Birinci matrisin 3x3 lük matris tablosunu gösteren butonun kod bloğu
        private void button49_Click(object sender, EventArgs e)
        {
            if (panel1.Visible || panel3.Visible)
            {
                panel1.Visible = false; // Eğer panel1 veya panel3 görünüyorsa panel1 in görünürlüğünü kapat
                panel3.Visible = false; // panel3 ün görünürlüğünü kapat
                panel2.Visible = true; // panel2 nin görünürlüğünü kapat
                button48.Enabled = true; // button48 in aktifliğini aç
                button49.Enabled = false; // button49 un aktifliğini kapat
                button41.Enabled = true; // button41 in aktifliğini aç
            }
        }
        // Birinci matrisin 4x4 lük matris tablosunu gösteren butonun kod bloğu
        private void button41_Click(object sender, EventArgs e)
        {
            if (panel1.Visible || panel2.Visible)
            {
                panel1.Visible = false; // Eğer panel1 veya panel2 görünüyorsa panel1 in görünürlüğünü kapat
                panel2.Visible = false; // panel2 nin görünürlüğünü kapat
                panel3.Visible = true; // panel3 ün görünürlüğünü aç
                button48.Enabled = true; // button48 in aktifliğini aç
                button49.Enabled = true; // button49 un aktifliğini aç
                button41.Enabled = false; // button41 in aktifliğini kapat
            }
        }
        // Birinci matrisin 2x2 lik matris izini hesaplatan butonun kod bloğu
        private void button54_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToDouble(textBox2.Text); // Birinci 2x2 lik matrisin 1. elemanını x1 değişkenine atadık
            x2 = Convert.ToDouble(textBox5.Text); // Birinci 2x2 lik matrisin 4. elemanını x2 değişkenine atadık
            textBox56.Text = Convert.ToString(x1 + x2); // Birinci 2x2 lik matrisin matris izini button54 ün yanına yazdırdık

        }


    }
}


