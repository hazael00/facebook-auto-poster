using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Remote;
using System.IO;
using Microsoft.Win32;
using System.Net;

namespace post
{
    public partial class Form1 : MaterialForm
    {
        IWebDriver driver = new ChromeDriver();

        

        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;

        

        public Form1()
        {


            InitializeComponent();


            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

           
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


        }

        private void Form1_Load(object sender, EventArgs e)
        


            {
               

             

            }
        

            

                






            
        

        private void materialButton3_Click(object sender, EventArgs e)
        {
            driver.Navigate().GoToUrl("https://m.facebook.com/");
           
            IWebElement gmail = driver.FindElement(By.Name("email"));

            gmail.SendKeys(gmailtext.Text);

            IWebElement pass = driver.FindElement(By.Name("pass"));

            pass.SendKeys(passtext.Text);


            IWebElement login = driver.FindElement(By.Name("login"));
            login.Click();

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            double sa = Convert.ToDouble(startnumbertext.Text);

            double ass = Convert.ToDouble(stopnumbertext.Text);



            checkBox1.Checked = false;

            IWebElement postclick = driver.FindElement(By.XPath("(//div[@class='_5xu4'])[2]"));
            postclick.Click();

             
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); //5



            IWebElement textarea = driver.FindElement(By.XPath("//textarea[contains(@id,'uniqid_1')]"));

            textarea.SendKeys("#" + teamnametext.Text);
            textarea.SendKeys(OpenQA.Selenium.Keys.Enter);
            textarea.SendKeys(linktext.Text);
            textarea.SendKeys(OpenQA.Selenium.Keys.Enter);





            textarea.SendKeys("#" + sa++.ToString());

            startnumbertext.Text = sa.ToString();


            IWebElement sharebutton = driver.FindElement(By.XPath("(//button[contains(@data-sigil,'composer')])[5]"));

            sharebutton.Click();

          
           driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            if (sa.ToString() == ass++.ToString())

                stoppost.PerformClick();






            if (checkBox1.Checked == true)

                ;

            else

                startpost.PerformClick();


           



        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void stoppost_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            






        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


            driver.Quit();

            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
                if (p.ProcessName == "chromedriver")
                    p.Kill();


            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
                if (p.ProcessName == "Google Crash Handler")
                    p.Kill();

            foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
                if (p.ProcessName == "post")
                    p.Kill();


        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
