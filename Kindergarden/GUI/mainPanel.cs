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
    public partial class MainPanel : UserControl
    {
        public MainPanel()
        {

            InitializeComponent();
            this.panel2.Controls.Add(new LoginPanel());
        }

        public void openMenu(int user)
        {
            Console.WriteLine(user);
            //Choose which menu buttons to show
            var buttons = new MenuButtons();
            switch (user)
            {
                case 1:
                    Main.getMainPanel().panel2.Controls.Clear();
                    buttons.chooseButtons(1);
                    panel1.Controls.Add(buttons);
                    break;

                case 2:

                    break;

                default:
                    break;

            }

        }


        public void setUpdateKidsPanel()
        {
            panel2.Controls.Add(new UpdateKid());
        }

    }
}
