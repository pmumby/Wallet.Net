using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Wallet.Net
{
    public partial class SplashForm : Form
    {
        static Timer CountdownTimer;

        public SplashForm()
        {
            InitializeComponent();            
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            CountdownTimer = new Timer();
            CountdownTimer.Interval = 10;
            string path = "file://"+Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName) + "\\SplashPage.htm";
            webBrowser1.Navigate(path);
            CountdownTimer.Tick += new EventHandler(CountdownTimer_Tick);
            CountdownTimer.Start();
        }

        void CountdownTimer_Tick(object sender, EventArgs e)
        {
            CountdownTimer.Stop();
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(MainThread));
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            this.Close();
        }

        [STAThread]
        public static void MainThread()
        {
            MainForm main = new MainForm();
            Application.Run(main);
        }
    }
}
