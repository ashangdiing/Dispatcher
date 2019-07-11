using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispatcher.Custom_Controls
{
    public partial class DialogBox : Form
    {
        public DialogBox()
        {
            InitializeComponent();
        }

        private void DialogBox_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void DialogBox_FormClosing(object sender, FormClosingEventArgs e)
        {
          //  this.Hide();
            //e.Cancel =true;
        }
    }
}
