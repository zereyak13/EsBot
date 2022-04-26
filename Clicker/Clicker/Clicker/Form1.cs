using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
namespace Clicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);


        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */

        
        bool kayital = false ;
        List<Point> kayitlar = new List<Point>();
        Random rnd = new Random();


        private bool onlyOnce;

        private int dolu;
        private int bos;
        public Form1()
        {
            InitializeComponent();

            
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && kayital == true)
            {
                dataGridView1.Rows.Add(Cursor.Position);
                kayitlar.Add(Cursor.Position);
            }
            //if(e.KeyCode == Keys.Escape)
            //{
            //    this.Close();
            //}


        }

        private void button1_Click(object sender, EventArgs e)//
        {
            kayital = true;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)//
        {
            kayital = false;
            button4.Enabled = true;
            button1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)//sıfırla
        {
            dataGridView1.Rows.Clear();
            kayitlar.Clear();
            textBox1.Text = "10";
            textBox2.Text = "60";

            label4.Text = "00:00:00";
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer1.Interval = 100;
            timer2.Interval = 100;

            button1.Enabled = true;
          
        }

        private void button4_Click(object sender, EventArgs e)//aktif
        {
            if(Convert.ToInt32(textBox4.Text)!= 0)
            {
                timer3.Interval = Convert.ToInt32(textBox4.Text) * 1000 * 60;
                timer3.Enabled = true;
            }
            timer1.Enabled = true;

            int end = Convert.ToInt32(textBox2.Text) * 1000 * 60;
            timer2.Interval = end;
            timer2.Enabled = true;

            dolu = Convert.ToInt32(textBox5.Text);
            bos = Convert.ToInt32(textBox6.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Mouse hareket halinde ise SIFIRLAYAMASIN
            button5.Visible = false;
            
            /* VURUŞLARI SADECE DOLU NOKTALARDA YAPAR*/
            if(dolu > 0)
            {
                dolu--;

                if(dolu > 0)
                {
                    panel4.BackColor = Color.Lime;
                }
                else
                {
                    panel4.BackColor = Color.DarkOliveGreen;
                }

                for (int i = 0; i < kayitlar.Count; i++)
                {

                    if (i == 0)
                    {
                        Thread.Sleep(800);
                    }

                    Cursor.Position = kayitlar[i];
                    Thread.Sleep(rnd.Next(30, 70));
                    mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    Thread.Sleep(rnd.Next(30, 80));
                    mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                    Thread.Sleep(rnd.Next(1500, 1800));

                }
               

                bos = Convert.ToInt32(textBox6.Text);
            }
            else if(bos > 0)
            {
                bos--;
            }

            if(dolu <=0 && bos <= 0)
            {
                dolu = Convert.ToInt32(textBox5.Text);

                panel4.BackColor = Color.Lime;

            }
            /* VURUŞLARI SADECE DOLU NOKTALARDA YAPAR*/

            int tam = Convert.ToInt32(textBox1.Text) * 1000 * 60;
            int yuzde3 = tam * 3 / 100;
            int rate = rnd.Next(tam - yuzde3, tam + yuzde3);


            if (onlyOnce == false && Convert.ToInt32(textBox4.Text) != 0)
            {
                timer1.Enabled = false;
                onlyOnce = true;
            }

            //1 kere test için çalış sonra ileri tarihe kadar deaktive et.
            if(timer1.Enabled == true)
            {
                /* CALCULATE NEXT HIT POINT*/
                int curHour = DateTime.Now.Hour;
                int curMinute = DateTime.Now.Minute;
                int curSecond = DateTime.Now.Second;

                int RateDakika = rate / 1000 / 60;
                int remainingSeconds = (rate / 1000) % 60;
                //Set Sec
                curSecond = curSecond + remainingSeconds;
                int minutPlus = 0;
                if (curSecond >= 60)
                {
                    minutPlus = 1;
                    curSecond = curSecond % 60;
                }
                //Set Min
                curMinute = curMinute + (RateDakika + minutPlus);
                int hourPlus = 0;
                if (curMinute >= 60)
                {
                    float value = curMinute / 60;
                    hourPlus = (int)Math.Floor(value);

                    curMinute = curMinute % 60;
                }
                //Set Hour
                curHour = curHour + hourPlus;
                if (curHour >= 24)
                {
                    curHour = curHour - 24;
                }
                /* NEXT HIT POINT CALCULATED*/

                //Labelda başında sayı her zaman 2 haneli olmalı
                string curHourString;
                string curMinuteString;
                string curSecondString;
                if (curHour < 10)
                    curHourString = "0" + curHour;
                else
                    curHourString = "" + curHour;
                if (curMinute < 10)
                    curMinuteString = "0" + curMinute;
                else
                    curMinuteString = "" + curMinute;
                if (curSecond < 10)
                    curSecondString = "0" + curSecond;
                else
                    curSecondString = "" + curSecond;

                label4.Text = curHourString + ":" + curMinuteString + ":" + curSecondString;

            }

            timer1.Interval = rate;

            button5.Visible = true;
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int kapatmaZamanı = Convert.ToInt32(textBox3.Text) * 60;
            Process.Start("shutdown.exe", "-s -t " + kapatmaZamanı.ToString());

            button6.Enabled = false;
            button7.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-a");


            button6.Enabled = true;
            button7.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //İleri tarih süresi bitince timer 1 devreye sokacak.
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

