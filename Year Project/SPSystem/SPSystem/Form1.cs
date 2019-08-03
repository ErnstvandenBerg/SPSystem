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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Datahandler datahandler = new Datahandler();
        BindingSource binding = new BindingSource();
        List<CarSimulation> cars = new List<CarSimulation>();
        private void Form1_Load(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
           
            cars = datahandler.Read();
            tboxNumberPlate.Text = @"n/a";
            foreach (var item in cars)
            {
                listBox1.Items.Add(item.User);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (var item in cars)
            {
                if ((listBox1.SelectedIndex + 1) == item.User)
                {
                    tboxUser.Text = item.User.ToString();
                    tboxTimeIN.Text = item.Timein.ToString();
                    tboxTimeOUT.Text = item.TimeOUT.ToString();
                    DateTime date1 = Convert.ToDateTime(item.Timein);
                    DateTime date2 = Convert.ToDateTime(item.TimeOUT);
                    TimeSpan value = date2.Subtract(date1);
                    tboxTotalDuration.Text = value.ToString(); 

                }
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            cars = datahandler.Read();
            foreach (var item in cars)
            {
                listBox1.Items.Add(item.User);
            }
        }
    }
}
