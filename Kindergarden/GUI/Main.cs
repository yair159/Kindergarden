using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarden
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            panel1.BackColor = Color.FromArgb(0, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(0, 0, 0, 0);
            SQLConnection s = new SQLConnection();
            s.executeProc(null);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        /*  private void mainButton_Click(object sender, EventArgs e)
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
          }*/
    }
}
