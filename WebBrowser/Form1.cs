using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            string webPage = textAddress.Text.Trim();

            webBrowser1.Navigate(webPage);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void buttonBack_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonBack, "Back on Page");
            buttonBack.Image = imageList1.Images[5];
        }

        private void buttonFwd_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonFwd, "Forward on Page");
            buttonFwd.Image = imageList1.Images[6];
        }

        private void buttonHome_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonHome, "Home");
            buttonHome.Image = imageList1.Images[7];
        }

        private void buttonStop_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonStop, "Stop");
            buttonStop.Image = imageList1.Images[8];
        }

        private void buttonRefresh_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(buttonRefresh, "Refresh");
            buttonRefresh.Image = imageList1.Images[9];
        }

        private void buttonBack_MouseLeave(object sender, EventArgs e)
        {
            buttonBack.Image = imageList1.Images[0];
        }

        private void buttonFwd_MouseLeave(object sender, EventArgs e)
        {
            buttonFwd.Image = imageList1.Images[1];
        }

        private void buttonHome_MouseLeave(object sender, EventArgs e)
        {
            buttonHome.Image = imageList1.Images[2];
        }

        private void buttonStop_MouseLeave(object sender, EventArgs e)
        {
            buttonStop.Image = imageList1.Images[3];
        }

        private void buttonRefresh_MouseLeave(object sender, EventArgs e)
        {
            buttonRefresh.Image = imageList1.Images[4];
        }
    }
    
    
    
}
