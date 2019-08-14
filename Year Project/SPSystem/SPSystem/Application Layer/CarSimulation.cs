using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPSystem
{
    class CarSimulation
    {
        private int user;

        public int User
        {
            get { return user; }
            set { user = value; }
        }

        private string timeIN;

        public string Timein
        {
            get { return timeIN; }
            set { timeIN = value; }
        }
        private string timeOUT;

        public string TimeOUT
        {
            get { return timeOUT; }
            set { timeOUT = value; }
        }

        public CarSimulation(int user, string timeIN, string timeOUT)
        {
            this.user = user;
            this.timeIN = timeIN;
            this.timeOUT = timeOUT;
        }
    }
}
