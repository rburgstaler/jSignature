using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using jSignature.Tools;
using Newtonsoft.Json;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Base30Converter bc = new Base30Converter();
            string base30 = "3E13Z5Y5_1O24Z66_1O1Z3_3E2Z4";
            base30 = textBox2.Text;
            int[][][] output = bc.GetData(base30);
            textBox1.Text += Environment.NewLine + base30;
            textBox1.Text += Environment.NewLine + JsonConvert.SerializeObject(output, Formatting.None);

            List<int> val = new List<int>() { 100, 1, 3, -5, 5 };
            textBox1.Text += Environment.NewLine + bc.CompressStrokeLeg(val.ToArray());
            textBox1.Text += Environment.NewLine + bc.GetBase30Representation(output);

        }
    }
}
