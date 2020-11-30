using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPUTrn
{
    public partial class Form1 : Form
    {
        int pos1 = 1;
        int pos2 = -1;
        Timer timer = new Timer();
        Timer timer2 = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer2.Interval = 6000;
            timer2.Tick += new EventHandler(timer2_Tick);
            if (checkBox1.Checked == true)
            {
                timer2.Start();
            }
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            if (Properties.Settings.Default.isChecked == true)
            {
                checkBox1.Checked = true;
            }

            else if (Properties.Settings.Default.isChecked == false)
            {
                checkBox1.Checked = false;
            }
        }

        void timer_Tick (object sender, EventArgs e)
        {
            panel1.Location = new Point(panel1.Location.X + pos1, panel1.Location.Y + pos1);
            panel2.Location = new Point(panel2.Location.X + pos2, panel2.Location.Y + pos2);
            panel3.Location = new Point(panel3.Location.X, panel3.Location.Y + pos1);
        }

        void timer2_Tick (object sender, EventArgs e)
        {
            panel1.Location = new Point(273, 171);
            panel2.Location = new Point(438, 149);
            panel3.Location = new Point(295, 12);
            Console.Beep();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                timer2.Start();
                Properties.Settings.Default.isChecked = true;
                Properties.Settings.Default.Save();
            }

            else if (checkBox1.Checked == false)
            {
                timer2.Stop();
                Properties.Settings.Default.isChecked = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
