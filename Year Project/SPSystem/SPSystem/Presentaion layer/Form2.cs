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
         


        }
        Application_Layer.Processing processing = new Application_Layer.Processing();
        private void Label11_Click(object sender, EventArgs e)
        {

        }

       
        

        private void Form2_Load(object sender, EventArgs e)
        {
           
            
        }

        private void ExitTimer_Tick(object sender, EventArgs e)
        {
           
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
           
            
        }

  

        private void Button1_Click_1(object sender, EventArgs e)
        {
            processing.Addcar();
        }

        private void BtnRemove_Click_1(object sender, EventArgs e)
        {

        }
    }
}
