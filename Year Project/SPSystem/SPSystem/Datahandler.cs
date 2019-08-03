using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SPSystem
{
    class Datahandler
    {
        string connectionstring = @"Data Source=DESKTOP-8ENEMI0;Initial Catalog=SPSystemDB;Integrated Security=True;Pooling=False";

        SqlConnection connectionobject = null;
        SqlCommand sqlCommandobject = null;
        SqlDataReader reader = null;

        public List<CarSimulation> Read()
        {
            List<CarSimulation> cars = new List<CarSimulation>();
            try
            {
                connectionobject = new SqlConnection(connectionstring);
                connectionobject.Open();

                string Select = "SELECT * FROM ParkingData";
                sqlCommandobject = new SqlCommand(Select, connectionobject);

                reader = sqlCommandobject.ExecuteReader();

                while (reader.Read())
                {
                    cars.Add(new CarSimulation(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString()));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (connectionobject != null)
                {
                    connectionobject.Close();
                }
            }
            return cars;
        }

        public void Insert(CarSimulation car)
        {
            try
            {
                connectionobject = new SqlConnection(connectionstring);
                connectionobject.Open();

                int user = car.User;
                string TimeIn = car.Timein;
                string TimeOut = car.TimeOUT;

                string insertCommandQuery = @"INSERT INTO ParkingData (TimeIN,TimeOut) Values ('" + TimeIn + "','" + TimeOut + "')";

                sqlCommandobject = new SqlCommand(insertCommandQuery, connectionobject);

                sqlCommandobject.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (connectionobject != null)
                {
                    connectionobject.Close();
                }
            }


        }

        public void Update(CarSimulation Car)
        {
            try
            {
                connectionobject = new SqlConnection(connectionstring);
                connectionobject.Open();

                int User = Car.User;
                
                string timeOut = Car.TimeOUT;
                string updateCommandQuery = @"Update ParkingData SET TimeOut='"+timeOut+"' where User ='" + User + "'";

                sqlCommandobject = new SqlCommand(updateCommandQuery, connectionobject);
                sqlCommandobject.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                MessageBox.Show("Update " + e.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (connectionobject != null)
                {
                    connectionobject.Close();
                }
            }

        }
    }
}
