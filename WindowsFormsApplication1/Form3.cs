using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        string usr_pwd, og_pwd;
        string pw_file = "C:\\ProgramData\\sysapp.dll";

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("\'Current Password\' field is blank.... :-|");
                textBox3.Text = textBox2.Text = textBox1.Text = "";
            }
            else
            {
                og_pwd = File.ReadAllText(pw_file);
                usr_pwd = textBox1.Text;
                if (usr_pwd != og_pwd)
                {
                    MessageBox.Show("Original Password doesn\'t match ur supplied \'Current Password\' :-(");
                    textBox3.Text = textBox2.Text = textBox1.Text = "";

                }
                else if (textBox2.Text != textBox3.Text)
                {
                    MessageBox.Show("\'Confirm Password\' doesn\'t match \'New Password\'");
                    textBox3.Text = textBox2.Text = textBox1.Text = "";
                }
                else if ((textBox2.Text == "") && (textBox3.Text==""))
                {
                    MessageBox.Show("\'Confirm Password\' and \'New Password\' fields are blank... :-|");
                    textBox3.Text = textBox2.Text = textBox1.Text = "";
                }
                else if ((usr_pwd == og_pwd) && (textBox2.Text == textBox3.Text))
                {
                    File.WriteAllText(pw_file, textBox3.Text);
                    MessageBox.Show("Password changed Successfully.....  ;-)");
                    this.Close();
                }
            }
            
        }
    }
}
