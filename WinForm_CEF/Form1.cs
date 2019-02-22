using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_CEF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         ChromiumWebBrowser browser;
        private void Form1_Load(object sender, EventArgs e)
        {
            // 避免页面加载不出来, 建议加上这句
            Cef.Initialize(new CefSettings());

            browser = new ChromiumWebBrowser("www.bing.com")
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(browser);
        }
    }
}
