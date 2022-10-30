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

namespace assignment7UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, address, type;
            long mobile, balance, accountNumber;
            name = textBox1.Text;
            address = textBox2.Text;
            mobile = long.Parse(textBox3.Text);
            type = domainUpDown1.SelectedItem.ToString();
            accountNumber = long.Parse(textBox4.Text);
            balance = long.Parse(textBox5.Text);
           // MessageBox.Show("Name: "+name+"\nAddress: "+address+"\nMobile: "+mobile+"\nAccount Type: "+type+"\nAccount No: "+accountNumber+"\nAccount Balance: "+balance);
            TextWriter txt = new StreamWriter("c:\\newFile1\\info.txt");
            txt.Write("Name: "+name);
            txt.Write("\nAddress: "+address);
            txt.Write("\nMobile: " + mobile);
            txt.Write("\nAccount Type: " + type);
            txt.Write("\nAccount No: " + accountNumber);
            txt.Write("\nAccount Balance: " + balance);
            txt.Close();

             var fs = new FileStream("c:\\newFile1\\info.txt", FileMode.Open, FileAccess.Read);
             var sr = new StreamReader(fs, Encoding.UTF8);

            string content = sr.ReadToEnd();

            Console.WriteLine(content);
        }
    }
}
