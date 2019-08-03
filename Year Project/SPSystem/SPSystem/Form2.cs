using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SPSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            for (int i = 0; i < Parkingspaces.Length; i++)
            {
                Parkingspaces[i] = 0;
            }


        }
        int[] Parkingspaces = new int[10];
        
        private void Label11_Click(object sender, EventArgs e)
        {

        }

        public int temp = 0;
        Timer MyTimer = new Timer();
        Timer ExitTimer = new Timer();
        private void Button1_Click(object sender, EventArgs e)
        {
            pEntrance.BackColor = Color.ForestGreen;
            MyTimer.Start();
            btnRemove.Enabled = false;

            //if (Parkingspaces[0] == 1 && Parkingspaces[1] == 1 && Parkingspaces[2] == 1 && Parkingspaces[3] == 1 && Parkingspaces[4] == 1 && Parkingspaces[5] == 1 && Parkingspaces[6] == 1 && Parkingspaces[7] == 1 && Parkingspaces[8] == 1 && Parkingspaces[9] == 1)
            //{
            //    MessageBox.Show("Parking lot is full!!!");
            //}
            //else
            //{


            //    if (temp < 10)
            //    {



            //        MessageBox.Show((temp + 1).ToString());
            //        switch (temp)
            //        {
            //            case 0:
            //                pSpace1.BackColor = Color.DarkRed;
            //                break;
            //            case 1:
            //                pSpace2.BackColor = Color.DarkRed;
            //                break;
            //            case 2:
            //                pSpace3.BackColor = Color.DarkRed;
            //                break;
            //            case 3:
            //                pSpace4.BackColor = Color.DarkRed;
            //                break;
            //            case 4:
            //                pSpace5.BackColor = Color.DarkRed;
            //                break;
            //            case 5:
            //                pSpace6.BackColor = Color.DarkRed;
            //                break;
            //            case 6:
            //                pSpace7.BackColor = Color.DarkRed;
            //                break;
            //            case 7:
            //                pSpace8.BackColor = Color.DarkRed;
            //                break;
            //            case 8:
            //                pSpace9.BackColor = Color.DarkRed;
            //                break;
            //            case 9:
            //                pSpace10.BackColor = Color.DarkRed;
            //                break;
            //            default:
            //                break;
            //        }
            //        temp++;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Parking is full");
            //    }
            //}
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
            MyTimer.Interval = (1000); // 45 mins
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            ExitTimer.Interval = (1000); // 45 mins
            ExitTimer.Tick += new EventHandler(ExitTimer_Tick);

        }

        private void ExitTimer_Tick(object sender, EventArgs e)
        {
            pExit.BackColor = Color.DarkRed;
            button1.Enabled = true;
            ExitTimer.Stop();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            pEntrance.BackColor = Color.DarkRed;
            if (Parkingspaces[0] == 1 && Parkingspaces[1] == 1 && Parkingspaces[2] == 1 && Parkingspaces[3] == 1 && Parkingspaces[4] == 1 && Parkingspaces[5] == 1 && Parkingspaces[6] == 1 && Parkingspaces[7] == 1 && Parkingspaces[8] == 1 && Parkingspaces[9] == 1)
            {
                MessageBox.Show("Parking lot is full!!!");
                MyTimer.Stop();
            }
            else
            {


                if (temp < 10)
                {



                    //MessageBox.Show((temp + 1).ToString());
                    switch (temp)
                    {
                        case 0:
                            pSpace1.BackColor = Color.DarkRed;
                            break;
                        case 1:
                            pSpace2.BackColor = Color.DarkRed;
                            break;
                        case 2:
                            pSpace3.BackColor = Color.DarkRed;
                            break;
                        case 3:
                            pSpace4.BackColor = Color.DarkRed;
                            break;
                        case 4:
                            pSpace5.BackColor = Color.DarkRed;
                            break;
                        case 5:
                            pSpace6.BackColor = Color.DarkRed;
                            break;
                        case 6:
                            pSpace7.BackColor = Color.DarkRed;
                            break;
                        case 7:
                            pSpace8.BackColor = Color.DarkRed;
                            break;
                        case 8:
                            pSpace9.BackColor = Color.DarkRed;
                            break;
                        case 9:
                            pSpace10.BackColor = Color.DarkRed;
                            break;
                        default:
                            break;
                    }
                    temp++;
                    btnRemove.Enabled = true;
                    MyTimer.Stop();
                }
                else
                {
                    MyTimer.Stop();
                    MessageBox.Show("Parking is full");
                }
            }
            
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            

            if (temp > 0)
            {

                temp--;
                //MessageBox.Show((temp + 1).ToString());
                switch (temp)
                {
                    case 0:
                        pSpace1.BackColor = Color.ForestGreen;
                        break;
                    case 1:
                        pSpace2.BackColor = Color.ForestGreen;
                        break;
                    case 2:
                        pSpace3.BackColor = Color.ForestGreen;
                        break;
                    case 3:
                        pSpace4.BackColor = Color.ForestGreen;
                        break;
                    case 4:
                        pSpace5.BackColor = Color.ForestGreen;
                        break;
                    case 5:
                        pSpace6.BackColor = Color.ForestGreen;
                        break;
                    case 6:
                        pSpace7.BackColor = Color.ForestGreen;
                        break;
                    case 7:
                        pSpace8.BackColor = Color.ForestGreen;
                        break;
                    case 8:
                        pSpace9.BackColor = Color.ForestGreen;
                        break;
                    case 9:
                        pSpace10.BackColor = Color.ForestGreen;
                        break;
                    default:
                        break;
                }
                ExitTimer.Start();
                button1.Enabled = false;
                pExit.BackColor = Color.ForestGreen;
            }
            else
            {
                MessageBox.Show("No cars left");
            }
        }
    }
}
