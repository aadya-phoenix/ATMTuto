using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMTuto
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int starting = 0;
        

        private void Splash_Load(object sender, EventArgs e)
        {

            if (starting == 0)
            {

                Login log = new Login();
                this.Hide();
                log.Show();
            }

        }
    }
}
