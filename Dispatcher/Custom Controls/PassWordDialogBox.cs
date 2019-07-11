using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispatcher.Custom_Controls
{
    public partial class PassWordDialogBox : UserControl
    {
        public PassWordDialogBox()
        {
            InitializeComponent();
        }

        private void roomInfoSubmit_Click(object sender, EventArgs e)
        {
           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Button cancelButton= sender as Button;
            DialogBox db=cancelButton.Parent.Parent as DialogBox;
            db.Close();
        }
    }
}
