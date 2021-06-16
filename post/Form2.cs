using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace post
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            {


                string bruh = "chromedriver.exe";

                bool fileExist = File.Exists(bruh);
                if (fileExist)

                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();


                }
                else
                {
                    MessageBox.Show("Wait a minute. Downloading chromedriver.exe");

                    WebClient webClient1 = new WebClient();
                    webClient1.DownloadFile("https://cdn.discordapp.com/attachments/807651439346319413/854658951705919518/chromedriver.exe", "chromedriver.exe");

                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();
                    
                }
            }
        }
    }
}
