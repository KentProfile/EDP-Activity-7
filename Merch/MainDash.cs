using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merch
{
    public partial class MainDash : Form
    {
        public MainDash()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, EventArgs e)
        {
            product.Visible = false;
            account.Visible = true;
            Account1.Visible = true;
        }
    }
}
