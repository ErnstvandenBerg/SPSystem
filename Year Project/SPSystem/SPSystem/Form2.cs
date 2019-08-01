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

        private void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int Parkinglot = 0;
            if (Parkingspaces[0] == 1 && Parkingspaces[1] == 1 && Parkingspaces[2] == 1 && Parkingspaces[3] == 1 && Parkingspaces[4] == 1 && Parkingspaces[5] == 1 && Parkingspaces[6] == 1 && Parkingspaces[7] == 1 && Parkingspaces[8] == 1 && Parkingspaces[9] == 1)
            {
                MessageBox.Show("Parking lot is full!!!");
            }
            else
            {
                Parkinglot = random.Next(0, 10);
                if (Parkingspaces[Parkinglot] == 1)
                {
                    Parkinglot = random.Next(0, 10);
                    Parkingspaces[Parkinglot] = 1;
                }
                else
                {
                    Parkingspaces[Parkinglot] = 1;
                }
            }
            MessageBox.Show(Parkinglot.ToString());
            switch (Parkinglot)
            {
                case 0: pSpace1.BackColor = Color.DarkRed;
                    break;
                case 1:
                    pSpace1.BackColor = Color.DarkRed;
                    break;
                case 2:
                    pSpace1.BackColor = Color.DarkRed;
                    break;
                case 3:
                    pSpace1.BackColor = Color.DarkRed;
                    break;
                case 4:
                    pSpace1.BackColor = Color.DarkRed;
                    break;
                case 5:
                    pSpace1.BackColor = Color.DarkRed;
                    break;
                case 6:
                    pSpace1.BackColor = Color.DarkRed;
                    break;
                case 7:
                    pSpace1.BackColor = Color.DarkRed;
                    break;
                case 8:
                    pSpace1.BackColor = Color.DarkRed;
                    break;
                case 9:
                    pSpace1.BackColor = Color.DarkRed;
                    break;
                default:
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
