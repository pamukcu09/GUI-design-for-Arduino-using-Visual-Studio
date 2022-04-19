using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void onButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A");
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");
        }
    }
}
