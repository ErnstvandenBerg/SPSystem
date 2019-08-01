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
        //private static void InitArray()
        //{
        //    int[] arr = new int[10];
        //    Random rnd = new Random();
        //    int tmp;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        tmp = rnd.Next(11);
        //        while (IsDup(tmp,arr))
        //        {
        //            tmp = rnd.Next(11);

        //        }
        //        arr[i] = tmp;
        //    }
        //    printthearr(arr);
        //}

        //private static void printthearr(int[] arr)
        //{
        //    foreach (var item in arr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //private static bool IsDup(int tmp, int[] arr)
        //{
        //    foreach (var item in arr)
        //    {
        //        if (item == tmp)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        private void Button1_Click(object sender, EventArgs e)
        {
            Random random1 = new Random();
            int Parkinglot = 0;
            int temp = 0;
            List<int> ranNumbers = new List<int>();
            if (Parkingspaces[0] == 1 && Parkingspaces[1] == 1 && Parkingspaces[2] == 1 && Parkingspaces[3] == 1 && Parkingspaces[4] == 1 && Parkingspaces[5] == 1 && Parkingspaces[6] == 1 && Parkingspaces[7] == 1 && Parkingspaces[8] == 1 && Parkingspaces[9] == 1)
            {
                MessageBox.Show("Parking lot is full!!!");
            }
            else
            {
                //Parkinglot = random1.Next(0, 10);

                ////if (ranNumbers.Contains(Parkinglot))
                ////{
                ////    Parkinglot = random.Next(0, 10);
                ////}
                ////else
                ////{
                ////    Parkingspaces[Parkinglot] = 1;
                ////    ranNumbers.Add(Parkinglot);
                ////}
                ////if (Parkingspaces[Parkinglot] == 1)
                ////{
                ////    Parkinglot = random.Next(0, 10);
                ////    Parkingspaces[Parkinglot] = 1;
                ////}
                ////else
                ////{
                ////    Parkingspaces[Parkinglot] = 1;
                ////}


                //List<int> arraynumber = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                //List<int> possible = Enumerable.Range(0, 10).ToList();
                //Parkinglot = random1.Next(0, possible.Count());
                //temp = arraynumber[Parkinglot];
                //arraynumber.RemoveAt(Parkinglot);
                //Parkingspaces[temp] = 1;




                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Random a = new Random();
                //List<int> randomList = new List<int>();
                //int MyNumber = 0;
                //MyNumber = a.Next(0, 10);
                //if (!randomList.Contains(MyNumber))
                //{
                //    temp = MyNumber;
                //    randomList.Add(MyNumber);
                //}
                //if (randomList.Contains(temp))
                //{
                //    MessageBox.Show("beep beep");
                //}


                
            }
            MessageBox.Show((temp +1).ToString());
            switch (temp)
            {
                case 0: pSpace1.BackColor = Color.DarkRed;
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
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
