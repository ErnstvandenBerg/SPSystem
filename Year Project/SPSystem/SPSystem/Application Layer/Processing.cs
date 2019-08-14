using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SPSystem.Application_Layer
{
    class Processing
    {

        public int[] Parkingspaces = new int[10];
        Datahandler datahandler = new Datahandler();
        BindingSource binding = new BindingSource();
        List<CarSimulation> cars = new List<CarSimulation>();
        public int temp = 0;
        public int TopSpace = 3;
        public int BottomSpace = 4;
        public int RightSpace = 3;
        Timer MyTimer = new Timer();
        Timer ExitTimer = new Timer();
        Form2 form2 = new Form2();

        public void IntializeTimer()
        {
            MyTimer.Interval = (1000);
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            ExitTimer.Interval = (1000);
            ExitTimer.Tick += new EventHandler(ExitTimer_Tick);
        }
        private void ExitTimer_Tick(object sender, EventArgs e)
        {
            form2.pExit.BackColor = Color.DarkRed;
            form2.btnAddCar.Enabled = true;
            ExitTimer.Stop();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            form2.pEntrance.BackColor = Color.DarkRed;
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
                            form2.pSpace1.BackColor = Color.DarkRed;
                            BottomSpace--;
                            break;
                        case 1:
                            form2.pSpace2.BackColor = Color.DarkRed;
                            TopSpace--;
                            break;
                        case 2:
                            form2.pSpace3.BackColor = Color.DarkRed;
                            BottomSpace--;
                            break;
                        case 3:
                            form2.pSpace4.BackColor = Color.DarkRed;
                            RightSpace--;
                            break;
                        case 4:
                            form2.pSpace5.BackColor = Color.DarkRed;
                            TopSpace--;
                            break;
                        case 5:
                            form2.pSpace6.BackColor = Color.DarkRed;
                            TopSpace--;
                            break;
                        case 6:
                            form2.pSpace7.BackColor = Color.DarkRed;
                            BottomSpace--;
                            break;
                        case 7:
                            form2.pSpace8.BackColor = Color.DarkRed;
                            BottomSpace--;
                            break;
                        case 8:
                            form2.pSpace9.BackColor = Color.DarkRed;
                            RightSpace--;
                            break;
                        case 9:
                            form2.pSpace10.BackColor = Color.DarkRed;
                            RightSpace--;
                            break;
                        default:
                            break;
                    }
                    temp++;
                    form2.btnRemove.Enabled = true;
                    Random random = new Random();
                    TimeSpan duration = new TimeSpan(random.Next(0, 12), 0, 0);
                    string timeIN = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
                    string TimeOUT = DateTime.Now.Add(duration).ToString("MM/dd/yyyy hh:mm tt");
                    CarSimulation newCar = new CarSimulation(0, timeIN, TimeOUT);
                    datahandler.Insert(newCar);
                    form2.lblParkingleftTop.Text = "Parking Spaces Left: " + (TopSpace);
                    form2.lblParkingLeftBottom.Text = "Parking Spaces Left: " + (BottomSpace);
                    form2.lblParkingLeftRight.Text = "Parking Spaces Left: " + (RightSpace);
                    MyTimer.Stop();
                }
                else
                {
                    MyTimer.Stop();
                    MessageBox.Show("Parking is full");
                }
            }

        }

        public void Addcar()
        {
            if (Parkingspaces[0] == 1 && Parkingspaces[1] == 1 && Parkingspaces[2] == 1 && Parkingspaces[3] == 1 && Parkingspaces[4] == 1 && Parkingspaces[5] == 1 && Parkingspaces[6] == 1 && Parkingspaces[7] == 1 && Parkingspaces[8] == 1 && Parkingspaces[9] == 1)
            {
                MessageBox.Show("Parking lot is full!!!");
                MyTimer.Stop();
            }
            else
            {
                form2.pEntrance.BackColor = Color.ForestGreen;
                MyTimer.Start();
                form2.btnRemove.Enabled = false;
            }
        }
    }
}
