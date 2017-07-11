using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kindergarden.GUI
{
    public partial class LoginPanel : UserControl
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int m = int.Parse(userText.Text);
                Main.getMainPanel().openMenu(m);
            }
            catch (FormatException g)
            {
                Console.WriteLine(g.Message);
            }
        }
    }
}
