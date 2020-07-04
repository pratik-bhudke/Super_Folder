using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string folder;
        string final_command = "cmd.exe";
        string command1 = "/c icacls ";
        string command2 = "/c attrib ";
        string para1 = "+r +h +s ";
        string para2 = "-r -h -s ";
        string para3 = " /deny Everyone:(RD,D,DC)";
        string para4 = " /inheritance:r";
        string para5 = " /grant Everyone:(OI)(CI)(RX,RC,WDAC,WO,S,WD,AD,REA,WEA,RA,WA) /T";
        string para6 = " /reset";

        Process process = new System.Diagnostics.Process();
        
        public Form1()
        {
            InitializeComponent();
            textBox2.ReadOnly = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arg = command1 + "\"" + folder + "\"" + para3;
            process.StartInfo.FileName = final_command;
            process.StartInfo.Arguments = arg;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            Process.Start(process.StartInfo);
            MessageBox.Show("Yesss, its Locked...  :-)");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string arg = command1 + "\"" + folder + "\"" + para6;
            process.StartInfo.FileName = final_command;
            process.StartInfo.Arguments = arg;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            Process.Start(process.StartInfo);
            MessageBox.Show("Unlocked Successfully...  :-)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string arg = command2 + para1 + "\"" + folder + "\"";
            process.StartInfo.FileName = final_command;
            process.StartInfo.Arguments = arg;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            Process.Start(process.StartInfo);
            MessageBox.Show("Yesss, its Successfully Hidden...  :-)");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string arg = command2 + para2 + "\"" + folder + "\"";
            process.StartInfo.FileName = final_command;
            process.StartInfo.Arguments = arg;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            Process.Start(process.StartInfo);
            MessageBox.Show("Folder is now Unhidden...  :-)");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string arg1 = command1 + "\"" + folder + "\"" + para3;
            string arg2 = command2 + para1 + "\"" + folder + "\"";
            process.StartInfo.FileName = final_command;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = arg1;
            Process.Start(process.StartInfo);
            process.StartInfo.Arguments = arg2;
            Process.Start(process.StartInfo);
            MessageBox.Show("Yippeee, its Locked & Hidden now...  :-)");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string arg1 = command1 + "\"" + folder + "\"" + para6;
            string arg2 = command2 + para2 + "\"" + folder + "\"";
            process.StartInfo.FileName = final_command;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = arg1;
            Process.Start(process.StartInfo);
            process.StartInfo.Arguments = arg2;
            Process.Start(process.StartInfo);
            MessageBox.Show("Folder is Unlocked & Unhidden...  :-!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string arg1 = command1 + "\"" + folder + "\"" + para4;
            string arg2 = command1 + "\"" + folder + "\"" + para5;
            process.StartInfo.FileName = final_command;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.Arguments = arg1;
            Process.Start(process.StartInfo);
            process.StartInfo.Arguments = arg2;
            Process.Start(process.StartInfo);
            MessageBox.Show("Yay, ur folder is undeletable...  :-)");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string arg = command1 + "\"" + folder + "\"" + para6;
            process.StartInfo.FileName = final_command;
            process.StartInfo.Arguments = arg;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.UseShellExecute = false;
            Process.Start(process.StartInfo);
            MessageBox.Show("Your folder is Normal now...  :-|");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox2.Text = folder = folderBrowserDialog1.SelectedPath;
            if (folder == "")
            {
                textBox2.Text = "Select a folder for operation.....";
            }
            if(folder!="")
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new Form4().ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Form5().ShowDialog();
        }
    }
}
