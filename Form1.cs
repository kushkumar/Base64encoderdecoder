using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base64encoderdecoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(richTextBox1.Text);
                   this.richTextBox2.Text =System.Convert.ToBase64String(plainTextBytes);
}

        private void button2_Click(object sender, EventArgs e)
        {
           
  var base64EncodedBytes = System.Convert.FromBase64String(richTextBox1.Text);
  this.richTextBox2.Text= System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        }
    }

