using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Timers.Timer;


namespace dis_lab_2
{
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();

            Timer DataTimeTimer = new Timer();
            DataTimeTimer.Interval = 1000;

            // Hook up the Elapsed event for the timer. 
            DataTimeTimer.Elapsed += UpdateDataTimeTimer;

            // Have the timer fire repeated events (true is the default)
            DataTimeTimer.AutoReset = true;

            // Start the timer
            DataTimeTimer.Enabled = true;
        }
        private void MainApp_Load(object sender, EventArgs e)
        {
            /*
            DateTime CurrentDateTime = DateTime.Now;
            toolStripStatusLabel2.Text = CurrentDateTime.ToString();
            */
        }
        private void UpdateDataTimeTimer(Object source, System.Timers.ElapsedEventArgs e)
        {
            DateTime CurrentDateTime = DateTime.Now;
            toolStripStatusLabel2.Text = CurrentDateTime.ToString();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
