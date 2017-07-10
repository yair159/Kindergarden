using System;
using System.Data.SqlClient;

class SQLConnection
{
  
    private static string connstring = "Data Source = mydb.clhc9gw7vvuf.eu-west-2.rds.amazonaws.com; Initial Catalog = KindergardenSolution; User ID = HaifaKinderProj; Password = 12345678";
    private static SqlConnection conn;

    public SQLConnection()
    {
        conn = new SqlConnection(connstring);
    }

    public void closeSQL()
    {
        conn.Close();
    }



   public void executeProc(String s) { 
        //Create the connection object
        using (conn = new SqlConnection(connstring))
        {
            // Open the SqlConnection.
            conn.Open();
            //Create the SQLCommand object
            using (SqlCommand command = new SqlCommand("deleteKid", conn) { CommandType = System.Data.CommandType.StoredProcedure })
            {
                //Pass the parameter values here
                command.Parameters.AddWithValue("@kid", "101122855524");
                /*command.Parameters.AddWithValue("@YourSpParameter", "ParameterValue");*/
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //read the data
                    /*while (reader.Read())
                    {
                        Console.WriteLine(reader["total"].ToString());
                    }*/
                }

            }
            conn.Close();
        }
    }

    /*
    private void mainButton_Click(object sender, EventArgs e)
    {
        var ashboard = new Dashboard();
        panel2.Controls.Add(ashboard);

    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
        panel2.Controls.Clear();
    }
    */
}

