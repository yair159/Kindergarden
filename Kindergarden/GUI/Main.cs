using Kindergarden.GUI;
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
            con = new MainPanel();
            windowPanel.Controls.Add(con);
            //buttonsPanel.BackColor = Color.FromArgb(0, 0, 0, 0);
            /*SQLConnection s = new SQLConnection();
            s.executeProc(null);*/
            //buttonsPanel.Controls.Add(new MenuButtons());
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public static MainPanel getMainPanel()
        {
            return con;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void setMainPanel()
        {
            windowPanel.Controls.Clear();
            windowPanel.Controls.Add(con);
        }

        
    }
}
