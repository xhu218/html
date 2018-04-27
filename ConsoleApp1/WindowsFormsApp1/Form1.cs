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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = this.textBox1.Text;
            String[] ips = txt.Split('\r', '\n');
           
            String map = "net use h: \\\\{0}\\c$ \"Pass2word\" /user:\"Administrator\"";
            String copy1 = @"copy c:\qqpcmgr_207638.exe h:\";
            String copy2 = "copy c:\\ConsoleApp1.exe \"h:\\Users\\Administrator\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\";
            String del = "net use h: /del";

            StringBuilder sb = new StringBuilder();
            foreach (var ip in ips)
            {
                if (!String.IsNullOrEmpty(ip))
                {
                    sb.AppendLine(String.Format(map, ip));
                    sb.AppendLine(copy1);
                    sb.AppendLine(copy2);
                    sb.AppendLine(del);
                    sb.AppendLine();

                }
            }
            File.WriteAllText(String.Format(@"{0}\{1}.bat", AppDomain.CurrentDomain.BaseDirectory, DateTime.Now.ToString("yyyyMMdd")), sb.ToString(),Encoding.ASCII);
            this.textBox2.Text = "finised.";


        }
    }
}
