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

        public CarSimulation(int user)
        {
            this.user = user;
        }
    }
}
