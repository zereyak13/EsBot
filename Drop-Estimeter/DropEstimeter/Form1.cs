using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DropEstimeter
{
    public partial class Form1 : Form
    {
        

        Form2 goForm2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        string eSimText;

        private void Find_Data_Click(object sender, EventArgs e)
        {
            if(textBox1.Text== "https://server.e-sim.org/apiFights.html?battleId=warId&roundId=roundIdC")
            {
                MessageBox.Show("Please change server + warId + roundIdC \n like deriva,1869,8");
            }
            else
            {
                //Öncelikle istenilen adrese istek atıp, bu istek ile çıktımızı alıyoruz alıyoruz.
                string apıAdress = textBox1.Text;
                WebRequest request = WebRequest.Create(apıAdress);
                WebResponse response = request.GetResponse();
                //Artık elimizde veri kaynağı var okumak için streamReader yapısını aşağıdaaki gibi kullanıyoruz.
                StreamReader read = new StreamReader(response.GetResponseStream());
                eSimText = read.ReadToEnd();//okuyup kaydettik.
                Save_Data.Enabled = true;
            }
          
        }

        private void Close_APP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Data_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "adress")
            {
                MessageBox.Show ("Please, choose an adress to save data " +
                    "such as : C\\desktop\\......");

            }
            else
            {
                goForm2.fileAdress = textBox2.Text + "\\E-sim.txt";//Form 2 den verileri al.DOsya YOLU
                //dosya oluşturup içine verileri kaydet..
                StreamWriter eSimFile = new StreamWriter(textBox2.Text+"\\E-sim.txt");
                
                //Elde edilen veriyi düzelt..               
                
                string[] lines = Regex.Split(eSimText, ("},"));
                ss.Items.Clear();//Temizle tekrar yaz
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines.Length - i != 1)
                    {
                        lines[i] = lines[i] + "},";
                        ss.Items.Add(lines[i]);
                    }
                    else
                    {
                        lines[i] = lines[i];
                        ss.Items.Add(lines[i]);
                    }
                                                     
                   
                }
               
                for(int i = 0; i < lines.Length; i++)
                {
                    eSimFile.WriteLine(lines[i]);
                }
                eSimFile.Close();
               
                

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void nextPage_Click(object sender, EventArgs e)
        {         
            goForm2.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
