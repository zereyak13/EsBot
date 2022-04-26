using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DropEstimeter
{
    public partial class Form2 : Form
    {
        int playerId, totalHit, totalDamage, wep0, wep1, wep2, wep3, wep4, wep5 ;

      

        public string fileAdress;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Close_APP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HOME_Click(object sender, EventArgs e)
        {
            
            Form1 goForm1 = new Form1();
            goForm1.Show();
            this.Hide();
        }
        private void Form2_Load(object sender, EventArgs e)//İstenilenleri seç data gridview e at.
        {
            if (fileAdress != null)
            {


                string line;
                FileStream fs = new FileStream(fileAdress, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while ((line = sr.ReadLine()) != null)//line line işle....
                {
                    bool isBerserk = false;
                    wep0 = 0; wep1 = 0; wep2 = 0; wep3 = 0; wep4 = 0; wep5 = 0; totalDamage = 0;
                    //İd yi al
                    int firstIndexOfId = (line.IndexOf("\"citizenId\":"));
                    if (firstIndexOfId != -1)
                    {
                        firstIndexOfId += "\"citizenId\":".Length;
                        int lastIndexOfId = line.Substring(firstIndexOfId).IndexOf(",");
                        playerId = Convert.ToInt32(line.Substring(firstIndexOfId, lastIndexOfId));
                        //dataGridView1.Rows.Add(playerId.ToString());//idleri kontrol edip yazdıracak

                    }
                    //MessageBox.Show(playerId.ToString());
                    //hit sayısını al
                    int firstIndexOfHit = (line.IndexOf("\"berserk\":"));
                    if (firstIndexOfHit != -1)
                    {
                        firstIndexOfHit += "\"berserk\":".Length;
                        int lastIndexOfHit = line.Substring(firstIndexOfHit).IndexOf(",");
                        isBerserk = ("true" == (line.Substring(firstIndexOfHit, lastIndexOfHit)));
                        if (isBerserk == true)
                        {
                            totalHit = 5;
                        }
                        else
                        {
                            totalHit = 1;
                        }
                        //dataGridView1.Rows.Add(playerId.ToString(), totalHit.ToString());
                    }
                    //Kullanılan wep tipi ve sayısı...?
                    int firstIndexOfWep = (line.IndexOf("\"weapon\":"));
                    if (firstIndexOfWep != -1)
                    {
                        firstIndexOfWep += "\"weapon\":".Length;
                        int lastIndexOfWep = Convert.ToInt32(line.Substring(firstIndexOfWep).IndexOf(","));
                        int weptype = Convert.ToInt32(line.Substring(firstIndexOfWep, lastIndexOfWep));
                        switch (weptype)
                        {
                            case 0:
                                if (isBerserk == true)
                                {
                                    wep0 += 5;
                                }
                                else
                                {
                                    wep0 += 1;
                                }

                                break;
                            case 1:
                                if (isBerserk == true)
                                {
                                    wep1 += 5;
                                }
                                else
                                {
                                    wep1 += 1;
                                }

                                break;
                            case 2:
                                if (isBerserk == true)
                                {
                                    wep2 += 5;
                                }
                                else
                                {
                                    wep2 += 1;
                                }

                                break;
                            case 3:
                                if (isBerserk == true)
                                {
                                    wep3 += 5;
                                }
                                else
                                {
                                    wep3 += 1;
                                }

                                break;
                            case 4:
                                if (isBerserk == true)
                                {
                                    wep4 += 5;
                                }
                                else
                                {
                                    wep4 += 1;
                                }

                                break;
                            case 5:
                                if (isBerserk == true)
                                {
                                    wep5 += 5;
                                }
                                else
                                {
                                    wep5 += 1;
                                }

                                break;

                        }
                    }

                    //totaldmage verilerini al 
                    int firstIndexOfTotalDmg = (line.IndexOf("\"damage\":"));
                    if (firstIndexOfTotalDmg != -1)
                    {
                        firstIndexOfTotalDmg += "\"damage\":".Length;
                        int lastIndexOfTotalDmg = line.Substring(firstIndexOfTotalDmg).IndexOf(",");
                        totalDamage = Convert.ToInt32(line.Substring(firstIndexOfTotalDmg, lastIndexOfTotalDmg));
                        dataGridView1.Rows.Add(playerId.ToString(), totalHit.ToString(), totalDamage.ToString(), wep0, wep1, wep2, wep3, wep4, wep5.ToString());
                    }

                }
                fs.Close();
                sr.Close();
            }

        }
        //Sql e kaydet
        private void Save_Sql_Click(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection(@"Data Source=DESKTOP-L15MFCN;Initial Catalog=eSim;Integrated Security=True");
            
            for(int i =0; i < dataGridView1.RowCount - 1; i++)
            {
                SqlCommand sCmd = new SqlCommand(@"INSERT INTO WarInfo 
                    (OyuncuId, OyuncuHit, TotalDamage, Wep0, Wep1, Wep2, Wep3, Wep4, Wep5 )
                    VALUES('"+dataGridView1.Rows[i].Cells[0].Value+"', '"+dataGridView1.Rows[i].Cells[1].Value+"', '"+dataGridView1.Rows[i].Cells[2].Value+"', '"+dataGridView1.Rows[i].Cells[3].Value+"', '"+dataGridView1.Rows[i].Cells[4].Value+"'," +
                    "'"+dataGridView1.Rows[i].Cells[5].Value+"', '"+dataGridView1.Rows[i].Cells[6].Value+"', '"+dataGridView1.Rows[i].Cells[7].Value+"', '"+dataGridView1.Rows[i].Cells[8].Value+"')", sCon);
                sCon.Open();
                sCmd.ExecuteNonQuery();
                sCon.Close();
            }
        }
        private void SqlClear_Click(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection(@"Data Source=DESKTOP-L15MFCN;Initial Catalog=eSim;Integrated Security=True");
            SqlCommand sCmd = new SqlCommand(@"TRUNCATE TABLE WarInfo",sCon);
            sCon.Open();
            sCmd.ExecuteNonQuery();
            sCon.Close();
        }

        private void Optimize_Et_Click(object sender, EventArgs e)
        {
            //Datagridden diziye aktarım yapıldı.
            int count = 0;
            string[,] gridArray = new string[dataGridView1.RowCount-1, dataGridView1.ColumnCount-1];//rowcount boş satırıda sayıyor bu sebeple -1
            for (int i=0; i < dataGridView1.RowCount-1; i++) //rowcount -1..
            {
                for (int j = 0; j < dataGridView1.ColumnCount-1; j++)//drop control yok.
                {
                    //dataGridView1.Rows[e.RowIndex].Cells["Your Coloumn name"].Value.ToString();
                    gridArray[i, j] = dataGridView1.Rows[i].Cells[j].Value.ToString();                               
                    count += 1;                  
                }
            }
            
            //Aynı olanları tek değere ata.*****************
            //string[,] gridArrayNew;


            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (int j = i + 1; j < dataGridView1.RowCount - 1; j++)
                {                  
                    if (gridArray[i, 0] == gridArray[j, 0])
                    {
                        for (int t = 1; t < dataGridView1.ColumnCount-1; t++)//dropcontolune bakma
                        {
                            gridArray[i, t] = (Convert.ToInt32(gridArray[i, t]) + Convert.ToInt32(gridArray[j, t])).ToString();

                        }
                    }

                }
            }
            //Aynı Id ye sahip olanların fazlalıklarını null olarak tutarak GridArrayLast listesine aldık.
            List<string> varOlanlar = new List<string>();
            string[,] gridArrayLast = new string[gridArray.GetLength(0), gridArray.GetLength(1)];
           
            for (int i = 0; i < dataGridView1.RowCount - 1; i++) 
            {
                string indisDeger = gridArray[i, 0];
                if (!varOlanlar.Contains(indisDeger))
                {
                    varOlanlar.Add(indisDeger);
                    
                    for (int j = 0; j < dataGridView1.ColumnCount-1; j++) 
                    {
                        gridArrayLast[i, j] = gridArray[i, j];
                    }
                }

            }

            //gridArrayLast'tan Null değilse yeni diziden DataGrid e ekle.*****************

            dataGridView1.Rows.Clear();
            List<string> eklenecekler = new List<string>();
            

            for (int i = 0; i < gridArrayLast.GetLength(0); i++)
            {
                                 
                if (gridArrayLast[i,0] != null)
                {
                  
                    for (int j = 0; j < gridArrayLast.GetLength(1); j++)
                    {
                        eklenecekler.Add ( gridArrayLast[i, j]);
                        
                    }
                    dataGridView1.Rows.Add(eklenecekler[0],eklenecekler[1],eklenecekler[2],eklenecekler[3],eklenecekler[4],eklenecekler[5],eklenecekler[6],eklenecekler[7],eklenecekler[8],0);
                    eklenecekler.Clear();
                }

            }
          
            //control***************

            //for (int i = 0; i < dataGridView1.RowCount -1; i++) //rowcount -1..
            //{
            //    for (int j = 0; j < dataGridView1.ColumnCount; j++)
            //    {
            //        MessageBox.Show(gridArrayLast[i,j]);
            //    }
            //}


        }



    }
}
