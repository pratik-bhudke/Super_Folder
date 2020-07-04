using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        string usr_pwd, og_pwd;
        string pw_file = "C:\\ProgramData\\sysapp.dll";

        System.Diagnostics.Process process = new System.Diagnostics.Process();

        public Form2()
        {
            InitializeComponent();
            if (!File.Exists(pw_file))
            {
                    File.AppendAllText(pw_file, "12345");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            og_pwd = File.ReadAllText("C:\\ProgramData\\sysapp.dll");
            usr_pwd = maskedTextBox1.Text;
            if (usr_pwd == "")
            {
                MessageBox.Show("Blank Password.....  :-|");
                maskedTextBox1.Text = "";
            }
            else if (usr_pwd != og_pwd)
            {
                MessageBox.Show("Incorrect Password..... :-(");
                maskedTextBox1.Text = "";
            }
            else if (usr_pwd == og_pwd)
            {
                this.Hide();
                var form1 = new Form1();
                //form1.Close += (sbyte,args) => this.Close();
                form1.FormClosed += (s,args) => this.Close();
                form1.Show();
            }
        }
    }
}
