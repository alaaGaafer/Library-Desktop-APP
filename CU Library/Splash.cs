using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CU_Library
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Increment(7);
            if(progressBar1.Value ==100)
            {
                timer1.Stop();
                Log_In log = new Log_In();
                this.Hide();
                log.Show();
            }
        }
    }
}
