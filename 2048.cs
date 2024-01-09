using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class game2048 : Form
    {
        
        Random rnd = new Random();
        public game2048()
        {
            InitializeComponent();
           
            
            
        }
        private int p = 0;
        public void btnbasla_Click(object sender, EventArgs e)
        {
            if (p==0)
            {
             for (int i = 0; i < 2; i++)
            {
                p++ ;
                int newgame = rnd.Next(1, 17);

                Label[] oyunlar = { oyun1, oyun2, oyun3, oyun4, oyun5, oyun6, oyun7, oyun8, oyun9, oyun10, oyun11, oyun12, oyun13, oyun14, oyun15, oyun16 };

                oyunlar[newgame - 1].Text = "2";
                    oyunlar[newgame-1].BackColor = Color.White;
            }
            }
            else
            {
                MessageBox.Show("Oyun zaten başlatıldı!");
            }
        }

        public void game2048_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.S) s();
            else if (e.KeyCode == Keys.W) w();
            else if (e.KeyCode == Keys.A) a();
            else if (e.KeyCode == Keys.D) d();

        }
        public void s()
        {
            int a;
            int b = 0;
            int c = 0;
            Label[] oyunlar = { oyun1, oyun2, oyun3, oyun4, oyun5, oyun6, oyun7, oyun8, oyun9, oyun10, oyun11, oyun12, oyun13, oyun14, oyun15, oyun16 };

            int i = 0;
                while (i < 1)
                {
                    int newgame = rnd.Next(1, 17);

                    if (oyunlar[newgame - 1] != null)
                    {
                        oyunlar[newgame - 1].Text = "2";
                        i++;
                    }

                }
                for (int j = 1; j <= 16; j += 4)
                {
                    if (oyunlar[j] != null)
                    {
                        a = int.TryParse(oyunlar[j].Text, out int result) ? result : c;
                        b += a;
                        oyunlar[13-1].Text = b.ToString();

                    }
                }
                b = 0;

            }
        public void w()
        {
            int[] donusum = new int[17];
            Label[] oyunlar = { oyun1, oyun2, oyun3, oyun4, oyun5, oyun6, oyun7, oyun8, oyun9, oyun10, oyun11, oyun12, oyun13, oyun14, oyun15, oyun16 };

            for (int j = 0; j < oyunlar.Length; j++)
            {
                int nn;
                donusum[j] = int.TryParse(oyunlar[j].Text, out nn) ? nn : 0;
            }
            donusum[16] = 0;
            int m = 0;
            int h = 0;
            int z = 1;
            int g = 4;
            int cc = 0;
            for (int c = 0; c < 4; c++)
            {
                for (int i = h; i < g; i+=4)
                {
                    for (int j = cc; j < 3; j++)
                    {
                        if (donusum[i] > 0 && donusum[i] == donusum[i + 4])
                        {
                            donusum[i + 4] *= 2;
                            donusum[i] = 0;
                            i = 0;
                            i += h;
                            cc--;
                        }
                    }
                    m++;
                    if (m >= 16)
                    {
                        break;
                    }
                    if (m % 4 == 0)
                    {
                        h += 1;
                        g += 1;
                        z += 1;
                    }
                }

            }

            int[] sira1 = { donusum[0], donusum[4], donusum[8], donusum[12] };
            Array.Sort(sira1);
            Array.Reverse(sira1);   
            int[] sira2 = { donusum[1], donusum[5], donusum[9], donusum[13] };
            Array.Sort(sira2);
            Array.Reverse(sira2);
            int[] sira3 = { donusum[2], donusum[6], donusum[10], donusum[14] };
            Array.Sort(sira3);
            Array.Reverse(sira3);
            int[] sira4 = { donusum[3], donusum[7], donusum[11], donusum[15] };
            Array.Sort(sira4);
            Array.Reverse(sira4);
            m = 0; h = 0; g = 4;
            int zz = 0; int hh = 1;   int mm = 2;int ss = 3;
            for (int i = h; i < g; i++)
            {
                if (0 <= h && h < 4)
                {

                    oyunlar[z].Text = (sira1[i] == 0) ? "" : sira1[i].ToString();
                    zz += 4;

                }
                else if (4 <= h && h < 8)
                {
                    oyunlar[hh].Text = (sira2[i - 4] == 0) ? "" : sira2[i - 4].ToString();
                    hh += 4;
                }
                else if (8 <= h && h < 12)
                {
                    oyunlar[mm].Text = (sira3[i - 8] == 0) ? "" : sira3[i - 8].ToString();
                    mm += 4;
                }
                else if (12 <= h && h < 16)
                {
                    oyunlar[ss].Text = (sira4[i - 12] == 0) ? "" : sira4[i - 12].ToString();
                    ss += 4;
                }
                else
                {
                    break;
                }
                m++;
                if (m % 4 == 0)
                {
                    h += 4; g += 4;
                }

            }
            int ekle = rnd.Next(16);
            while (oyunlar[ekle].Text != "")
            {
                ekle = rnd.Next(16);
            }
            oyunlar[ekle].Text = "2";
        }

        public void a()
        {
            int[] donusum = new int[17];
            Label[] oyunlar = { oyun1, oyun2, oyun3, oyun4, oyun5, oyun6, oyun7, oyun8, oyun9, oyun10, oyun11, oyun12, oyun13, oyun14, oyun15, oyun16 };
            for (int j = 0; j < oyunlar.Length; j++)
            {
                int nn;
                donusum[j] = int.TryParse(oyunlar[j].Text, out nn) ? nn : 0;
            }
            donusum[16] = 0;
            int m = 0;
            int h = 0;
            int z = 1;
            int g = 4;
            int cc = 0;
            for (int c = 0; c < 4; c++)
            {
                for (int i = h; i < g; i++)
                {
                    for (int j = cc; j < 3; j++)
                    {
                        if (donusum[i] > 0 && donusum[i] == donusum[i + 1])
                        {
                            donusum[i + 1] *= 2;
                            donusum[i] = 0;
                            i = 0;
                            i += h;
                            cc--;
                        }
                    }
                    m++;
                    if (m >= 16)
                    {
                        break;
                    }
                    if (m % 4 == 0)
                    {
                        h += 4;
                        g += 4;
                        z += 4;
                    }
                }

            }
            
            int[] sira1 = { donusum[0], donusum[1], donusum[2], donusum[3] };
            Array.Sort(sira1);
            Array.Reverse(sira1);
            int[] sira2 = { donusum[4], donusum[5], donusum[6], donusum[7] };
            Array.Sort(sira2);
            Array.Reverse(sira2);
            int[] sira3 = { donusum[8], donusum[9], donusum[10], donusum[11] };
            Array.Sort(sira3);
            Array.Reverse(sira3);
            int[] sira4 = { donusum[12], donusum[13], donusum[14], donusum[15] };
            Array.Sort(sira4);
            Array.Reverse(sira4);
            m = 0;
            h = 0;
            g = 4;
            for (int i = h; i < g; i++)
            {
                if (0 <= h && h < 4)
                {

                    oyunlar[i].Text = (sira1[i] == 0) ? "" : sira1[i].ToString();

                }
                else if (4 <= h && h < 8)
                {
                    oyunlar[i].Text = (sira2[i - 4] == 0) ? "" : sira2[i - 4].ToString();
                }
                else if (8 <= h && h < 12)
                {
                    oyunlar[i].Text = (sira3[i - 8] == 0) ? "" : sira3[i - 8].ToString();
                }
                else if (12 <= h && h < 16)
                {
                    oyunlar[i].Text = (sira4[i - 12] == 0) ? "" : sira4[i - 12].ToString();
                }
                else
                {
                    break;
                }

                m++;
                if (m % 4 == 0)
                {
                    h += 4;
                    g += 4;
                }

            }
            int ekle = rnd.Next(16);
            while (oyunlar[ekle].Text != "")
            {
                ekle = rnd.Next(16);
            }
            oyunlar[ekle].Text = "2";
        }

        public void d()
        {
            int[] donusum = new int[17];
            Label[] oyunlar = { oyun1, oyun2, oyun3, oyun4, oyun5, oyun6, oyun7, oyun8, oyun9, oyun10, oyun11, oyun12, oyun13, oyun14, oyun15, oyun16 };
            for (int j = 0; j < oyunlar.Length; j++)
            {
                int nn;
                donusum[j] = int.TryParse(oyunlar[j].Text, out nn) ? nn : 0;
            }
            donusum[16] = 0;
            int m = 0;
            int h = 0;
            int z = 1;
            int g = 4;
            int cc = 0;
            for (int c = 0; c < 4; c++)
            {
                for (int i = h; i < g; i++)
                {
                    for (int j = cc; j < 3; j++)
                    {
                        if (donusum[i] > 0 && donusum[i] == donusum[i+1])
                        {
                            donusum[i+1] *= 2;
                            donusum[i] = 0;
                            i = 0;
                            i +=h;
                            cc --;
                        }
                    } 
                m++;
                if (m>=16)
                {
                    break;
                }
                if (m % 4 == 0)
                {
                    h += 4;
                    g += 4;
                    z += 4;
                }
                }
                
            }
               
            int[] sira1 = { donusum[0], donusum[1], donusum[2], donusum[3] };
            Array.Sort(sira1);
            int[] sira2 = { donusum[4], donusum[5], donusum[6], donusum[7] };
            Array.Sort(sira2);
            int[] sira3 = { donusum[8], donusum[9], donusum[10], donusum[11] };
            Array.Sort(sira3);
            int[] sira4 = { donusum[12], donusum[13], donusum[14], donusum[15] };
            Array.Sort(sira4); 
             m = 0;
             h = 0;
             g = 4;
            for (int i = h; i < g; i++)
            {
                if (0<=h&&h<4)
                {

                   oyunlar[i].Text = (sira1[i] == 0) ? "" : sira1[i].ToString();

                }
                else if (4<=h&&h<8)
                {
                    oyunlar[i].Text = (sira2[i-4] == 0) ? "" : sira2[i-4].ToString();
                }
                else if (8<=h&&h<12)
                {
                    oyunlar[i].Text = (sira3[i-8] == 0) ? "" : sira3[i-8].ToString();
                }
                else if(12<=h&&h<16) 
                {
                    oyunlar[i].Text = (sira4[i-12] == 0) ? "" : sira4[i-12].ToString();
                }
                else
                {
                    break;
                }
                
                m++;
                if (m%4==0)
                {
                    h += 4;
                    g += 4;
                }
                
            }
            int ekle = rnd.Next(16);
            while (oyunlar[ekle].Text != "")
            {
                ekle = rnd.Next(16);
            }
            oyunlar[ekle].Text = "2";


        }


    }
}

